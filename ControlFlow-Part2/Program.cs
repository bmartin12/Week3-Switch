using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis "tere tulemast!"
            // kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN." Proovi uuesti"


            Console.WriteLine("What's the passcode?");
            int pass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Checking..");
            System.Threading.Thread.Sleep(1000);
            if (pass != 1111)
            {
                Console.WriteLine("Welcome back, sir.");
            }
            else
            {
                Console.WriteLine("Wrong passcode.");
            }
            




        }
    }
}
