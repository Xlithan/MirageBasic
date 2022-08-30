using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Asfw.IO
{
  public static class TextFile
  {
    public static void AddLine(string path, string input)
    {
      string contents = File.ReadAllText(path) + Environment.NewLine + input;
      File.WriteAllText(path, contents);
    }

    public static bool CompareVar(string path, string header, string name, string input) => TextFile.Read(path, header, name) == input;

    public static bool StringExists(string path, string input) => ((IEnumerable<string>) File.ReadAllLines(path)).Any<string>((Func<string, bool>) (t => t == input));

    public static void RemoveString(string path, string input)
    {
      string[] strArray = File.ReadAllLines(path);
      if (strArray.Length < 1)
        return;
      string contents = strArray[0];
      if (strArray.Length > 1)
      {
        for (int index = 1; index < strArray.Length; ++index)
        {
          if (strArray[index] != input)
            contents = contents + Environment.NewLine + strArray[index];
        }
      }
      File.WriteAllText(path, contents);
    }

    public static void ClearFile(string path)
    {
      if (!File.Exists(path))
        return;
      File.Delete(path);
      File.Create(path).Dispose();
    }

    public static string Read(string path, string header, string name)
    {
      string[] strArray = File.ReadAllLines(path);
      bool flag = false;
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (flag)
        {
          if (strArray[index].StartsWith(name + "=", StringComparison.Ordinal))
            return strArray[index].Substring(name.Length + 1);
          if (strArray[index].StartsWith("[", StringComparison.Ordinal) && strArray[index].EndsWith("]", StringComparison.Ordinal))
            return "";
        }
        else
          flag |= strArray[index].StartsWith("[" + header + "]", StringComparison.Ordinal);
      }
      return "";
    }

    public static void Write(string path, string header, string name, string value)
    {
      string[] contents = File.ReadAllLines(path);
      bool flag = false;
      for (int index = 0; index < contents.Length; ++index)
      {
        if (flag)
        {
          if (contents[index].StartsWith(name + "=", StringComparison.Ordinal))
          {
            contents[index] = name + "=" + value;
            File.WriteAllLines(path, contents);
            break;
          }
        }
        else
          flag |= contents[index].StartsWith("[" + header + "]", StringComparison.Ordinal);
      }
    }

    public static string GetVar(string path, string header, string name)
    {
      string[] strArray = File.ReadAllLines(path);
      bool flag = false;
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (flag)
        {
          if (strArray[index].StartsWith(name + "=", StringComparison.Ordinal))
            return strArray[index].Substring(name.Length + 1);
          if (strArray[index].StartsWith("[", StringComparison.Ordinal) && strArray[index].EndsWith("]", StringComparison.Ordinal))
          {
            string contents = strArray[0];
            int num1 = index - 1;
            int num2 = 1;
            while (index < strArray.Length)
            {
              contents = contents + Environment.NewLine + strArray[index];
              if (num2 == num1)
                contents = contents + Environment.NewLine + "[" + header + "]" + Environment.NewLine + name + "=";
              ++num2;
            }
            File.WriteAllText(path, contents);
            return "";
          }
        }
        else
          flag |= strArray[index].StartsWith("[" + header + "]", StringComparison.Ordinal);
      }
      if (!flag)
      {
        string str = "";
        if (strArray.Length != 0)
        {
          str = strArray[0];
          if (strArray.Length > 1)
          {
            for (int index = 1; index < strArray.Length; ++index)
              str = str + Environment.NewLine + strArray[index];
          }
        }
        string contents = str + Environment.NewLine + "[" + header + "]" + Environment.NewLine + name + "=";
        File.WriteAllText(path, contents);
      }
      return "";
    }

    public static void PutVar(string path, string header, string name, string value)
    {
      string[] contents1 = File.ReadAllLines(path);
      bool flag = false;
      for (int index = 0; index < contents1.Length; ++index)
      {
        if (flag)
        {
          if (contents1[index].StartsWith(name + "=", StringComparison.Ordinal))
          {
            contents1[index] = name + "=" + value;
            File.WriteAllLines(path, contents1);
            return;
          }
          if (contents1[index].StartsWith("[", StringComparison.Ordinal) && contents1[index].EndsWith("]", StringComparison.Ordinal))
          {
            string contents2 = contents1[0];
            int num1 = index - 1;
            int num2 = 1;
            while (index < contents1.Length)
            {
              contents2 = contents2 + Environment.NewLine + contents1[index];
              if (num2 == num1)
                contents2 = contents2 + Environment.NewLine + "[" + header + "]" + Environment.NewLine + name + "=" + value;
              ++num2;
            }
            File.WriteAllText(path, contents2);
            return;
          }
        }
        else
          flag |= contents1[index].StartsWith("[" + header + "]", StringComparison.Ordinal);
      }
      if (flag)
        return;
      string str = "";
      if (contents1.Length != 0)
      {
        str = contents1[0];
        if (contents1.Length > 1)
        {
          for (int index = 1; index < contents1.Length; ++index)
            str = str + Environment.NewLine + contents1[index];
        }
      }
      string contents3 = str + Environment.NewLine + "[" + header + "]" + Environment.NewLine + name + "=" + value;
      File.WriteAllText(path, contents3);
    }
  }
}
