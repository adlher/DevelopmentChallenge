using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapezoid : Shape
    {
        private readonly decimal smallerBase;
        private readonly decimal largerBase;
        private readonly decimal side;

        public Trapezoid(decimal smallerBase, decimal largerBase, decimal side)
        {
            this.smallerBase = smallerBase;
            this.largerBase = largerBase;
            this.side = side;
        }

        public override decimal CalculateArea()
        {
            var height = CalculateHeight();
            return (largerBase + smallerBase) * height / 2;
        }

        public override decimal CalculatePerimeter()
        {
            return smallerBase + largerBase + side + side;
        }

        private decimal CalculateHeight()
        {
            var rectangleBase = (largerBase - smallerBase) / 2;
            var res = Math.Pow((double)side, 2) - Math.Pow((double)rectangleBase, 2);
            if (res < 0) throw new ArgumentOutOfRangeException("Los lados ingresados no conforman un trapecio isósceles.");
            return (decimal)Math.Sqrt(res);
        }
    }
}
