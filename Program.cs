using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int password;
            bool path;
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Convert.ToInt32(Console.ReadLine());
            if (userName == "Admin" && password == 123456789)
            {
                Console.WriteLine("Welcome");
                path = true;
            }
            else
            {
                Console.WriteLine("Wrong username or password");
                path = false;
            }
            int midtermExam, final, average;
            if (path == true)
            {
                Console.WriteLine("Welcome to the average calculation system");
                Console.WriteLine("Enter your visa note");
                midtermExam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your final note");
                final = Convert.ToInt32(Console.ReadLine());
                average = ((midtermExam * 40) / 100) + ((final * 60) / 100);
                if (average >= 50)
                {
                    Console.WriteLine("You passed");
                    Console.WriteLine("Average: " + average);
                }
                else
                {
                    Console.WriteLine("You stayed");
                    Console.WriteLine("Average: " + average);
                }
            }
            else
            {
                Console.WriteLine("There is something wrong");
            }
            if (path == false)
            {
                Console.WriteLine("Back to top");
            }
        }
    }
}
