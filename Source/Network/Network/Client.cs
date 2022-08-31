﻿using System;
using System.Net;
using System.Net.Sockets;

namespace Asfw.Network
{
  public sealed class Client : IDisposable
  {
    private Socket _socket;
    private byte[] _receiveBuffer;
    private byte[] _packetRing;
    private int _packetCount;
    private int _packetSize;
    private bool _connecting;
    public Client.DataArgs[] PacketId;

    public bool ThreadControl { get; set; }

    public event Client.ConnectionArgs ConnectionSuccess;

    public event Client.ConnectionArgs ConnectionFailed;

    public event Client.ConnectionArgs ConnectionLost;

    public event Client.CrashReportArgs CrashReport;

    public event Client.PacketInfoArgs PacketReceived;

    public event Client.TrafficInfoArgs TrafficReceived;

    public Client(int packetCount, int packetSize = 8192)
    {
      if (this._socket != null)
        return;
      if (packetSize <= 0)
        packetSize = 8192;
      this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      this._socket.NoDelay = true;
      this._packetCount = packetCount;
      this._packetSize = packetSize;
      this.PacketId = new Client.DataArgs[packetCount];
    }

    public void Dispose()
    {
      if (this._socket == null)
        return;
      this.Disconnect();
      this._socket.Close();
      this._socket.Dispose();
      this._socket = (Socket) null;
      this.PacketId = (Client.DataArgs[]) null;
      this.ConnectionSuccess = (Client.ConnectionArgs) null;
      this.ConnectionFailed = (Client.ConnectionArgs) null;
      this.ConnectionLost = (Client.ConnectionArgs) null;
      this.CrashReport = (Client.CrashReportArgs) null;
      this.PacketReceived = (Client.PacketInfoArgs) null;
      this.TrafficReceived = (Client.TrafficInfoArgs) null;
      this.PacketId = (Client.DataArgs[]) null;
    }

    public void Connect(string ip, int port)
    {
      if (this._socket == null || this._socket.Connected || this._connecting)
        return;
      if (ip.ToLower() == "localhost")
      {
        this._socket.BeginConnect((EndPoint) new IPEndPoint(IPAddress.Parse("127.0.0.1"), port), new AsyncCallback(this.DoConnect), (object) null);
      }
      else
      {
        this._connecting = true;
        this._socket.BeginConnect((EndPoint) new IPEndPoint(IPAddress.Parse(ip), port), new AsyncCallback(this.DoConnect), (object) null);
      }
    }

    private void DoConnect(IAsyncResult ar)
    {
      if (this._socket == null)
        return;
      try
      {
        this._socket.EndConnect(ar);
      }
      catch
      {
        Client.ConnectionArgs connectionFailed = this.ConnectionFailed;
        if (connectionFailed != null)
          connectionFailed();
        this._connecting = false;
        return;
      }
      if (!this._socket.Connected)
      {
        Client.ConnectionArgs connectionFailed = this.ConnectionFailed;
        if (connectionFailed != null)
          connectionFailed();
        this._connecting = false;
      }
      else
      {
        this._connecting = false;
        Client.ConnectionArgs connectionSuccess = this.ConnectionSuccess;
        if (connectionSuccess != null)
          connectionSuccess();
        this._socket.ReceiveBufferSize = this._packetSize;
        this._socket.SendBufferSize = this._packetSize;
        if (this.ThreadControl)
          return;
        this.BeginReceiveData();
      }
    }

    public bool IsConnected => this._socket != null && this._socket.Connected;

    public void Disconnect()
    {
      if (this._socket == null || !this._socket.Connected)
        return;
      this._socket.BeginDisconnect(false, new AsyncCallback(this.DoDisconnect), (object) null);
    }

    private void DoDisconnect(IAsyncResult ar)
    {
      if (this._socket == null)
        return;
      try
      {
        this._socket.EndDisconnect(ar);
      }
      catch
      {
      }
      Client.ConnectionArgs connectionLost = this.ConnectionLost;
      if (connectionLost == null)
        return;
      connectionLost();
    }

    private void BeginReceiveData()
    {
      this._receiveBuffer = new byte[this._packetSize];
      this._socket.BeginReceive(this._receiveBuffer, 0, this._packetSize, SocketFlags.None, new AsyncCallback(this.DoReceive), (object) null);
    }

    private void DoReceive(IAsyncResult ar)
    {
      if (this._socket == null)
        return;
      int length1;
      try
      {
        length1 = this._socket.EndReceive(ar);
      }
      catch
      {
        Client.CrashReportArgs crashReport = this.CrashReport;
        if (crashReport != null)
          crashReport("ConnectionForciblyClosedException");
        this.Disconnect();
        return;
      }
      if (length1 < 1)
      {
        if (this._socket == null)
          return;
        Client.CrashReportArgs crashReport = this.CrashReport;
        if (crashReport != null)
          crashReport("BufferUnderflowException");
        this.Disconnect();
      }
      else
      {
        Client.TrafficInfoArgs trafficReceived = this.TrafficReceived;
        if (trafficReceived != null)
          trafficReceived(length1, ref this._receiveBuffer);
        if (this._packetRing == null)
        {
          this._packetRing = new byte[length1];
          Buffer.BlockCopy((Array) this._receiveBuffer, 0, (Array) this._packetRing, 0, length1);
        }
        else
        {
          int length2 = this._packetRing.Length;
          byte[] dst = new byte[length2 + length1];
          Buffer.BlockCopy((Array) this._packetRing, 0, (Array) dst, 0, length2);
          Buffer.BlockCopy((Array) this._receiveBuffer, 0, (Array) dst, length2, length1);
          this._packetRing = dst;
        }
        this.PacketHandler();
        this._receiveBuffer = new byte[this._packetSize];
        this._socket.BeginReceive(this._receiveBuffer, 0, this._packetSize, SocketFlags.None, new AsyncCallback(this.DoReceive), (object) null);
      }
    }

