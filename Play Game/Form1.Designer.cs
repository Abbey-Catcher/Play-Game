namespace Play_Game
{
    partial class title
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
            this.playGame = new System.Windows.Forms.Button();
            this.gameStartsIn = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGame
            // 
            this.playGame.AutoSize = true;
            this.playGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.playGame.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame.Location = new System.Drawing.Point(253, 34);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(277, 129);
            this.playGame.TabIndex = 1;
            this.playGame.Text = "Play Game";
            this.playGame.UseVisualStyleBackColor = false;
            this.playGame.Click += new System.EventHandler(this.playGame_Click);
            // 
            // gameStartsIn
            // 
            this.gameStartsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartsIn.ForeColor = System.Drawing.Color.White;
            this.gameStartsIn.Location = new System.Drawing.Point(269, 188);
            this.gameStartsIn.Name = "gameStartsIn";
            this.gameStartsIn.Size = new System.Drawing.Size(233, 39);
            this.gameStartsIn.TabIndex = 2;
            this.gameStartsIn.Text = "Game Starts In 3";
            this.gameStartsIn.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.White;
            this.goLabel.Location = new System.Drawing.Point(274, 188);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(228, 123);
            this.goLabel.TabIndex = 3;
            this.goLabel.Text = "Go!!";
            this.goLabel.Visible = false;
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.gameStartsIn);
            this.Controls.Add(this.playGame);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "title";
            this.Text = "Game Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Label gameStartsIn;
        private System.Windows.Forms.Label goLabel;
    }
}

