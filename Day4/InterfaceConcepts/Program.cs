using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Delete();
            o.Update();
            o.Display();

            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Delete();
            oIDb.Update();
            oIDb.Insert();

            Class2 o2 = new Class2();

            InsertMethod(o2);

            InsertMethod(o);

            Console.WriteLine("------------------");

            IfileFunctions oIfile = o;
            oIfile.Open();
            oIfile.Close();
            oIfile.Delete();

            Console.ReadLine();
        }

        static void InsertMethod(IDbFunctions oIdb)
        {
            oIdb.Insert();
        }

    }
    public interface IDbFunctions
    {
        void Insert();

        void Update();

        void Delete();
    }

    public interface IDbFunctionChild : IDbFunctions
    {
       
    }

    public interface IfileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }

    public class Class1 : IDbFunctions , IfileFunctions
    {
        public void Delete()
        {
            Console.WriteLine("IDb : delete");
        }

        public void Insert()
        {
            Console.WriteLine("IDb : Insert");
        }

        public void Update()
        {
            Console.WriteLine("IDb : Update");
        }

        public void Display()
        {
            Console.WriteLine("Display method call");
        }

        void IfileFunctions.Open()
        {
            Console.WriteLine("Iff c1 : Open ");
        }

        void IfileFunctions.Close()
        {
            Console.WriteLine("Iff c1 : Close");
        }

        void IfileFunctions.Delete()
        {
            Console.WriteLine("Iff c1 : Delete ");
        }
    }

    public class Class2 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("IDb c2 : delete");
        }

        public void Insert()
        {
            Console.WriteLine("IDb c2 : Insert");
        }

        public void Update()
        {
            Console.WriteLine("IDb c2 : Update");
        }

        public void Display()
        {
            Console.WriteLine("Display c2 method call");
        }
    }



}
