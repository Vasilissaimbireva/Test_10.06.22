using System;
using System.Diagnostics; //пространство имен для Process

namespace Break_me_completely
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FailProcess();
            }
            catch
            {

            }
            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }
        static void FailProcess()
        {

            // Environment.Exit(0); //вариант 1

            // System.Environment.FailFast("END"); //вариант 2

            // Process.GetCurrentProcess().Kill(); //вариант 3
           
        }
    }
}
