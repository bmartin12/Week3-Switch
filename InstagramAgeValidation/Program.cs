using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To be able to create an account, you need to be over the age of 13.");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("In what year were you born?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            Console.WriteLine("Checking..");
            System.Threading.Thread.Sleep(1000);

            if (Age >= 13)
            {
                Console.WriteLine("You may proceed.");
            }
            else
            {
                Console.WriteLine("You are not old enough");
            }



        }
    }
}
