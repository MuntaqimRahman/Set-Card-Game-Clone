namespace FinalApplicationSet
{
    partial class btnPreviousPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnPreviousPage));
            this.btnDeal = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pboxCanvas = new System.Windows.Forms.PictureBox();
            this.lockTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCards = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.score4 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxPlayerSelect = new System.Windows.Forms.PictureBox();
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn3Player = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.btn4Player = new System.Windows.Forms.Button();
            this.btnPlayerLabel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayerSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeal.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.Color.Snow;
            this.btnDeal.Location = new System.Drawing.Point(484, 170);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(195, 32);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal New Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.button1_Click);
            this.btnDeal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTest_KeyDown);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 30;
            this.animationTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // jumpTimer
            // 
            this.jumpTimer.Interval = 30;
            this.jumpTimer.Tick += new System.EventHandler(this.jumpTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick_1);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(54, 445);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(29, 20);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "P1";
            this.lblPlayer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "P2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "P3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "P4";
            // 
            // pboxCanvas
            // 
            this.pboxCanvas.BackColor = System.Drawing.Color.Black;
            this.pboxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pboxCanvas.Name = "pboxCanvas";
            this.pboxCanvas.Size = new System.Drawing.Size(460, 478);
            this.pboxCanvas.TabIndex = 0;
            this.pboxCanvas.TabStop = false;
            this.pboxCanvas.Click += new System.EventHandler(this.pboxCanvas_Click);
            this.pboxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxCanvas_Paint);
            this.pboxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxCanvas_MouseDown);
            // 
            // lockTimer
            // 
            this.lockTimer.Tick += new System.EventHandler(this.lockTimer_Tick);
            // 
            // lblCards
            // 
            this.lblCards.BackColor = System.Drawing.Color.White;
            this.lblCards.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.ForeColor = System.Drawing.Color.Black;
            this.lblCards.Location = new System.Drawing.Point(484, 126);
            this.lblCards.Name = "lblCards";
            this.lblCards.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCards.Size = new System.Drawing.Size(196, 32);
            this.lblCards.TabIndex = 10;
            this.lblCards.Text = "Number of Cards Dealt: 0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Snow;
            this.btnNewGame.Location = new System.Drawing.Point(484, 218);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(195, 34);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // score4
            // 
            this.score4.AutoSize = true;
            this.score4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score4.ForeColor = System.Drawing.Color.White;
            this.score4.Location = new System.Drawing.Point(406, 465);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(18, 20);
            this.score4.TabIndex = 15;
            this.score4.Text = "0";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3.ForeColor = System.Drawing.Color.White;
            this.score3.Location = new System.Drawing.Point(289, 465);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(18, 20);
            this.score3.TabIndex = 14;
            this.score3.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(174, 465);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(18, 20);
            this.score2.TabIndex = 13;
            this.score2.Text = "0";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(60, 465);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(18, 20);
            this.score1.TabIndex = 12;
            this.score1.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pboxPlayerSelect
            // 
            this.pboxPlayerSelect.Location = new System.Drawing.Point(1, 1);
            this.pboxPlayerSelect.Name = "pboxPlayerSelect";
            this.pboxPlayerSelect.Size = new System.Drawing.Size(691, 501);
            this.pboxPlayerSelect.TabIndex = 18;
            this.pboxPlayerSelect.TabStop = false;
            // 
            // btn1Player
            // 
            this.btn1Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Player.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Player.ForeColor = System.Drawing.Color.Snow;
            this.btn1Player.Location = new System.Drawing.Point(147, 176);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(195, 34);
            this.btn1Player.TabIndex = 19;
            this.btn1Player.Text = "1";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn3Player
            // 
            this.btn3Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Player.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Player.ForeColor = System.Drawing.Color.Snow;
            this.btn3Player.Location = new System.Drawing.Point(147, 216);
            this.btn3Player.Name = "btn3Player";
            this.btn3Player.Size = new System.Drawing.Size(195, 34);
            this.btn3Player.TabIndex = 20;
            this.btn3Player.Text = "3";
            this.btn3Player.UseVisualStyleBackColor = true;
            this.btn3Player.Click += new System.EventHandler(this.btn3Player_Click);
            // 
            // btn2Player
            // 
            this.btn2Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Player.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player.ForeColor = System.Drawing.Color.Snow;
            this.btn2Player.Location = new System.Drawing.Point(348, 176);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(195, 34);
            this.btn2Player.TabIndex = 21;
            this.btn2Player.Text = "2";
            this.btn2Player.UseVisualStyleBackColor = true;
            this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
            // 
            // btn4Player
            // 
            this.btn4Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4Player.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Player.ForeColor = System.Drawing.Color.Snow;
            this.btn4Player.Location = new System.Drawing.Point(348, 216);
            this.btn4Player.Name = "btn4Player";
            this.btn4Player.Size = new System.Drawing.Size(195, 34);
            this.btn4Player.TabIndex = 22;
            this.btn4Player.Text = "4";
            this.btn4Player.UseVisualStyleBackColor = true;
            this.btn4Player.Click += new System.EventHandler(this.btn4Player_Click);
            // 
            // btnPlayerLabel
            // 
            this.btnPlayerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerLabel.ForeColor = System.Drawing.Color.Snow;
            this.btnPlayerLabel.Location = new System.Drawing.Point(248, 119);
            this.btnPlayerLabel.Name = "btnPlayerLabel";
            this.btnPlayerLabel.Size = new System.Drawing.Size(195, 34);
            this.btnPlayerLabel.TabIndex = 23;
            this.btnPlayerLabel.Text = "Choose # of Players: ";
            this.btnPlayerLabel.UseVisualStyleBackColor = true;
            this.btnPlayerLabel.Click += new System.EventHandler(this.btnPlayerLabel_Click);
            // 
            // btnPreviousPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 502);
            this.Controls.Add(this.btnPlayerLabel);
            this.Controls.Add(this.btn4Player);
            this.Controls.Add(this.btn2Player);
            this.Controls.Add(this.btn3Player);
            this.Controls.Add(this.btn1Player);
            this.Controls.Add(this.pboxPlayerSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score4);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pboxCanvas);
            this.KeyPreview = true;
            this.Name = "btnPreviousPage";
            this.Text = " Set!";
            this.Load += new System.EventHandler(this.formSetGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formSetGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formSetGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayerSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer jumpTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboxCanvas;
        private System.Windows.Forms.Timer lockTimer;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label score4;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxPlayerSelect;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn3Player;
        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.Button btn4Player;
        private System.Windows.Forms.Button btnPlayerLabel;
    }
}

