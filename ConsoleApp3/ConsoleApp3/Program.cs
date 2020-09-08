using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Tim!");

            CompereNumbers();
        }


        static void CompereNumbers()
        {
            int numberOne;
            int numberTwo;

            /*
             * Sätt in While loop för att man inte kan slå in samma tal. så då får man börja om !
             */ 
             
            Console.WriteLine("Snalla skriv in ditt nummer: ");
            numberOne = TextToNumber(Console.ReadLine());

            Console.WriteLine("Snalla skriv in ditt andra nummer: ");
            numberTwo = TextToNumber(Console.ReadLine());

            if (numberOne == numberTwo)
            {

                Console.WriteLine("Dom är lika börja om");
            }
            else if (numberOne > numberTwo)
            {
                Console.WriteLine("Första numret är det största");
            }
            else
            {
                Console.WriteLine("Andra numret är större");
            }
        }
        static int TextToNumber(string textNumber)
        {
            int number = 25;
            int.TryParse(textNumber, out number);

            return number;



        }
    }


}

