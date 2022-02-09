using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Play_Game
{
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            playGame.Visible = false;
            gameStartsIn.Visible = true;
            gameStartsIn.Text = "Game Starts in 3";

            Refresh();
            Thread.Sleep(1000);

            gameStartsIn.Text = "Game Starts in 2";

            Refresh();
            Thread.Sleep(1000);

            gameStartsIn.Text = "Game Starts in 1";

            Refresh();
            Thread.Sleep(1000);

            gameStartsIn.Visible = false;
            gameStartsIn.Visible = false;
            goLabel.Visible = true;
        }

    }
}
