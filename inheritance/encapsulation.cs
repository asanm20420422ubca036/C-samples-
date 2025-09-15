using System;
namespace project
{

           public class User
        {
           
        private string email;
        private string name;
            public void SetEmail(string value)
            {
                if (value.Contains("@")) email = value;
                else Console.WriteLine("Invalid email format.");
             
        }
        
            public string GetEmail() => email;
        static void Main(string[] args)
        {
            User u = new User();
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your mailid");
            u.SetEmail(Console.ReadLine());
            Console.WriteLine("Your Email is : " + u.GetEmail());
            Console.WriteLine("Your Name is : " + u.name);
            
        }
    }
    }

