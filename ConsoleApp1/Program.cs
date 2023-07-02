
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
            // The first line is to inform the user how much the carpet costs per Square feet. I use a line break to make it neater.
            Console.WriteLine("The Cost per Square foot is £{0}",Squarefootcost);
            Console.WriteLine();

            // Next I get the users to input their values I make seperate string variable that get converted into doubles later.
            
            Console.WriteLine("Please input the Height of the room in Ft");
            String InputH = Console.ReadLine();
            Console.WriteLine("Please input the Width of the room in Ft");
            String InputW = Console.ReadLine();

            // Below I convert the strings to doubles and use them for the calculations. 
            Height = Convert.ToDouble(InputH);   
            Width = Convert.ToDouble(InputW);  
            Cost = (Height * Width) * Squarefootcost;

            Console.WriteLine("The Cost to Carpet this room is £{0}", Cost);

        }
    }
}