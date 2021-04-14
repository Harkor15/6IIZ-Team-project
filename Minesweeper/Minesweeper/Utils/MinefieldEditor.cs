using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Utils
{
    public class MinefieldEditor
    {
        private List<List<MinesweeperField>> minefield;
        int maxX;
        int maxY;
        public List<List<MinesweeperField>> ShowNeighboursFields(List<List<MinesweeperField>> minefieldLocal,int x,int y)
        {
            minefield = minefieldLocal;
            maxX = minefield.Count - 1;
            maxY = minefield[0].Count - 1;
            CheckFieldAndNeighbours(x, y);
            return minefield;
        }

        private void CheckFieldAndNeighbours(int x, int y)
        {
            if (!minefield[x][y].checkedAsBomb)
            {
                if (!minefield[x][y].unlocked)
                {
                    minefield[x][y].unlocked = true;
                    if (minefield[x][y].number == 0)
                    {
                        if (x > 0)
                        {
                            CheckFieldAndNeighbours(x - 1, y);
                            if (y > 0) CheckFieldAndNeighbours(x - 1, y - 1);
                            if (y < maxY) CheckFieldAndNeighbours(x - 1, y + 1);
                        }
                        if (x < maxX)
                        {
                            CheckFieldAndNeighbours(x + 1, y);
                            if (y > 0) CheckFieldAndNeighbours(x + 1, y - 1);
                            if (y < maxY) CheckFieldAndNeighbours(x + 1, y + 1);
                        }
                        if (y > 0) CheckFieldAndNeighbours(x, y - 1);
                        if (y < maxY) CheckFieldAndNeighbours(x, y + 1);
                    }
                }
            }
        }
    }
}
