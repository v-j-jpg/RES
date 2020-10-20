using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES.Logger
{
   public class Logger
    {
        public static string path = @"C:\Users\Lenovo\Desktop\log.txt";

        //public static FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
        //public static StreamReader sr = new StreamReader(stream);
        //public static StreamWriter sw = new StreamWriter(stream);

        public Logger()
        {
            File.AppendAllText(path, "Logger is started...");
            //sw.WriteLine($"{DateTime.Now}Logger started...");
        }

        public static void LoggToFile(Common.Component component, DateTime timestamp, String message)
        {
          string k = string.Format("[{0}]-{1}:[{2}] \n", timestamp, component.ToString() , message);

            File.AppendAllText(path, k);

           // sw.WriteLine(k);
        }


    }
}
