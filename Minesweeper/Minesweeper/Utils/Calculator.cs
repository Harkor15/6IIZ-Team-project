using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Utils
{
    public class Calculator
    {
        public static int CalculateFieldNumber(int cellSize, int pixel)
        {
            return pixel / cellSize;
        }
    }
}
