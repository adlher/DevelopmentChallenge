using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public interface ILanguageProvider
    {
        string GetLine(Shape shape, int quantity, decimal area, decimal perimeter);
        string GetEmptyTitle();
        string GetHeaderTitle();
        string GetTotalTitle();
        string GetTotalQuantity(int totalQuantity);
        string GetTotalPerimeter(decimal totalPerimeter);
        string GetTotalArea(decimal totalArea);
    }
}
