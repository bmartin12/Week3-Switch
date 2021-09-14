using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta täht.");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            switch (character)
            {
                case 'a':Console.WriteLine("Täishäälik");break;
                case 'e':Console.WriteLine("Täishäälik");break;
                case 'i':Console.WriteLine("Täishäälik");break;
                case 'o':Console.WriteLine("Täishäälik");break;
                case 'u':Console.WriteLine("Täishäälik");break;
                default:Console.WriteLine("Kaashäälik");break;
               



            }
            
        }
    }
}
