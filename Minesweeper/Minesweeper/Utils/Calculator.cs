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

        public static int CountUncheckedfields(List<List<MinesweeperField>> minefield)
        {
            int count = 0;
            for(int x=0; x < minefield.Count; x++)
            {
                for(int y=0; y < minefield[x].Count; y++)
                {
                    if (!minefield[x][y].unlocked) count++;
                }
            }
            return count;
        }

        public static int CalculateBombs(List<List<MinesweeperField>> minefield)
        {
            int count = 0;
            for (int x = 0; x < minefield.Count; x++)
            {
                for (int y = 0; y < minefield[x].Count; y++)
                {
                    if (minefield[x][y].isBomb) count++;
                }
            }
            return count;
        }
    }
}
