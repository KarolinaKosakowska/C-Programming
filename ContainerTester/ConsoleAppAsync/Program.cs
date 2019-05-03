using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Task.Run(async () => await SaveFileAsync(text));
            Console.Read();
        }
        async static Task SaveFileAsync(string number)
        {
            await Task.Run(() => SaveSync(int.Parse(number)));
        }

        private static void SaveSync(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Thread.Sleep(2000);
                File.Create($"D:\\{i}.txt");
            }            
        }
    }
}
