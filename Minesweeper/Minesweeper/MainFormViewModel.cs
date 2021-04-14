using Minesweeper.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class MainFormViewModel
    {
        int cellSize = 25;
        public Observable<String> message = new Observable<string>();
        public Observable<List<List<MinesweeperField>>> minefield= new Observable<List<List<MinesweeperField>>>();
        private List<List<MinesweeperField>> minefieldLocal= new List<List<MinesweeperField>>();
        public Observable<Size> minefieldSize = new Observable<Size>();

        public void CreateNewGame(int width, int height, int bombs)
        {
            Console.WriteLine("Go game");
            if (Validator.isCreateNewGamaInitialSettingsValid(width, height, bombs))
            {
                minefieldSize.Event(new Size(cellSize * width, cellSize * height));
                minefieldLocal = MinefieldGenerator.GenerateMinefield(width, height, bombs);
                minefield.Event(minefieldLocal);
            }
            else
            {
                message.Event("Initial values incorrect!");
            }
        }
        public void MinefieldClicked(int pxX, int pxY, bool left )
        {
            int x = Calculator.CalculateFieldNumber(cellSize, pxX);
            int y = Calculator.CalculateFieldNumber(cellSize, pxY);
            FieldClicked(x, y,left);
        }


        private void FieldClicked(int x, int y, bool left)
        {
            if (!minefieldLocal[x][y].unlocked)
            {
                if (left)
                {
                    if (!minefieldLocal[x][y].checkedAsBomb)
                    {
                        if (minefieldLocal[x][y].isBomb)
                        {
                            GameOver();
                        }
                        minefieldLocal[x][y].unlocked = true;
                    }
                }
                else
                {
                    minefieldLocal[x][y].checkedAsBomb = !minefieldLocal[x][y].checkedAsBomb;
                }
                minefield.Event(minefieldLocal);
            }
        }

        private void GameOver()
        {
            message.Event("Game Over!");
        }
    }
}
