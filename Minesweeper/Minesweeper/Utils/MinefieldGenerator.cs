using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Utils
{
    class MinefieldGenerator
    {
        public static List<List<MinesweeperField>> GenerateMinefield(int width, int height, int bombs)
        {
            var minefield = GenerateEmptyMinefield(width, height);
            minefield = SetBombs(minefield, bombs);
            minefield = SetIcons(minefield);


            return minefield;
        }

        public static List<List<MinesweeperField>> GenerateBlankMinefield(int width, int height)
        {
            List<List<MinesweeperField>> minefield = new List<List<MinesweeperField>>();

            for (int i = 0; i < width; i++)
            {
                minefield.Add(new List<MinesweeperField>());
                for (int j = 0; j < height; j++)
                {
                    var field = new MinesweeperField();
                    field.unlocked = true;
                    minefield[i].Add(field);
                }
            }
            return minefield;
        }

        public static List<List<MinesweeperField>> ConvertDesignerToGamefield(List<List<MinesweeperField>> minefield)
        {
            for (int x = 0; x < minefield.Count; x++)
            {
                for (int y = 0; y < minefield[0].Count; y++)
                {
                    minefield[x][y].unlocked = false;
                }
            }
            return SetIcons(minefield);
        }

        public static List<List<MinesweeperField>> SetIcons(List<List<MinesweeperField>> minefield)
        {
            for(int x = 0; x < minefield.Count; x++)
            {
                for(int y=0;y<minefield[0].Count; y++)
                {
                    if (!minefield[x][y].isBomb)
                    {
                        int maxX = minefield.Count-1;
                        int maxY = minefield[0].Count - 1;
                        int counter = 0;
                        if (x > 0)
                        {
                            if (minefield[x - 1][y].isBomb) counter++;
                            if (y > 0) if (minefield[x - 1][y - 1].isBomb) counter++;
                            if (y < maxY) if (minefield[x - 1][y + 1].isBomb) counter++;
                        }
                        if (x < maxX)
                        {
                            if (minefield[x + 1][y].isBomb) counter++;
                            if (y > 0) if (minefield[x + 1][y - 1].isBomb) counter++;
                            if (y < maxY) if (minefield[x + 1][y + 1].isBomb) counter++;
                        }
                        if (y > 0) if (minefield[x][y-1].isBomb) counter++;
                        if (y < maxY) if (minefield[x][y + 1].isBomb) counter++;

                        minefield[x][y].number = counter;
                    }
                }
            }
            return minefield;
        }

        private static List<List<MinesweeperField>> SetBombs(List<List<MinesweeperField>> minefield, int bombs)
        {
            Random random = new Random();
            for (int i=0; i < bombs; i++){

                int x = random.Next(0, minefield.Count - 1);
                int y = random.Next(0, minefield[0].Count - 1);

                bool isBombSet = false;
                do
                {
                    if (minefield[x][y].isBomb)
                    {
                        x++;
                        if (x >= minefield[0].Count)
                        {
                            x = 0;
                            y++;
                            if (y >= minefield.Count)
                            {
                                y = 0;
                            }
                        }
                    }
                    else
                    {
                        minefield[x][y].isBomb = true;
                        isBombSet = true;
                    }
                } while (!isBombSet);
            }
            return minefield;
        }

        private static List<List<MinesweeperField>> GenerateEmptyMinefield(int width, int height)
        {
            List<List<MinesweeperField>> minefield = new List<List<MinesweeperField>>();
            for (int i = 0; i < width; i++)
            {
                minefield.Add(new List<MinesweeperField>());
                for (int j = 0; j < height; j++)
                {
                    minefield[i].Add(new MinesweeperField());
                }
            }
            return minefield;
        }
    }
}
