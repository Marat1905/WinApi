using System;
using System.Diagnostics;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var notepade = Process.Start("notepad");


            Console.WriteLine("Завершено");
            Console.ReadLine();

            notepade.CloseMainWindow();
            
        }
    }
}
