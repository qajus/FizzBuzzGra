using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGra
{
    public class FizzBuzz
    {
        public string GetFizzOrBuzz(int number)
        {
            
            if(number % 3 ==0 && number % 5 != 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0 && number % 3 != 0)
            {
                return "Buzz";
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            return number.ToString();
        }
    }
}
