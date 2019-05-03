using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowType<string> str = new ShowType<string>();// string jest typem referencyjnym wiec ok
            // ShowType<int> intObject = new ShowType<int>(); 
            // str.Show();
            //intObject.Show();


            //int a = 1;
           // int b = 2;
           // var genericMethods = new GenericMethods();
            //int c = genericMethods.GetSum<int>(a, b);
            //int c = genericMethods.GetSum(a, b); - int nie jest akurat tu wymagane
           // Console.WriteLine(c);
           // Console.Read();

            string a = "1";
            string b = "2";
            var genericMethods = new GenericMethods();
            string c = genericMethods.GetSum<string>(a, b);
            Console.WriteLine(c);
            Console.Read();


        }
    }
}
