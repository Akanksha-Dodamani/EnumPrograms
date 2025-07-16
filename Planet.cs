using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrograms
{
    public class Planet
    {
        public enum Planets { Earth, Mars, Jupiter }
        public static double GetGravity(Planets planet)
        {
            if (planet == Planets.Mars)
            {
                return 0.377;
            }
            else if (planet == Planets.Jupiter)
            {
                return 2.37;
            }
            else
            {
                return 1.0;
            }
        }
        public static void WeightOnPlanets()
        {
            Console.Write("Enter weight on Earth: ");
            double weight = double.Parse(Console.ReadLine());

            double marsWeight = weight * GetGravity(Planets.Mars);
            double jupiterWeight = weight * GetGravity(Planets.Jupiter);

            Console.WriteLine("Weight on Mars: " + marsWeight + " kg");
            Console.WriteLine("Weight on Jupiter: " + jupiterWeight + " kg");
        }
    }
}
