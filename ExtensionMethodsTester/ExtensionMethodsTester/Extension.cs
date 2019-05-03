using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTester
{
    public static class Extension
    {
        public static int ToInt(this String val)
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static int ToInt1(String val)
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static string Left(this String val, int digits)
        {
            return val.Substring(0, digits);
        }
        //public static void Log(this string text)
        // {
        // try
        //{
        //  string directory = "D://Loggs";

        //File.AppendAllText(Path.Combine(directory, "Log.txt"),
        //$"{ Environment.NewLine} Data: { DateTime.Now.ToShortDateString()} ConsoleKeyInfo: {text}");
        //}
        //catch (DirectoryNotFoundException dnfe)
        //{

        //LogError(dnfe.Message);
        //}
        //catch (Exception)
        //{

        //}
        //}
        public static int ToInt<T>(this T val) where T:struct 
        {
            try
            {
                Type type = typeof(T);
                if (type == typeof(string))
                {
                    return -100;//dla testu
                }
                if (val is double)
                {
                    int x = int.Parse(val.ToString());
                    return Convert.ToInt32(x + 1);
                }

                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }

        }

    }
}
