using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersClasses
{

    public class Names
    {
        private string[] names;
        public int Count => names.Length;
      
        public Names(int numberOfValues)
        {
            names = new string[numberOfValues];
        }
        public string this[int i]
        {
            get
            {
                if (i < 0)
                    throw new IndexOutOfRangeException("Index musi być większy lub równy zero");
                return names[i];
            }

            set
            {
                if (i < 0)
                    throw new IndexOutOfRangeException("Index musi być większy lub równy zero");
                names[i] = value;
            }
        }
    }

}
