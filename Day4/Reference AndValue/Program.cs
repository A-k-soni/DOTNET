using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.I = 100;
            o2.I = 200;
            o1 = o2;
            o2.I = 300;
            Console.WriteLine(o1.I);
            Console.WriteLine(o2.I);

            Console.ReadLine();

        }
    }

    public class Class1
    {
        private int i;

        public int I
        {
            get
            {
                return i; 
            }
            set
            {
                i = value;
            }
        }

    }
}
