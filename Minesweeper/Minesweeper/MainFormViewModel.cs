using Minesweeper.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class MainFormViewModel
    {
        int cellSize = 25;
        public Observable<String> message = new Observable<string>();
        public Observable<List<List<MinesweeperField>>> minefield= new Observable<List<List<MinesweeperField>>>();
        public Observable<Size> minefieldSize = new Observable<Size>();

        public void CreateNewGame(int width, int height, int bombs)
        {
            Console.WriteLine("Go game");
            if (Validator.isCreateNewGamaInitialSettingsValid(width, height, bombs))
            {
                minefieldSize.Event(new Size(cellSize * width, cellSize * height));
                minefield.Event(MinefieldGenerator.GenerateMinefield(width, height, bombs));

                /*for(int x = 0; x < minefield.Count; x++)
                {
                    
                    for(int y = 0; y < minefield[0].Count; y++)
                    {
                        if (minefield[x][y].isBomb) Console.Write(" B ");
                        else Console.Write(" " + minefield[x][y].number + " ");
                    }
                }*/
            }
            else
            {
                message.Event("Initial values incorrect!");
            }
        }
    }
}
