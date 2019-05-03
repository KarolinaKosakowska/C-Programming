using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    public class TxtTepo: RepoDisposable
    {
        public string GetTextFromFile(string path)
        {
            string text = File.ReadAllText(path); //File z System.IO
            return text;
        }
    }
}
