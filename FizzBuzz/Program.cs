using FizzBuzz.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFizzBuzz();
        }

        /// <summary>
        /// Method that runs the fizzbuzz logic
        /// </summary>
        private static void RunFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                var checkFizz = CheckFizz(i);
                var checkBuzz = CheckBuzz(i);

                if (checkFizz.IsSuccessfull && checkBuzz.IsSuccessfull)
                {
                    Console.WriteLine(checkFizz.Data+checkBuzz.Data);
                    continue;
                }

                if (checkFizz.IsSuccessfull)
                {
                    Console.WriteLine(checkFizz.Data);
                    continue;
                }

                if (checkBuzz.IsSuccessfull)
                {
                    Console.WriteLine(checkBuzz.Data);
                    continue;
                }

                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// check if a number can be divided on 3
        /// </summary>
        /// <param name="i"></param>
        /// <returns>return a Generic Result with the word Fizz if it can be divided on 3</returns>
        private static TResult<string> CheckFizz(int i)
        {
            var result = new TResult<string>();
            if (i % 3 == 0)
            {
                result.IsSuccessfull = true;
                result.Data = "Fizz";
            }
            return result;
        }
        /// <summary>
        /// check if a number can be divided on 5
        /// </summary>
        /// <param name="i"></param>
        /// <returns>return a Generic Result with the word Buzz if it can be divided on 5</returns>
        private static TResult<string> CheckBuzz(int i)
        {
            var result = new TResult<string>();
            if (i % 5 == 0)
            {
                result.IsSuccessfull = true;
                result.Data = "Buzz";
            }
            return result;
        }
    }
}
