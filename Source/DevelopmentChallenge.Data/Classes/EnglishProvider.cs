using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class EnglishProvider : ILanguageProvider
    {
        public string GetEmptyTitle()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string GetHeaderTitle()
        {
            return "<h1>Shapes report</h1>";
        }

        public string GetTotalTitle()
        {
            return "TOTAL:<br/>";
        }

        public string GetTotalQuantity(int totalQuantity)
        {
            return $"{totalQuantity} shapes ";
        }

        public string GetTotalPerimeter(decimal totalPerimeter)
        {
            return $"Perimeter {totalPerimeter:#.##} ";
        }

        public string GetTotalArea(decimal totalArea)
        {
            return $"Area {totalArea:#.##}";
        }

        public string GetLine(Shape shape, int quantity, decimal area, decimal perimeter)
        {
            if (quantity > 0)
            {
                return $"{quantity} {TranslateShape(shape, quantity > 1)} | Area {area:#.##} | Perimeter {perimeter:#.##} <br/>";
            }

            return string.Empty;
        }

        private string TranslateShape(Shape shape, bool pluralize = false)
        {
            if (shape.GetType() == typeof(Square))
            {
                return pluralize ? "Squares" : "Square";
            }

            if (shape.GetType() == typeof(Circle))
            {
                return pluralize ? "Circles" : "Circle";
            }

            if (shape.GetType() == typeof(Triangle))
            {
                return pluralize ? "Triangles" : "Triangle";
            }

            if (shape.GetType() == typeof(Rectangle))
            {
                return pluralize ? "Rectangles" : "Rectangle";
            }

            if (shape.GetType() == typeof(Trapezoid))
            {
                return pluralize ? "Trapezoids" : "Trapezoid";
            }

            return string.Empty;
        }
    }
}
