using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Square : Shape
    {
        private readonly decimal side;

        public Square(decimal side)
        {
            this.side = side;
        }

        public override decimal CalculateArea()
        {
            return side * side;
        }

        public override decimal CalculatePerimeter()
        {
            return side * 4;
        }
    }
}
