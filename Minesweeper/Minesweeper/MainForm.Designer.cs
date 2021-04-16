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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDesignerHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDesignerWIdth = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateBlank = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewGameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesignerHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesignerWIdth)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(115, 167);
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
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPlay);
            this.groupBox2.Controls.Add(this.numericUpDownDesignerHeight);
            this.groupBox2.Controls.Add(this.numericUpDownDesignerWIdth);
            this.groupBox2.Controls.Add(this.buttonCreateBlank);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Designer";
            // 
            // numericUpDownDesignerHeight
            // 
            this.numericUpDownDesignerHeight.Location = new System.Drawing.Point(9, 71);
            this.numericUpDownDesignerHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDesignerHeight.Name = "numericUpDownDesignerHeight";
            this.numericUpDownDesignerHeight.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownDesignerHeight.TabIndex = 7;
            this.numericUpDownDesignerHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownDesignerWIdth
            // 
            this.numericUpDownDesignerWIdth.Location = new System.Drawing.Point(9, 30);
            this.numericUpDownDesignerWIdth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDesignerWIdth.Name = "numericUpDownDesignerWIdth";
            this.numericUpDownDesignerWIdth.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownDesignerWIdth.TabIndex = 5;
            this.numericUpDownDesignerWIdth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonCreateBlank
            // 
            this.buttonCreateBlank.Location = new System.Drawing.Point(6, 97);
            this.buttonCreateBlank.Name = "buttonCreateBlank";
            this.buttonCreateBlank.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateBlank.TabIndex = 6;
            this.buttonCreateBlank.Text = "Create blank";
            this.buttonCreateBlank.UseVisualStyleBackColor = true;
            this.buttonCreateBlank.Click += new System.EventHandler(this.buttonCreateBlank_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Width";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(6, 126);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 23);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesignerHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesignerWIdth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateNewGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameBombs;
        private System.Windows.Forms.NumericUpDown numericUpDownNewGameHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.NumericUpDown numericUpDownDesignerHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownDesignerWIdth;
        private System.Windows.Forms.Button buttonCreateBlank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

