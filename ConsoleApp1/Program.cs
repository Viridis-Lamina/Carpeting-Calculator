
using System;

namespace CarpetCalculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring the constant variable for the pricing of the room.

            const double Squarefootcost = 1.55;

            // Below I Declare the Variables for the Height and width of the room for the user to input the values for.
            Double Height;
            Double Width;
            Double Cost;
            bool isValidInput = false;
            // The first line is to inform the user how much the carpet costs per Square feet. I use a line break to make it neater.
            Console.WriteLine("The Cost per Square foot is £{0}",Squarefootcost);
            Console.WriteLine();

            // Next I get the users to input their values below I have created two do loops. One for height and one for width. The loop checks if the input for the user can be
            // converted into a double. If so the value is outputted into the varable for the dimension required. If not it prompts the user to use a valid imput. 


            do
            {
                Console.WriteLine("Please input the Height of the room in Ft");
                string input = Console.ReadLine();

                // Check if input can be parsed as a double
                if (double.TryParse(input, out Height))
                {
                    isValidInput = true; // Exit the loop if valid input is provided
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);


            Console.WriteLine("The height of the room is " + Height + "Ft");
            Console.WriteLine();
           
            do
            {
                Console.WriteLine("Please input the Width of the room in Ft");
                string input = Console.ReadLine();

                // Check if input can be parsed as a double
                if (double.TryParse(input, out Width))
                {
                    isValidInput = true; // Exit the loop if valid input is provided
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);


            Console.WriteLine("The height of the room is " + Height + "Ft");
            Console.WriteLine("The width of the room is " + Width + "Ft");
            Console.WriteLine();


            // After the user has imputted the vairable they are calculated below and the price is outputted to the user.  

            Cost = (Height * Width) * Squarefootcost;
            Console.WriteLine();
            Console.WriteLine("The Cost to Carpet this room is £{0}", Cost);

           

        }
    }
}