using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Utils
{
    public class BitmapGenerator
    {
        public static Bitmap GenerateBitmap(List<List<MinesweeperField>> minefield)
        {
            int cellSize = 25;
            int actualX = 0;
            Bitmap bitmap = new Bitmap(cellSize * minefield.Count, cellSize * minefield[0].Count);
            using(var g= Graphics.FromImage(bitmap)){
                for(int x = 0; x < minefield.Count; x++)
                {
                    int actualY = 0;
                    for (int y = 0; y<minefield[0].Count; y++)
                    {
                        if (minefield[x][y].isBomb) g.DrawImage(Properties.Resources.bomb, actualX, actualY);
                        else if (minefield[x][y].number == 0) g.DrawImage(Properties.Resources.blank, actualX, actualY);
                        else if (minefield[x][y].number==1) g.DrawImage(Properties.Resources._1, actualX, actualY);
                        else if(minefield[x][y].number==2) g.DrawImage(Properties.Resources._2, actualX, actualY);
                        else if(minefield[x][y].number==3) g.DrawImage(Properties.Resources._3, actualX, actualY);
                        else if(minefield[x][y].number==4) g.DrawImage(Properties.Resources._4, actualX, actualY);
                        else if(minefield[x][y].number==5) g.DrawImage(Properties.Resources._5, actualX, actualY);
                        else if(minefield[x][y].number==6) g.DrawImage(Properties.Resources._6, actualX, actualY);
                        else if(minefield[x][y].number==7) g.DrawImage(Properties.Resources._7, actualX, actualY);
                        else if(minefield[x][y].number==8) g.DrawImage(Properties.Resources._8, actualX, actualY);
                        else if(minefield[x][y].number==9) g.DrawImage(Properties.Resources._9, actualX, actualY);
                        actualY += cellSize;
                    }
                    actualX += cellSize;
                }
            }
            return bitmap;
        }
    }
}
