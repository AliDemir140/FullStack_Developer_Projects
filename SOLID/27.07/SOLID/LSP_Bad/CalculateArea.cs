using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Bad
{
    internal class CalculateArea
    {
        //Dikdörtgen alan hesaplaması
        internal static double CalculateRectangleArea(Rectangle rectangle)
        {
           return rectangle.Width * rectangle.Height;

        }

        //Kare alan hesaplaması
        internal static double CalculateSquareArea(Square square)
        {
            return square.Width * square.Height;

        }
    }
}
