using System;

namespace InstagramAgeProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis aastal sa sündisid?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            Console.WriteLine("Sa oled " + Age);

            if (Age > 13)

            {
                Console.WriteLine("Oled piisavalt vana, võid liituda instagrammiga");

            }
            else if (Age < 13)
            {
                Console.WriteLine("Oled liiga noor et liituda instagrammiga");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, võid liituda instagrammiga");
            }
            
        }
    }
}
