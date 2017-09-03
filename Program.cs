using System;

namespace prog2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Program will display a number");

           var Number = 0;

           Console.WriteLine("Please enter number");
           var isNumber = int.TryParse(Console.ReadLine(), out Number);

           if (isNumber)
           {
                Console.WriteLine($"Number is{Number}" );

           }
           else
           {
               Console.WriteLine("Plesae right a number");
           
           }Console.ReadLine();;
             /*   var number = 0;
            var count = 10;

            for(var i =0; i < count; i++)
            {
                Console.WriteLine("Please enter number");
                var isNumber = int.TryParse(Console.ReadLine(), out int input);
                
                number += input;
            }Console.WriteLine($"The total {number}");
           Console.WriteLine($"The average = {(double) number / count}");
           */
         Console.WriteLine("This will add numbers");

         var number = 0;
         var awswer = 0;
         bool keepgoing = true;
         do
         {
              Console.WriteLine("Please enter number");
                var isNumber = int.TryParse(Console.ReadLine(), out int input);
                
                number += input;
          
         }
         while (number == 0);
         Console.WriteLine($"The total {number}");
           Console.WriteLine($"The average = {(double) number}");
        }
    }
}
