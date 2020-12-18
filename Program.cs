using System;
using System.Data;
using System.Collections.Generic;
//using System.Collections.Generic.List;
using System.Linq;
using System.Text;
//using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

//using System.Windows.Forms;
namespace VSC_Folder
{
    // static and constructors
    class Circle
    {
    static float _Pi;
    int _Radius;

        static Circle()
        {
            Console.WriteLine ("Static Constructor called");
            Circle._Pi = 3.141F;
        }

        public Circle(int Radius)
        {
            Console.WriteLine ("Instance Constructor called");
            this._Radius= Radius;
        }

        public float CalculateArea()
        {
            return Circle._Pi * this._Radius * this._Radius;
        }

    }

    public class Enums
    {

        class Program
        {
            [STAThread]
            public static void Main(string[] args)
            {

                Circle C1 = new Circle(5);
                float Area1= C1.CalculateArea();
                Console.WriteLine("Area {0}=", Area1);

                Circle C2 = new Circle(2);
                float Area2= C2.CalculateArea();
                Console.WriteLine("Area {0}=", Area2);


                // simple add and divide  
                int sum= 0;
                for(int i=0; i<=20; i++)
                {
                    if(i % 3 == 0)
                    {
                        sum= sum+i;
                    }

                }

            Console.WriteLine($"The sum is {sum}"); 
 
            // generic collection strList
            List<string> strList = new List<string>();
            strList.Add("Test");
            strList.Add("NetCore");

            foreach (var str in strList)
            {
                Console.WriteLine(str);
            }


            //List, generic collection and array   
        
            var names = new List<string> {"abc", "pqr", "xyz"};
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i=0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            names.Add("Dot");
            names.Remove("abc");

            foreach (string name in names)
            {
            Console.WriteLine(name);
            }

            Console.WriteLine($"Array {names[2]}");

            //inheritance
            ParentClass pc = new ParentClass();
            ChildClass cc= new ChildClass();
            // AbstractClass ac=  new AbstractClass();

        /*  pc.sayHello();
            cc.sayHello(); */

            // Abstract Class
            cc.sayAbstract();

            //Console.ReadLine();
            

             // Abstract Class, inheritance, virtual

            FullTimeEmployee fte= new FullTimeEmployee()
            {
                ID= 101,
                FirstName= "Pooja",
                LastName= "Raut",
                AnnualSalary= 5000 
            };

            Console.WriteLine("Full Time Employees");
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("------------------");



            ContractEmployee cte= new ContractEmployee()
            {
                ID= 102,
                FirstName= "Gauri",
                LastName= "Patil",
                HourlyPay= 50,
                TotalHours=9
            };

            Console.WriteLine("Contract Employees");
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.WriteLine("------------------");

            // async, task and await
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();


                //static
            async void Method()
            {
                await Task.Run(new Action(LongTask));
                Console.WriteLine("New Thread");
            }

                //static
            void LongTask()
            {
                Thread.Sleep(20000);
            }

        //IEnumerable

            List<int> Numbers = new List<int> {1,2,3,4,5,6,7,8,9};
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, num=> num %2==0);
            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

        //IEnumerable 1

            List<int> list = new List<int> {1,2,3,4,5,6,7,8,9,10};

            List<Employee> employees = new List<Employee> ()
            {
                new Employee() {ID= 1, Name= "Tom"},
                new Employee() {ID= 2, Name= "Jerry"}
            };
           
           // Func and delegate
           Func<Employee, string> selector = employee => "Name by delegate=" + employee.Name;
           IEnumerable<string> n = employees.Select(selector);
            
            foreach (string name in n)
            {
                Console.WriteLine(name);  
            }

            Func <int, int, string> funcDel =(firstNumber, secondNumber) => "Sum by delegate=" + (firstNumber+secondNumber).ToString();

            string res = funcDel(2,3);
            Console.WriteLine(res);

            //IEnum
            IEnumerable<Employee> query = from emp in employees
                                        where emp.ID == 1
                                        select emp;


        //IQueryable
            IQueryable<Employee> query1 = employees.AsQueryable().Where(x=> x.ID == 1);
                                        

            foreach (var item in query)
            {
                Console.WriteLine("Id ="+  item.ID + " And Name =" + item.Name);
            }

            Console.ReadLine();
            //IEnumerable 1 end

            //Enum 

            Customer[] customers =  new Customer[3];
            customers[0] = new Customer
            {
                Name="Mark",
                Gender= Gender.Male
            };

            customers[1] = new Customer
            {
                Name="Mary",
                Gender= Gender.Female
            };
            customers[2] = new Customer
            {
                Name="Sam",
                Gender= Gender.Unknown
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name={0} && Gender={1}", customer.Name, GetGender(customer.Gender));
            }

         //static
            string GetGender(Gender gender)
            {

                switch (gender)
                {
                    case Gender.Unknown: return "Unknown";
                    case Gender.Male: return "Male";
                    case Gender.Female: return "Female";
                    default: return "Invalid Data";
                }
            }
        //Enum End


                AddNumbers(10, 20, new int[] {30,40,10});
                BaseClass b = new DerivedClass();
                b.Print();


         //Injections
                BusinessClient objBusinessClient = new BusinessClient(new StudentService());

                Console.ReadKey();



        //database connection
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Demo_Project.DbForm());


            }

        public static void AddNumbers(int firstNum, int secondNum)
        {
            AddNumbers (firstNum, secondNum, null);
        }

            public static void AddNumbers(int firstNum, int secondNum, int[] restOfNumbers)
            {
                int result = firstNum + secondNum;
                if (restOfNumbers != null)
                {
                    foreach (int i in restOfNumbers)
                    {
                        result += i;
                    }
                }

                Console.WriteLine("Sum by overloading = " + result);
            }

    }

}


    


 //Enum End
    public enum Gender
    {
        Unknown,
        Male,
        Female

    }

    public class Customer
    {
        public string Name {get;set;}
        public Gender Gender {get;set;}
    }

//Enum End

  //IEnumerable 1

    class Employee
    {
        public int ID {get; set;}
        public string Name {get;set;}

    }
  //IEnumerable 1 end

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        //public new void Print() for hide
        {
            Console.WriteLine("Child Class Print Method");
        }
    }


    //Client Class
    public class BusinessClient
    {
        private IService iService;
        public BusinessClient(IService _iservice)
        {
            this.iService = _iservice;
            this.iService.getFirstName();
            this.iService.getLastName();
        }

    }


    //Injections

    public interface IService
    {
        void getFirstName();
        void getLastName();
    }

    //Service Class

    public class StudentService : IService
    {
        public void getFirstName()
        {
            Console.WriteLine("Student First Name");
        }

        public void getLastName()
        {
            Console.WriteLine("Student Last Name");
        }
    }

    //Service Class


    public class TeacherService : IService
    {
        public void getFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }

        public void getLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }


}
