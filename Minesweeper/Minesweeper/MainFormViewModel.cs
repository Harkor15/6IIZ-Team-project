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
        bool lockGame = true;
        int bombs = 0;
        Mode mode = Mode.PLAY;

        public void CreateNewGame(int width, int height, int bombs)
        {
            if (Validator.isCreateNewGamaInitialSettingsValid(width, height, bombs))
            {
                minefieldSize.Event(new Size(cellSize * width, cellSize * height));
                minefieldLocal = MinefieldGenerator.GenerateMinefield(width, height, bombs);
                minefield.Event(minefieldLocal);
                lockGame = false;
                this.bombs = bombs;
                mode = Mode.PLAY;
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

            if (mode == Mode.PLAY) FieldClicked(x, y, left);
            else FieldClickedInDesigner(x, y);
        }

        private void FieldClickedInDesigner(int x, int y)
        {
            minefieldLocal[x][y].isBomb = !minefieldLocal[x][y].isBomb;
            minefield.Event(minefieldLocal);
        }
        private void FieldClicked(int x, int y, bool left)
        {
            if (!minefieldLocal[x][y].unlocked&&!lockGame)
            {
                if (left)
                {
                    if (!minefieldLocal[x][y].checkedAsBomb)
                    {
                        if (minefieldLocal[x][y].isBomb)
                        {
                            GameOver();
                        }
                        MinefieldEditor minefieldEditor = new MinefieldEditor();
                        minefieldLocal=minefieldEditor.ShowNeighboursFields(minefieldLocal,x,y);
                        //minefieldLocal[x][y].unlocked = true;
                        int unlockedFields=Calculator.CountUncheckedfields(minefieldLocal);
                        if (unlockedFields == bombs)
                        {
                            lockGame = true;
                            message.Event("You win!");
                        }
                        
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

        public void StartDesinger(int width, int height)
        {
            mode = Mode.DESIGNER;
            minefieldLocal=MinefieldGenerator.GenerateBlankMinefield(width, height);
            minefield.Event(minefieldLocal);
            lockGame = false;
        }

        public void DesignerPlay()
        {
            if (minefieldLocal.Count > 0)
            {
                minefieldLocal = MinefieldGenerator.ConvertDesignerToGamefield(minefieldLocal);
                bombs = Calculator.CalculateBombs(minefieldLocal);
                minefield.Event(minefieldLocal);
                mode = Mode.PLAY;
            }
        }
    }
}
