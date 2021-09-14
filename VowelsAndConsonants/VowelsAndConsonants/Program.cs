using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada tähte
            //Programm kontrollib, kas sisestatid täht on
            //Täishäälik või kaashäälik
            //Kui sisestatud täht on täishäälik - programm kuvab 
            //"täishäälik"
            //Kui sisestatud täht on kaashäälik
            //Programm kuvab "kaashäälik"
            //Kasutame switch´i

            Console.WriteLine("Sisesta täht");
            char userchar = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userchar)
            {
                case 'a': Console.WriteLine("Täishäälik"); break;
                case 'e': Console.WriteLine("Täishäälik"); break;
                case 'i': Console.WriteLine("Täishäälik"); break;
                case 'o': Console.WriteLine("Täishäälik"); break;
                case 'u': Console.WriteLine("Täishäälik"); break;
                case 'ü': Console.WriteLine("Täishäälik"); break;
                case 'õ': Console.WriteLine("Täishäälik"); break;
                case 'ö': Console.WriteLine("Täishäälik"); break;
                case 'ä': Console.WriteLine("Täishäälik"); break;

                default: Console.WriteLine("Kaashäälik"); break;
            }




        }
    }
}
