using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circle : Shape
    {
        private readonly decimal diameter;

        public Circle(decimal diameter)
        {
            this.diameter = diameter;
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (diameter / 2) * (diameter / 2);
        }

        public override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * diameter;
        }
    }
}
