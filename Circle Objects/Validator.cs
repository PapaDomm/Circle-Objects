using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Validator
    {
        public double validDouble()
        {
            double userRadius;
            while (!double.TryParse(Console.ReadLine(), out userRadius))
            {
                Console.Write("Please enter a valid input!: ");
            }
            return userRadius;
        }

        public bool validYN()
        {

            Console.Write("\nWould you like to grow the circle?(Y/N): ");
            string answer = Console.ReadLine().ToLower().Trim();
            while (answer != "y" && answer != "n")
            {
                Console.Write("\nWould you like to grow the circle?(Y/N): ");
                answer = Console.ReadLine().ToLower().Trim();
            }
            
            if(answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
