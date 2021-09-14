using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutajal sisestada, PIN-koodi
            //Programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-koodi on 1234
            //Programm kuvab konsoois "Tere tulemast"!
            //kui sisustaud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovin uuesti"

            Console.WriteLine("Sisestage PIN kood!");
            int userPIN = Convert.ToInt32(Console.ReadLine());


            if (userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti");
            }











        }
    }
}
