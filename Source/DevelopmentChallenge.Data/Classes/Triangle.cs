using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Triangle : Shape
    {
        private readonly decimal side;

        public Triangle(decimal side)
        {
            this.side = side;
        }

        public override decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * side * side;
        }

        public override decimal CalculatePerimeter()
        {
            return side * 3;
        }
    }
}
