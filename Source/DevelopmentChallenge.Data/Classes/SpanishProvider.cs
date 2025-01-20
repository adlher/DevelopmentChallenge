using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class SpanishProvider : ILanguageProvider
    {
        public string GetEmptyTitle()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string GetHeaderTitle()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string GetTotalTitle()
        {
            return "TOTAL:<br/>";
        }

        public string GetTotalQuantity(int totalQuantity)
        {
            return $"{totalQuantity} formas ";
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
                return pluralize ? "Cuadrados" : "Cuadrado";
            }

            if (shape.GetType() == typeof(Circle))
            {
                return pluralize ? "Círculos" : "Círculo";
            }

            if (shape.GetType() == typeof(Triangle))
            {
                return pluralize ? "Triángulos" : "Triángulo";
            }

            if (shape.GetType() == typeof(Rectangle))
            {
                return pluralize ? "Rectángulos" : "Rectángulo";
            }

            if (shape.GetType() == typeof(Trapezoid))
            {
                return pluralize ? "Trapecios" : "Trapecio";
            }

            return string.Empty;
        }
    }
}
