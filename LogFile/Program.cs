using System;

namespace LogFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                for(int i = 0; i < 10; i++)
                {
                    Logger.Log($"Arquivo{i}");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}
