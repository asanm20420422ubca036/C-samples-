using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Student
    {
        
        public int age;

        public String Name;
        public int a = 10;
        public int b = 20;
        public string grade;
        
        public void details()
        {
            Console.WriteLine("Enter your name : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Hello users welcome to our site ");
        }
        public Student(string grade)//constructor 
        {
            a = 10;
            b = 20;
            this.grade = grade;
        }
        
        static void Main(string[] args)
        {
            Student objstd = new Student("Hey you are \"A+\" ");
            objstd.details();
            objstd.age = 20;
            Console.WriteLine(objstd.grade);
            Console.WriteLine("The sum of two no is : " +(objstd.a+objstd.b));
            Console.WriteLine("hello " +objstd.Name +" Welcome to our site");
            Console.WriteLine("Hello mam your name is " + objstd.Name + " and you are " + objstd.age + " years old");
        }
    }
}