    private void PacketHandler()
    {
      int length1 = this._packetRing.Length;
      int num = 0;
      int count;
      while (true)
      {
        count = length1 - num;
        if (count >= 4)
        {
          int int32_1 = BitConverter.ToInt32(this._packetRing, num);
          if (int32_1 >= 4)
          {
            if (int32_1 <= count)
            {
              int startIndex = num + 4;
              int int32_2 = BitConverter.ToInt32(this._packetRing, startIndex);
              if (int32_2 >= 0 && int32_2 < this._packetCount)
              {
                if (this.PacketId[int32_2] != null)
                {
                  int length2 = int32_1 - 4;
                  byte[] data = new byte[length2];
                  if (length2 > 0)
                    Buffer.BlockCopy((Array) this._packetRing, startIndex + 4, (Array) data, 0, length2);
                  Client.PacketInfoArgs packetReceived = this.PacketReceived;
                  if (packetReceived != null)
                    packetReceived(length2, int32_2, ref data);
                  this.PacketId[int32_2](ref data);
                  num = startIndex + int32_1;
                }
                else
                  break;
              }
              else
                goto label_14;
            }
            else
              goto label_20;
          }
          else
            goto label_17;
        }
        else
          goto label_20;
      }
      Client.CrashReportArgs crashReport1 = this.CrashReport;
      if (crashReport1 != null)
        crashReport1("NullReferenceException");
      this.Disconnect();
      return;
label_14:
      Client.CrashReportArgs crashReport2 = this.CrashReport;
      if (crashReport2 != null)
        crashReport2("IndexOutOfRangeException");
      this.Disconnect();
      return;
label_17:
      Client.CrashReportArgs crashReport3 = this.CrashReport;
      if (crashReport3 != null)
        crashReport3("BrokenPacketException");
      this.Disconnect();
      return;
label_20:
      if (count == 0)
      {
        this._packetRing = (byte[]) null;
      }
      else
      {
        byte[] dst = new byte[count];
        Buffer.BlockCopy((Array) this._packetRing, num, (Array) dst, 0, count);
        this._packetRing = dst;
      }
    }

    public void ReceiveData()
    {
      if (!this.ThreadControl)
        return;
      this._receiveBuffer = new byte[this._packetSize];
      this._socket.ReceiveTimeout = 1;
      try
      {
        SocketError errorCode;
        int length1 = this._socket.Receive(this._receiveBuffer, 0, this._packetSize, SocketFlags.None, out errorCode);
        if (errorCode == SocketError.TimedOut)
          return;
        if (errorCode != SocketError.Success)
          throw new Exception(string.Format("Receive error: {0}", (object) errorCode));
        if (length1 < 1)
          return;
        Client.TrafficInfoArgs trafficReceived = this.TrafficReceived;
        if (trafficReceived != null)
          trafficReceived(length1, ref this._receiveBuffer);
        if (this._packetRing == null)
        {
          this._packetRing = new byte[length1];
          Buffer.BlockCopy((Array) this._receiveBuffer, 0, (Array) this._packetRing, 0, length1);
        }
        else
        {
          int length2 = this._packetRing.Length;
          byte[] dst = new byte[length2 + length1];
          Buffer.BlockCopy((Array) this._packetRing, 0, (Array) dst, 0, length2);
          Buffer.BlockCopy((Array) this._receiveBuffer, 0, (Array) dst, length2, length1);
          this._packetRing = dst;
        }
        this.PacketHandler();
        this._receiveBuffer = new byte[this._packetSize];
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("Something went wrong with receiving a packet! Err:[{0}]", (object) ex));
      }
    }

    public void SendData(byte[] data)
    {
      if (!this._socket.Connected)
        return;
      this._socket?.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(this.DoSend), (object) null);
    }

    public void SendData(byte[] data, int head)
    {
      if (!this._socket.Connected)
        return;
      byte[] numArray = new byte[head + 4];
      Buffer.BlockCopy((Array) BitConverter.GetBytes(head), 0, (Array) numArray, 0, 4);
      Buffer.BlockCopy((Array) data, 0, (Array) numArray, 4, head);
      this._socket?.BeginSend(numArray, 0, head + 4, SocketFlags.None, new AsyncCallback(this.DoSend), (object) null);
    }

    private void DoSend(IAsyncResult ar)
    {
      try
      {
        this._socket.EndSend(ar);
      }
      catch
      {
        Client.CrashReportArgs crashReport = this.CrashReport;
        if (crashReport != null)
          crashReport("ConnectionForciblyClosedException");
        this.Disconnect();
      }
    }

    public delegate void ConnectionArgs();

    public delegate void DataArgs(ref byte[] data);

    public delegate void CrashReportArgs(string reason);

    public delegate void PacketInfoArgs(int size, int header, ref byte[] data);

    public delegate void TrafficInfoArgs(int size, ref byte[] data);
  }
}
