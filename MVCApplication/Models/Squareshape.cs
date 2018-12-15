using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{

    public class Squareshape
    {
        public string Name { get; set; }
        public double Sidelength { get; set; }

        public Squareshape(string name, double sidelength)
        {
            Name = name;
            Sidelength = sidelength;

        }

        public double Perimeter(double sidelength)
        {
            return (4 * sidelength);

        }

        public double Area(double sidelength)
        {
            return (sidelength * sidelength);

        }
    }

}


