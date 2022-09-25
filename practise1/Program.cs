using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    //Que1
    class Parent
    {
        public string Family_name="fname";
    }
    class Child : Parent
    {
        public string Name;
        public string Occupation;
        public int Age;
        public void childDetails(string n,string o,int a)
        {
            Name=n;
            Occupation=o;
            Age=a;
        }
        public void display()
        {
            Console.WriteLine("Name : " + Name + " Occupation : " + Occupation + " Age : " + Age +" Family name : "+Family_name);
        }
    }
    //Que2
    class Company
    {
        public string cname="ABC";
        public string type="small";
    }
    class Employee:Company
    {
        public string Ename;
        public int Salary;
        public void EnterDetails()
        {
            Console.WriteLine("Enter employee name");
            Ename=Console.ReadLine();
            Console.WriteLine("Enter salary");
            Salary=Convert.ToInt32( Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name : "+Ename+"Salary: "+Salary+"company name:"+cname);
        }
    }
    class Department : Company
    {
        public string dname;
        public void EnterDetails()
        { 
            dname="dotnet";
        }
        public void Display()
        {
            Console.WriteLine("Department: "+dname+" company name: "+cname);
        }
    }
    //Que3
    class School
    {
        public string sname="HSS";
        public int Month_Fee;

    }
    class Student : School
    {
        public string StName="anu";
        public string Class;
        public int age;
    }
    class Sports:Student
    {
        public string item1= "LONG JUMP";
        public string item2="relay";
        public string item3="shotput";
        public string item4 =  "High jump";
        public void disp()
        {
            
            if (age < 12)
            {
                
                item2 = "";
                item3 = "";
                Console.WriteLine(StName+" can participate in " +item1 +item2+item3+item4);
            }
            else
            {
                Console.WriteLine("can participate in 4 items"+item1+item2+item3+item4);
            }
        }
       
    }
    //Que4
    class Mobile
    {
        public string Name;
        public string Company;
        public int Wprice;
        public void Accept()
        {
            Name = "j2";
            Company = "samsung";
            Wprice = 30000;
        }
    }
    class Indian_Mob:Mobile
    {
        public string Local_made;
        public string Discount;
        public double Rprice;
        public Indian_Mob(string local,double price)
        {
            Local_made= local;
            if(local=="kerala" && price > 10000)
            {
                Discount = "20%";
                Rprice= price-(price*0.2);
            }
            else
            {
                Discount = "0 %";
                Rprice = price;
            }
        }
        public void disp()
        {
            Console.WriteLine("MOBILE DETAILS ");
            Console.WriteLine("local made: " + Local_made);
            Console.WriteLine("Discount: " + Discount);
            Console.WriteLine("Retail price: " + Rprice);
        }
    }
    //Que5
    class Book
    {
        public int Pages;
        public string Publisher;
        public void Set(int P,string Pub)
        {
            Pages = P;
            Publisher = Pub;
        }
    }
    class NoteBook:Book
    {
        public int price;
        public string color="white";
        public void Calculate()
        {
            price = Pages * 2;
        }
        public void BookDetails()
        {
            Console.WriteLine("price :"+price +"publisher : "+Publisher);
        }
    }
      
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.childDetails("anu", "engineer", 22);
            child.display();
            Employee employee = new Employee();
            Department department = new Department();
            employee.EnterDetails();
            department.EnterDetails();
            employee.display();
            department.Display();
            Sports sport = new Sports();
            sport.Month_Fee = 300;
            sport.Class = "7";
            sport.age = 11;
            sport.disp();
            Mobile m = new Mobile();
            m.Accept();
            Indian_Mob i = new Indian_Mob("kerala", 30000);
            i.disp();
            Book book = new Book();
            NoteBook nb = new NoteBook();
            nb.Set(50, "grace");
            nb.Calculate();
            nb.BookDetails();
            Console.ReadKey();
        }
    }
}
