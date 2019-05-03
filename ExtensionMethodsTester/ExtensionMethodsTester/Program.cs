using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //string number = "3";
            //int n = Extension.ToInt1(number);
            //int n2 = number.ToInt(); // używa TEGO stringa bez koniecznosci podawania "number", wywołujemy metodę na podstawie zmiennej number.metoda

            double d = 43.4d;
            int dd = d.ToInt();
            Console.WriteLine(dd);


            //Console.WriteLine(n2);
            //string text = "Maria lubi koty,wednwn dndk w.";
            //string left = text.Left(5);
            //Console.WriteLine(left);
            //text.Log();
            //try
            //{
            //    throw new Exception("Nie używaj tej aplikacji");
            //}
            //catch (Exception exe)
            //{
            //    exe.Message.Log();
                
            //}
            Console.Read();
        }
    }
}
