using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();

            o.Display();
            o.Dispose();
            //o.Display();
            Console.ReadLine();


        }
    }

    public class Class1 : IDisposable
    {
        public void Display()
        {
            CheckForDispose();
            Console.WriteLine("Display Method");
        }

        public void CheckForDispose()
        {
            if (isDispose)
            {
                throw new ObjectDisposedException("Class1");
            }
        }
        private bool isDispose = false;

        public void Dispose()
        {
            Console.WriteLine("Dispose Call ... ");
            isDispose = true;
        }
    }

}
