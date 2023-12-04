using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Figura
    {
        public string name;
        public int st1;
        public int st2;
        public int st3;
        public int st4;
        public Figura() { }
        public Figura(string name, int st1, int st2, int st3, int st4)
        {
            this.name = name;
            this.st1 = st1;
            this.st2 = st2;
            this.st3 = st3;
            this.st4 = st4;
        }
        public void ShowArea()
        {
            Console.WriteLine($"Фигура:{name}\n:{st1}\n:{st2}\n:{st3}\n:{st4}\n:{st1*st2}");
        }
    }
}
