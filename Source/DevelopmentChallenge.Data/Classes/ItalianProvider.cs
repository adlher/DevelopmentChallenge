using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class ItalianProvider : ILanguageProvider
    {
        public string GetEmptyTitle()
        {
            return "<h1>Lista vuota di forme!</h1>";
        }

        public string GetHeaderTitle()
        {
            return "<h1>Rapporto delle Forme</h1>";
        }

        public string GetTotalTitle()
        {
            return "TOTALE:<br/>";
        }

        public string GetTotalQuantity(int totalQuantity)
        {
            return $"{totalQuantity} forme ";
        }

        public string GetTotalPerimeter(decimal totalPerimeter)
        {
            return $"Perimetro {totalPerimeter:#.##} ";
        }

        public string GetTotalArea(decimal totalArea)
        {
            return $"Area {totalArea:#.##}";
        }

        public string GetLine(Shape shape, int quantity, decimal area, decimal perimeter)
        {
            if (quantity > 0)
            {
                return $"{quantity} {TranslateShape(shape, quantity > 1)} | Area {area:#.##} | Perimetro {perimeter:#.##} <br/>";
            }

            return string.Empty;
        }

        private string TranslateShape(Shape shape, bool pluralize = false)
        {
            if (shape.GetType() == typeof(Square))
            {
                return pluralize ? "Quadrati" : "Quadrato";
            }

            if (shape.GetType() == typeof(Circle))
            {
                return pluralize ? "Cerchi" : "Cerchio";
            }

            if (shape.GetType() == typeof(Triangle))
            {
                return pluralize ? "Triangoli" : "Triangolo";
            }

            if (shape.GetType() == typeof(Rectangle))
            {
                return pluralize ? "Rettangoli" : "Rettangolo";
            }

            if (shape.GetType() == typeof(Trapezoid))
            {
                return pluralize ? "Trapezi" : "Trapezio";
            }

            return string.Empty;
        }
    }
}
