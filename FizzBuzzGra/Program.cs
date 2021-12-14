using System;

namespace FizzBuzzGra
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var result = new FizzBuzz();
            while(true)
            {
                Console.WriteLine("Podaj liczbe całkowitą");
                var number = GetNumber();
                Console.WriteLine(result.GetFizzOrBuzz(number));
                Console.WriteLine("Jezeli chcesz skończyc wybierze t");
                
            }
            

            Console.ReadLine();
        }

        private static int GetNumber()
        {
            while(true)
            {
                var value = Console.ReadLine();
                if(value.ToUpper()=="T" )
                {
                    Environment.Exit(0);
                }
                if(!int.TryParse(value, out int number))
                {
                    Console.WriteLine("Podany ciąg znaków nie jest liczba całkowitą. Podaj prosze liczbę");
                    continue;
                }
                return number;
            }
        }
    }
}
