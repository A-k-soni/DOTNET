using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndVal
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 o = new Class1();
            o.i = 500;
            
            DoSomething1(o);

            Console.WriteLine(o.i);

            o.i = 500;

            DoSomething2(o);

            Console.WriteLine(o.i);

            o.i = 500;

            DoSomething3(ref o);

            Console.WriteLine(o.i);

            Console.ReadLine();

        }

        static void DoSomething1(Class1 o )
        {
          
            o.i = 100;
        }

        static void DoSomething2(Class1 o)
        {
            o = new Class1();
            o.i = 100;
        }

        static void DoSomething3(ref Class1 o)
        {
            o = new Class1();
            o.i = 100;
        }


    }

    public class Class1
    {
       public int i; 
    }

    

   
}
