using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SLMPLauncher
{
    public class FuncParser
    {
        static List<string> cacheFile = new List<string>();
        static int startIndex = -1;
        static int enbIndex = -1;
        static int lineIndex = -1;
        static bool blockClearEK = false;
        static bool blockClearSR = false;
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static bool keyExists(string path, string section, string key)
        {
            startIndex = -1;
            enbIndex = -1;
            lineIndex = -1;
            bool findSection = false;
            bool findKey = false;
            if (File.Exists(path) && !string.IsNullOrEmpty(section) && !string.IsNullOrEmpty(key))
            {
                cacheFile = new List<string>(File.ReadAllLines(path));
                for (int i = 0; i < cacheFile.Count; i++)
                {
                    if (!findSection && cacheFile[i].ToLower() == "[" + section.ToLower() + "]")
                    {
                        findSection = true;
                        startIndex = i;
                        enbIndex = i;
                    }
                    else if (findSection && cacheFile[i].StartsWith("[") && cacheFile[i].EndsWith("]"))
                    {
                        break;
                    }
                    else if (findSection && cacheFile[i].Length > 0)
                    {
                        if (cacheFile[i].ToLower().StartsWith(key.ToLower() + "="))
                        {
                            findKey = true;
                            lineIndex = i;
                            break;
                        }
                        else
                        {
                            enbIndex = i;
                        }
                    }
                }
            }
            if (!blockClearEK)
            {
                cacheFile = null;
            }
            return findKey;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static string stringRead(string path, string section, string key)
        {
            string outString = null;
            blockClearEK = true;
            if (keyExists(path, section, key))
            {
                outString = cacheFile[lineIndex].Remove(0, (key + "=").Length);
                if (outString.Length == 0)
                {
                    outString = null;
                }
            }
            blockClearEK = false;
            if (!blockClearSR)
            {
                cacheFile = null;
            }
            return outString;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static void iniWrite(string path, string section, string key, string value)
        {
            bool readyToWrite = false;
            blockClearSR = true;
            string line = stringRead(path, section, key);
            blockClearSR = false;
            if (lineIndex != -1)
            {
                if (line == null || value == null || line.ToLower() != value.ToLower())
                {
                    cacheFile[lineIndex] = key + "=" + value;
                    readyToWrite = true;
                }
            }
            else
            {
                if (startIndex != -1 && enbIndex != -1)
                {
                    cacheFile[enbIndex] += Environment.NewLine + key + "=" + value;
                    readyToWrite = true;
                }
                else
                {
                    File.AppendAllText(path, Environment.NewLine + "[" + section + "]" + Environment.NewLine + key + "=" + value + Environment.NewLine);
                }
            }
            if (readyToWrite)
            {
                FuncMisc.writeToFile(path, cacheFile);
            }
            cacheFile = null;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static int intRead(string path, string section, string key)
        {
            int value = -1;
            string line = stringRead(path, section, key);
            if (!string.IsNullOrEmpty(line))
            {
                value = stringToInt(line);
            }
            return value;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static double doubleRead(string path, string section, string key)
        {
            double value = -1.0;
            string line = stringRead(path, section, key);
            if (!string.IsNullOrEmpty(line))
            {
                value = stringToDouble(line);
            }
            return value;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static int stringToInt(string input)
        {
            int value = -1;
            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains("."))
                {
                    Int32.TryParse(input.Remove(input.IndexOf('.')), out value);
                }
                else if (input.Contains(","))
                {
                    Int32.TryParse(input.Remove(input.IndexOf(',')), out value);
                }
                else
                {
                    Int32.TryParse(input, out value);
                }
            }
            return value;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static double stringToDouble(string input)
        {
            double value = -1;
            if (!string.IsNullOrEmpty(input))
            {
                Double.TryParse(input.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out value);
            }
            return value;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static string convertFileSize(double input)
        {
            string[] units = new string[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (input >= mod)
            {
                input /= mod;
                i++;
            }
            return Math.Round(input, 2) + units[i];
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static List<string> parserESPESM(string file)
        {
            List<string> outString = new List<string>();
            if (File.Exists(file) && new FileInfo(file).Length > 50)
            {
                byte[] bytesFile = new byte[1000];
                FileStream fs = File.OpenRead(file);
                List<string> list = new List<string>();
                string line = null;
                fs.Read(bytesFile, 0, 1000);
                fs.Close();
                for (int i = 0; i < bytesFile.Count(); i++)
                {
                    if (bytesFile[i] >= 32 && bytesFile[i] <= 126)
                    {
                        line += Convert.ToChar(bytesFile[i]);
                        if (line == "GRUP" || line == "ONAM")
                        {
                            break;
                        }
                    }
                    else if (!string.IsNullOrEmpty(line))
                    {
                        list.Add(line);
                        line = null;
                    }
                }
                bytesFile = null;
                if (list[0].Contains("TES4"))
                {
                    for (int i = 0; i < list.Count(); i++)
                    {
                        if (list[i].Contains("MAST"))
                        {
                            if ((i + 1) < list.Count())
                            {
                                outString.Add(list[i + 1]);
                            }
                        }
                    }
                }
                list = null;
            }
            return outString;
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static bool checkESM(string file)
        {
            if (File.Exists(file) && new FileInfo(file).Length > 50)
            {
                FileStream fs = File.OpenRead(file);
                fs.Seek(8, SeekOrigin.Begin);
                int read = fs.ReadByte();
                fs.Close();
                if (read == 1 || read == 129)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //////////////////////////////////////////////////////ГРАНИЦА ФУНКЦИИ//////////////////////////////////////////////////////////////
        public static string loadOrderID(int number)
        {
            if (number < 256)
            {
                return BitConverter.ToString(BitConverter.GetBytes(number), 0, 1);
            }
            else
            {
                return null;
            }
        }
    }
}