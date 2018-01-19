namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanVsHumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediocreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreCountGroupBox = new System.Windows.Forms.GroupBox();
            this.numGamesLabel = new System.Windows.Forms.Label();
            this.numTieLabel = new System.Windows.Forms.Label();
            this.playerOWinLabel = new System.Windows.Forms.Label();
            this.tieLabel = new System.Windows.Forms.Label();
            this.playerXWinLabel = new System.Windows.Forms.Label();
            this.playerOLossLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.playerXLossLabel = new System.Windows.Forms.Label();
            this.playerOlabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.playerXlabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.scoreCountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.ticTacToeLogo;
            this.logo.Location = new System.Drawing.Point(12, 51);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 72);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(189, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.setChoice);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(304, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.setChoice);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(74, 281);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.setChoice);
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(189, 281);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(109, 101);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.setChoice);
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(304, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(109, 101);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.setChoice);
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(74, 388);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(109, 101);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.setChoice);
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(189, 388);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(109, 101);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.setChoice);
            this.pictureBox8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(304, 388);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(109, 101);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.setChoice);
            this.pictureBox9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(74, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.setChoice);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridBox_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanVsHumanToolStripMenuItem,
            this.humanVsComputerToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // humanVsHumanToolStripMenuItem
            // 
            this.humanVsHumanToolStripMenuItem.Name = "humanVsHumanToolStripMenuItem";
            this.humanVsHumanToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.humanVsHumanToolStripMenuItem.Text = "Human vs Human";
            this.humanVsHumanToolStripMenuItem.Click += new System.EventHandler(this.setDifficulty);
            // 
            // humanVsComputerToolStripMenuItem
            // 
            this.humanVsComputerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediocreToolStripMenuItem,
            this.difficultToolStripMenuItem});
            this.humanVsComputerToolStripMenuItem.Name = "humanVsComputerToolStripMenuItem";
            this.humanVsComputerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.humanVsComputerToolStripMenuItem.Text = "Human vs Computer";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.easyToolStripMenuItem.Text = "Novice";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.setDifficulty);
            // 
            // mediocreToolStripMenuItem
            // 
            this.mediocreToolStripMenuItem.Name = "mediocreToolStripMenuItem";
            this.mediocreToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.mediocreToolStripMenuItem.Text = "Intermediate";
            this.mediocreToolStripMenuItem.Click += new System.EventHandler(this.setDifficulty);
            // 
            // difficultToolStripMenuItem
            // 
            this.difficultToolStripMenuItem.Name = "difficultToolStripMenuItem";
            this.difficultToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.difficultToolStripMenuItem.Text = "Expert";
            this.difficultToolStripMenuItem.Click += new System.EventHandler(this.setDifficulty);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.frenchToolStripMenuItem.Text = "French";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // scoreCountGroupBox
            // 
            this.scoreCountGroupBox.Controls.Add(this.numGamesLabel);
            this.scoreCountGroupBox.Controls.Add(this.numTieLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerOWinLabel);
            this.scoreCountGroupBox.Controls.Add(this.tieLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerXWinLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerOLossLabel);
            this.scoreCountGroupBox.Controls.Add(this.winLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerXLossLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerOlabel);
            this.scoreCountGroupBox.Controls.Add(this.lossLabel);
            this.scoreCountGroupBox.Controls.Add(this.totalLabel);
            this.scoreCountGroupBox.Controls.Add(this.playerXlabel);
            this.scoreCountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCountGroupBox.Location = new System.Drawing.Point(280, 27);
            this.scoreCountGroupBox.Name = "scoreCountGroupBox";
            this.scoreCountGroupBox.Size = new System.Drawing.Size(191, 127);
            this.scoreCountGroupBox.TabIndex = 15;
            this.scoreCountGroupBox.TabStop = false;
            this.scoreCountGroupBox.Text = "Score Count";
            // 
            // numGamesLabel
            // 
            this.numGamesLabel.AutoSize = true;
            this.numGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGamesLabel.Location = new System.Drawing.Point(118, 106);
            this.numGamesLabel.Name = "numGamesLabel";
            this.numGamesLabel.Size = new System.Drawing.Size(13, 13);
            this.numGamesLabel.TabIndex = 23;
            this.numGamesLabel.Text = "0";
            // 
            // numTieLabel
            // 
            this.numTieLabel.AutoSize = true;
            this.numTieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTieLabel.Location = new System.Drawing.Point(118, 83);
            this.numTieLabel.Name = "numTieLabel";
            this.numTieLabel.Size = new System.Drawing.Size(13, 13);
            this.numTieLabel.TabIndex = 22;
            this.numTieLabel.Text = "0";
            // 
            // playerOWinLabel
            // 
            this.playerOWinLabel.AutoSize = true;
            this.playerOWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOWinLabel.Location = new System.Drawing.Point(87, 59);
            this.playerOWinLabel.Name = "playerOWinLabel";
            this.playerOWinLabel.Size = new System.Drawing.Size(13, 13);
            this.playerOWinLabel.TabIndex = 4;
            this.playerOWinLabel.Text = "0";
            // 
            // tieLabel
            // 
            this.tieLabel.AutoSize = true;
            this.tieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieLabel.Location = new System.Drawing.Point(6, 83);
            this.tieLabel.Name = "tieLabel";
            this.tieLabel.Size = new System.Drawing.Size(35, 13);
            this.tieLabel.TabIndex = 21;
            this.tieLabel.Text = "Ties:";
            // 
            // playerXWinLabel
            // 
            this.playerXWinLabel.AutoSize = true;
            this.playerXWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerXWinLabel.Location = new System.Drawing.Point(87, 34);
            this.playerXWinLabel.Name = "playerXWinLabel";
            this.playerXWinLabel.Size = new System.Drawing.Size(13, 13);
            this.playerXWinLabel.TabIndex = 3;
            this.playerXWinLabel.Text = "0";
            // 
            // playerOLossLabel
            // 
            this.playerOLossLabel.AutoSize = true;
            this.playerOLossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOLossLabel.Location = new System.Drawing.Point(143, 59);
            this.playerOLossLabel.Name = "playerOLossLabel";
            this.playerOLossLabel.Size = new System.Drawing.Size(13, 13);
            this.playerOLossLabel.TabIndex = 20;
            this.playerOLossLabel.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(78, 15);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(35, 13);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "Wins";
            // 
            // playerXLossLabel
            // 
            this.playerXLossLabel.AutoSize = true;
            this.playerXLossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerXLossLabel.Location = new System.Drawing.Point(143, 34);
            this.playerXLossLabel.Name = "playerXLossLabel";
            this.playerXLossLabel.Size = new System.Drawing.Size(13, 13);
            this.playerXLossLabel.TabIndex = 19;
            this.playerXLossLabel.Text = "0";
            // 
            // playerOlabel
            // 
            this.playerOlabel.AutoSize = true;
            this.playerOlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOlabel.Location = new System.Drawing.Point(6, 59);
            this.playerOlabel.Name = "playerOlabel";
            this.playerOlabel.Size = new System.Drawing.Size(59, 13);
            this.playerOlabel.TabIndex = 1;
            this.playerOlabel.Text = "Player O:";
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossLabel.Location = new System.Drawing.Point(136, 15);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(46, 13);
            this.lossLabel.TabIndex = 18;
            this.lossLabel.Text = "Losses";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(6, 106);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(98, 13);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "TOTAL GAMES:";
            // 
            // playerXlabel
            // 
            this.playerXlabel.AutoSize = true;
            this.playerXlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerXlabel.Location = new System.Drawing.Point(6, 34);
            this.playerXlabel.Name = "playerXlabel";
            this.playerXlabel.Size = new System.Drawing.Size(58, 13);
            this.playerXlabel.TabIndex = 0;
            this.playerXlabel.Text = "Player X:";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Location = new System.Drawing.Point(189, 495);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(109, 31);
            this.playAgainButton.TabIndex = 16;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.Location = new System.Drawing.Point(304, 495);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(109, 31);
            this.undoButton.TabIndex = 17;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.backgroundImage;
            this.ClientSize = new System.Drawing.Size(489, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.scoreCountGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scoreCountGroupBox.ResumeLayout(false);
            this.scoreCountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanVsHumanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.GroupBox scoreCountGroupBox;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label playerOlabel;
        private System.Windows.Forms.Label playerXlabel;
        private System.Windows.Forms.Label playerOWinLabel;
        private System.Windows.Forms.Label playerXWinLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label numGamesLabel;
        private System.Windows.Forms.Label numTieLabel;
        private System.Windows.Forms.Label tieLabel;
        private System.Windows.Forms.Label playerOLossLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label playerXLossLabel;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediocreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

