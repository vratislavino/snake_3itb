using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameCanvas : UserControl
    {
        Snake snake;
        int squareSize = 40;

        public GameCanvas()
        {
            InitializeComponent();
            StartGame();
        }

        public void StartGame()
        {
            snake = new Snake(
                squareSize, 
                Width/squareSize/2, 
                Height/squareSize/2, 
                Color.Red);
        }

        private void GameCanvas_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics);
        }
    }
}
