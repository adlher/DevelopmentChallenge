using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Shape
    {
        public abstract decimal CalculatePerimeter();
        public abstract decimal CalculateArea();

        public static string Print(List<Shape> shapes, ILanguageProvider languageProvider = null)
        {
            // default es inglés
            if (languageProvider == null)
                languageProvider = new EnglishProvider();
            var sb = new StringBuilder();

            if (!shapes.Any())
            {
                sb.Append(languageProvider.GetEmptyTitle());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(languageProvider.GetHeaderTitle());
                var resume = new List<ShapeData>();

                for (var i = 0; i < shapes.Count; i++)
                {
                    var shapeData = resume.FirstOrDefault(x => x.Shape.GetType() == shapes[i].GetType());
                    if (shapeData != null)
                    {
                        shapeData.Quantity++;
                        shapeData.Area += shapes[i].CalculateArea();
                        shapeData.Perimeter += shapes[i].CalculatePerimeter();
                    }
                    else
                    {
                        resume.Add(new ShapeData()
                        {
                            Shape = shapes[i],
                            Quantity = 1,
                            Area = shapes[i].CalculateArea(),
                            Perimeter = shapes[i].CalculatePerimeter()
                        });
                    }
                }

                foreach (var shapeData in resume)
                {
                    sb.Append(languageProvider.GetLine(shapeData.Shape, shapeData.Quantity, shapeData.Area, shapeData.Perimeter));
                }

                // FOOTER
                sb.Append(languageProvider.GetTotalTitle());
                sb.Append(languageProvider.GetTotalQuantity(resume.Sum(x => x.Quantity)));
                sb.Append(languageProvider.GetTotalPerimeter(resume.Sum(x => x.Perimeter)));
                sb.Append(languageProvider.GetTotalArea(resume.Sum(x => x.Area)));
            }

            return sb.ToString();
        }
    }
}
