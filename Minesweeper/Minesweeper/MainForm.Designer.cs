namespace Minesweeper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownNewGameBombs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewGameHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewGameWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateNewGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownNewGameBombs);
            this.groupBox1.Controls.Add(this.numericUpDownNewGameHeight);
            this.groupBox1.Controls.Add(this.numericUpDownNewGameWidth);
            this.groupBox1.Controls.Add(this.buttonCreateNewGame);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New game";
            // 
            // numericUpDownNewGameBombs
            // 
            this.numericUpDownNewGameBombs.Location = new System.Drawing.Point(9, 110);
            this.numericUpDownNewGameBombs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewGameBombs.Name = "numericUpDownNewGameBombs";
            this.numericUpDownNewGameBombs.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownNewGameBombs.TabIndex = 8;
            this.numericUpDownNewGameBombs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNewGameHeight
            // 
            this.numericUpDownNewGameHeight.Location = new System.Drawing.Point(9, 71);
            this.numericUpDownNewGameHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNewGameHeight.Name = "numericUpDownNewGameHeight";
            this.numericUpDownNewGameHeight.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownNewGameHeight.TabIndex = 7;
            this.numericUpDownNewGameHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownNewGameWidth
            // 
            this.numericUpDownNewGameWidth.Location = new System.Drawing.Point(9, 30);
            this.numericUpDownNewGameWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNewGameWidth.Name = "numericUpDownNewGameWidth";
            this.numericUpDownNewGameWidth.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownNewGameWidth.TabIndex = 5;
            this.numericUpDownNewGameWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonCreateNewGame
            // 
            this.buttonCreateNewGame.Location = new System.Drawing.Point(6, 136);
            this.buttonCreateNewGame.Name = "buttonCreateNewGame";
            this.buttonCreateNewGame.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateNewGame.TabIndex = 6;
            this.buttonCreateNewGame.Text = "Create";
            this.buttonCreateNewGame.UseVisualStyleBackColor = true;
            this.buttonCreateNewGame.Click += new System.EventHandler(this.buttonCreateNewGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bombs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Minesweeper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateNewGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameBombs;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameHeight;
    }
}

