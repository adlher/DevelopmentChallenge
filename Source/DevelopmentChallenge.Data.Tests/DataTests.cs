using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.That(Shape.Print(new List<Shape>(), new SpanishProvider()), Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.That(Shape.Print(new List<Shape>()), Is.EqualTo("<h1>Empty list of shapes!</h1>"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.That(Shape.Print(new List<Shape>(), new ItalianProvider()), Is.EqualTo("<h1>Lista vuota di forme!</h1>"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Shape> { new Square(5) };

            var resumen = Shape.Print(cuadrados, new SpanishProvider());

            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25"));
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Shape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var resumen = Shape.Print(cuadrados);

            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle( 2.75m),
                new Triangle(4.2m)
            };

            var resumen = Shape.Print(formas);
            Assert.That(resumen, Is.EqualTo("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65"));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75m),
                new Triangle(4.2m)
            };

            var resumen = Shape.Print(formas, new SpanishProvider());

            Assert.That(resumen, Is.EqualTo("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65"));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Rectangle(4,10),
                new Trapezoid(4,10,5),
                new Square(2),
                new Rectangle(2,6),
                new Trapezoid(6,12,7),
                new Rectangle(8,17),
            };

            var resumen = Shape.Print(formas, new ItalianProvider());

            Assert.That(resumen, Is.EqualTo("<h1>Rapporto delle Forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>3 Rettangoli | Area 188 | Perimetro 94 <br/>2 Trapezi | Area 84,92 | Perimetro 56 <br/>TOTALE:<br/>8 forme Perimetro 187,42 Area 308,99"));
        }
    }
}
