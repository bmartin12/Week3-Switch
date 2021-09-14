using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int grade = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(700);
            switch(grade)
            {
                case 1:
                    Console.WriteLine("Puudulik");
                    break;
                case 2:
                    Console.WriteLine("Rahuldav");
                    break;
                case 3:
                    Console.WriteLine("Hea");
                    break;
                case 4:
                    Console.WriteLine("Väga hea");
                    break;
                case 5:
                    Console.WriteLine("Suurepärane!");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }
            
        }
    }
}
