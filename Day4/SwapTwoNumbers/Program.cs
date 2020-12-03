using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i=0;
            //int j=0;
            int i=10;
            int j=20;
            //Init(ref i, ref j);
            Console.WriteLine("i --- " + i);
            Console.WriteLine("j --- " + j);
            Init(out i, out j);

            Console.WriteLine("i --- "+i);
            Console.WriteLine("j --- "+j);
            Swap(ref i, ref j);
            Console.WriteLine("After swaping-->");
            Console.WriteLine("i---"+i);
            Console.WriteLine("j---"+j);


            Console.ReadLine();
        }

        static void Init(out int i ,out int j )
        {
            i = 1000;
            j = 2000;
        }

        static void Swap(ref int i ,ref int j )
        {
            int temp = i;
            i = j;
            j = temp;

        }
    }
}
