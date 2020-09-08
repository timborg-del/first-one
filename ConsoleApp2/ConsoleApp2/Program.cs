using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            CompereNumbers();
        }



        static void CompereNumbers()
        {
            int numberOne;
            int numberTwo;
            
            Console.WriteLine("Please enter number: ");
            numberOne = TextToNumber(Console.ReadLine());
            
            Console.WriteLine("Please enter number: ");
            numberTwo = TestToNumber(Console.ReadLine());

            if (numberOne > numberTwo)

        }
        static int TextToNumber(string textNumber)
        {
            int number = 0;
            int.TryParse(textNumber, out number);
            
            return number;
        }

    }
}