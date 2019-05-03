using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    class Program
    {
        static void Main(string[] args)
        {

          TxtTepo repo = new TxtTepo();
            try
            { 
                Console.WriteLine(repo.GetTextFromFile("Files/TextFile.txt")); //pobieramy text z pliku, text.file->properties-> copy if newer
            }
            catch (Exception ex)
            {
                //log()
            }
            finally // wykonuje sie zawsze,nawet jesli wystapi wyjątek 
            {
                repo.Dispose();  
            }
            using (TxtTepo repo2 = new TxtTepo())
            {
                Console.WriteLine("In using");
                Console.WriteLine(repo.GetTextFromFile("Files/TextFile.txt"));//- uzyty zaiennie z try/finally, automatycznie niszczy resource (repo)
            }
            Console.Read();
        }
    }
}
