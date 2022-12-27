using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMe.Entities
{
    /// <summary>
    /// The Atrangle is used to calculate the area of a triangle with 3 random sides
    /// </summary>
    public class Atrangle
    {
        private double sideA {  get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }

        public double Calculate
        {
            get
            {
                Random rnd = new Random();
                sideA = rnd.Next(10,50);
                sideB = rnd.Next(10,50);
                sideC = rnd.Next(10,50);

                double perimeter = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));

                return area;
            }
        }
    }
}
