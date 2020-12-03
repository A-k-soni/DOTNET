using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignDay4
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Manager("A", 10, 2000, "tech manager");
            Employee e2 = new GeneralManager("B", 20, 5000, "HR manager", "xyz");
            Employee e3 = new CEO("C", 30, 10000);
            Console.WriteLine(e3.CalacNetSalary());//50000
            e3.Add();
            e3.Select();
            e3.Remove();
            e3.Update();
            Console.WriteLine(e2.CalacNetSalary());//15000
            e2.Add();
            e2.Select();
            e2.Remove();
            e2.Update();
            Console.WriteLine(e1.CalacNetSalary());//4000
            e1.Add();
            e1.Select();
            e1.Remove();
            e1.Update();


            Console.ReadLine();

        }
    }

    public interface IDbFunctions
    {
        void Select();

        void Add();

        void Remove();

        void Update();
    }

    public abstract class Employee : IDbFunctions
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private static int lastEmpNo = 0;

        private int empNo;

        public int Empno
        {
            get { return empNo; }
            private set
            {
                empNo = value;
            }
        }

        private short deptNo;

        public short DeptNo
        {
            get
            {
                return deptNo;
            }

            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("department number should be greater than 0");
                }
            }
        }

        public Employee(string name = "noname", short deptNo = 1, decimal basic = 0)
        {
            empNo = ++lastEmpNo;
            this.name = name;
            this.deptNo = deptNo;
            this.basic = basic;
        }


        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }

        public abstract decimal CalacNetSalary();

        public virtual void Select()
        {
            Console.WriteLine("Employee : Select");
        }

        public virtual void Add()
        {
            Console.WriteLine("Employee : Add");
        }

        public virtual void Remove()
        {
            Console.WriteLine("Employee : Remove");
        }

        public virtual void Update()
        {
            Console.WriteLine("Employee : Update");
        }
    }

    public class Manager : Employee,IDbFunctions
    {
        private string designation;
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }

        //private decimal basic;
        public override decimal Basic
        {
            get
            {

                return basic;
            }
            set
            {

                basic = value;
            }
        }

        public Manager(string name, short deptNo, decimal basic, string designation = "manager") : base(name, deptNo, basic)
        {

            //this.basic = basic;
            this.designation = designation;

        }



        public override decimal CalacNetSalary()
        {

            return Basic * 2;
        }

        public override void Select()
        {
            Console.WriteLine("Manager : Select");
        }

        public override void Add()
        {
            Console.WriteLine("Manager : Add");
        }

        public override void Remove()
        {
            Console.WriteLine("Manager : Remove");
        }

        public override void Update()
        {
            Console.WriteLine("Manager : Update");
        }

    }

    public class GeneralManager : Manager,IDbFunctions
    {
        private string perks;

        public string Perks
        {
            get
            {
                return perks;
            }
            set
            {
                perks = value;
            }
        }
        //private decimal basic;

        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public GeneralManager(string name, short deptNo, decimal basic, string designation, string perks) : base(name, deptNo, basic, designation)
        {
            //this.basic = basic;
            this.perks = perks;
        }

        public sealed override decimal CalacNetSalary()
        {
            return Basic * 3;
        }

        public sealed override void Select()
        {
            Console.WriteLine("GeneralManager : Select");
        }

        public sealed override void Add()
        {
            Console.WriteLine("GeneralManager : Add");
        }

        public sealed override void Remove()
        {
            Console.WriteLine("GeneralManager : Remove");
        }

        public sealed override void Update()
        {
            Console.WriteLine("GeneralManager : Update");
        }

    }

    public class CEO : Employee,IDbFunctions
    {

        //private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public override sealed decimal CalacNetSalary()
        {
            return Basic * 5;
        }

        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo, basic)
        {
            //this.basic = basic;
        }

        public sealed override void Select()
        {
            Console.WriteLine("CEO : Select");
        }

        public sealed override void Add()
        {
            Console.WriteLine("CEO : Add");
        }

        public sealed override void Remove()
        {
            Console.WriteLine("CEO : Remove");
        }

        public sealed override void Update()
        {
            Console.WriteLine("CEO : Update");
        }

    }

}
