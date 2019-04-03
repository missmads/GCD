using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the GCD");

            Console.WriteLine("Choose your first number:");

            //Convert the users' input to an int... It crashes if the input is not a number
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your second number:");

            //Same as before
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Calculate the GCD itself
            while (firstNumber != 0 && secondNumber != 0)
            {
                //If the fist input is greater than the second
                if (firstNumber > secondNumber)
                {
                    //Finding the GCD via modilus
                    firstNumber %= secondNumber;
                }
                //Same as before but in reverse
                else
                {
                    secondNumber %= firstNumber;
                }
            }
            Console.WriteLine("The GCD is:");

            //Output the result of the calculations
            Console.WriteLine(firstNumber == 0 ? secondNumber : firstNumber);

            //Wait for the user to input something before ending the program
            Console.ReadLine();
        }
    }
}
