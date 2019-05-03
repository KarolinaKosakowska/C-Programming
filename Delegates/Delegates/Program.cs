using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> cw = System.Console.WriteLine;
            Action<int, int> x = Sum;
            Func<int> cr = System.Console.Read;
            //cw += WriteNumber;//- wyswietli obydwa cw

            cw("1");
            cw += delegate (string r) { Console.WriteLine(r + r); };//- metoda anonimowa
            x += (a, b) => Console.WriteLine(a - b);
            x += (a, b) =>
            {
                if (a > 1 && b != 0)
                {
                    Console.WriteLine(a % b);
                }
                if ( a % b ==0)
                {
                    Console.WriteLine("Liczba parzysta");
                }
            };
            cw += r => Console.WriteLine(r);//- wyrażenie lambda
            cr = () => Console.Read();

            cw("2");
            cw -= Console.WriteLine;
            cw("3");
            Console.WriteLine();
            x(3, 2);
            cr();

            //List<Roman> romany = new List<Roman>(); - metoda anonimowa, bez tworzenia konkretnego obiektu
            //romany.Add(new Roman
            //{
            //    Name = "Roman Nowak"
            //});
             void Sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }
        }
        class Roman

        {

            public string Name { get; set; }
        }
        //static void WriteNumber(string strNumber)
        //{
        //    Console.WriteLine($"Podany string jest liczbą:{strNumber}");
        //}
    }
}
