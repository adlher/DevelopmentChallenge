using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangle : Shape
    {
        private readonly decimal height;
        private readonly decimal width;

        public Rectangle(decimal height, decimal width)
        {
            this.height = height;
            this.width = width;
        }

        public override decimal CalculateArea()
        {
            return height * width;
        }

        public override decimal CalculatePerimeter()
        {
            return 2 * (height + width);
        }
    }
}
