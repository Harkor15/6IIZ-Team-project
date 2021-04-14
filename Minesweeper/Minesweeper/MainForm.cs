using Minesweeper.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form
    {
        MainFormViewModel viewModel;
        Bitmap minefieldBitmap=null;

        public MainForm()
        {
            InitializeComponent();
            viewModel = new MainFormViewModel();
            BindView();
        }

        private void BindView()
        {
            viewModel.minefield.Handler += Minefield_Handler;
            viewModel.minefieldSize.Handler += MinefieldSize_Handler;
            viewModel.message.Handler += Message_Handler;
        }

        private void Message_Handler(object sender, string e)
        {
            MessageBox.Show(e);
        }

        private void MinefieldSize_Handler(object sender, Size e)
        {
            pictureBox1.Size = e;
        }

        private void Minefield_Handler(object sender, List<List<MinesweeperField>> e)
        {
            if (minefieldBitmap != null) minefieldBitmap.Dispose();
            minefieldBitmap = BitmapGenerator.GenerateBitmap(e);
            pictureBox1.Image = minefieldBitmap;
            
        }

        private void buttonCreateNewGame_Click(object sender, EventArgs e)
        {
            int width = (int)numericUpDownNewGameWidth.Value;
            int height = (int)numericUpDownNewGameHeight.Value;
            int bombs = (int)numericUpDownNewGameBombs.Value;
            viewModel.CreateNewGame(width, height, bombs);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            viewModel.MinefieldClicked(e.X, e.Y,e.Button==MouseButtons.Left);
        }
    }
}
