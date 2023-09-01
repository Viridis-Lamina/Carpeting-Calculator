
using System;

namespace CarpetCalculator
{
    class Program
    {
        static double GetValidInput(string prompt)
        // below is creating the variables for the function.To check the input is valid. The double value is used to store valid inputs to assign to the vairables in the calculation
        // later. While the Bool is used to figure out if the input is valid or not.
        {
            double value;
            bool isValidInput = false;

            // below is the do while loop that checks if the users inputs are valid. It attempts to convert the string input into a double and out put it into the value vairable.
            // if it can do this it sends the stored value over to vairable requesting it in this case it will first be height then width. if it cannot convert the string input into
            // a double then it will sen the user a prompt saying invalid input and request them to replace their input. 
            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                // Check if input can be parsed as a double
                if (double.TryParse(input, out value))
                {
                    isValidInput = true; // Exit the loop if valid input is provided
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);

            return value;
        }

        static void Main()
        {
            // below i declare the vairables used for the calculations for the carpet and the ones the value sends its stored inputs to. In this case its Height and width.
            // then i create the cost vairable that times the inputs collected by the user against the constant double of square foot to work out the cost of the job before.
            // outputting it to the user. 
            const double Squarefootcost = 1.55;
            double height = GetValidInput("Please input the Height of the room in Ft");
            double width = GetValidInput("Please input the Width of the room in Ft");
            double cost = (height * width) * Squarefootcost;
            Console.WriteLine("The height of the room is " + height + " Ft");
            Console.WriteLine("The width of the room is " + width + " Ft");
            Console.WriteLine();
            Console.WriteLine("The Cost to Carpet this room is £{0}", cost);


        }
    }
}