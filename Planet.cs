using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrograms
{
    public class Planet
    {
        public enum Planets { Earth, Saturn, Neptune }
        public static double GetGravity(Planets planet)
        {
            if (planet == Planets.Saturn)
            {
                return 1.08;
            }
            else if (planet == Planets.Neptune)
            {
                return 1.14;
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

            double saturnWeight = weight * GetGravity(Planets.Saturn);
            double neptuneWeight = weight * GetGravity(Planets.Neptune);

            Console.WriteLine("Weight on Saturn: " + saturnWeight + " kg");
            Console.WriteLine("Weight on Neptune: " + neptuneWeight + " kg");
        }
    }
}
