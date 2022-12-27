using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMe.Entities
{
    /// <summary>
    /// The Cuirckle is used to calculate the circumference of a circle with a random radius
    /// </summary>
    public class Cuirckle
    {
        private double _randomRadius;
        private double _circumference;
        public double RandomRadius { get { return _randomRadius; } }

        public double Calculate { 
            get {

                Random rnd = new Random();
                _randomRadius = Convert.ToDouble(rnd.Next(1000));
                _circumference = (2 * Math.PI) * _randomRadius;

                return _circumference;
            } 
        }  
    }
}
