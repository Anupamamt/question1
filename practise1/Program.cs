using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
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
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.childDetails("anu", "engineer", 22);
            child.display();
            Console.ReadKey();
        }
    }
}
