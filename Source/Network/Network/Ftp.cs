using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Asfw.Network
{
  public sealed class Ftp : IDisposable
  {
    private readonly NetworkCredential _credential;
    public int BufferSize = 8192;

    public Ftp(NetworkCredential credentials) => this._credential = credentials;

    public void Dispose()
    {
    }

    public void DeleteFile(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "DELE";
      ftpWebRequest.GetResponse().Close();
    }

    public void DownloadFile(string url, string localFile)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "RETR";
      using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (FileStream fileStream = new FileStream(localFile, FileMode.Create))
          {
            if (responseStream == null)
              throw new EndOfStreamException("Stream was empty.");
            byte[] buffer = new byte[this.BufferSize];
            for (int count = responseStream.Read(buffer, 0, this.BufferSize); count > 0; count = responseStream.Read(buffer, 0, this.BufferSize))
              fileStream.Write(buffer, 0, count);
          }
        }
      }
    }

    public string GetDateTimestamp(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "MDTM";
      using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          if (responseStream == null)
            throw new EndOfStreamException("Stream was empty.");
          using (StreamReader streamReader = new StreamReader(responseStream))
            return streamReader.ReadToEnd();
        }
      }
    }

    public long GetFileSize(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "SIZE";
      using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
        return response.ContentLength;
    }

    public string[] ListDirectory(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "NLST";
      using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          if (responseStream == null)
            throw new EndOfStreamException("Stream was empty.");
          using (StreamReader streamReader = new StreamReader(responseStream))
          {
            List<string> stringList = new List<string>();
            while (streamReader.Peek() != -1)
              stringList.Add(streamReader.ReadLine());
            return stringList.ToArray();
          }
        }
      }
    }

    public string[] ListDirectoryDetails(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "LIST";
      using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          if (responseStream == null)
            throw new EndOfStreamException("Stream was empty.");
          using (StreamReader streamReader = new StreamReader(responseStream))
          {
            List<string> stringList = new List<string>();
            while (streamReader.Peek() != -1)
              stringList.Add(streamReader.ReadLine());
            return stringList.ToArray();
          }
        }
      }
    }

    public void MakeDirectory(string url)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "MKD";
      ftpWebRequest.GetResponse().Close();
    }

    public void Rename(string url, string name)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "RENAME";
      ftpWebRequest.RenameTo = name;
      ftpWebRequest.GetResponse().Close();
    }

    public void UploadFile(string url, string localFile)
    {
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(url);
      ftpWebRequest.Credentials = (ICredentials) this._credential;
      ftpWebRequest.KeepAlive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.Method = "STOR";
      using (Stream requestStream = ftpWebRequest.GetRequestStream())
      {
        using (FileStream fileStream = new FileStream(localFile, FileMode.Create))
        {
          byte[] buffer = new byte[this.BufferSize];
          for (int count = fileStream.Read(buffer, 0, this.BufferSize); count != 0; count = fileStream.Read(buffer, 0, this.BufferSize))
            requestStream.Write(buffer, 0, count);
        }
      }
    }
  }
}
