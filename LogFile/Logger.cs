using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFile
{
    internal class Logger
    {
        private static StreamWriter sw;
        private static readonly string path = @"C:\Users\robso\Desktop\Log\Log.txt";
        private static void CreateLogFile()
        {
            try
            {
                using (sw = File.CreateText(path))
                {
                    sw.WriteLine("DataHora;Mensagem;");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Log(string mensagem)
        {
            try
            {
                if (!File.Exists(path))
                    CreateLogFile();

                using (sw = File.AppendText(path))
                {
                    sw.WriteLine($"{DateTime.Now};{mensagem};");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
