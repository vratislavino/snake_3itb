using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameCanvas : UserControl
    {
        //https://github.com/vratislavino/snake_3itb

        Snake snake;
        int squareSize = 40;
        FoodSpawner foodSpawner;

        public GameCanvas()
        {
            InitializeComponent();
            DoubleBuffered = true;
            StartGame();
        }

        public void StartGame()
        {
            snake = new Snake(
                squareSize, 
                Width/squareSize/2, 
                Height/squareSize/2, 
                Color.Red);
            foodSpawner = new FoodSpawner(snake, Width / squareSize, Height/squareSize, squareSize);
        }

        private void GameCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            snake.Draw(e.Graphics);
            foodSpawner.Food?.Draw(e.Graphics);
        }

        private void GameCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if(gameTimer.Enabled)
            {
                if (e.KeyCode == Keys.W)
                    snake.ChangeDirection(Direction.Up);
                if (e.KeyCode == Keys.A)
                    snake.ChangeDirection(Direction.Left);
                if (e.KeyCode == Keys.S)
                    snake.ChangeDirection(Direction.Down);
                if (e.KeyCode == Keys.D)
                    snake.ChangeDirection(Direction.Right);
            } else
            {
                if(e.KeyCode == Keys.Space)
                {
                    gameTimer.Start();
                    foodSpawner.SpawnFood();
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            DoMovement();
            CheckForFood();
            Refresh();
            CheckForDeath();
            snake.UpdateDirections();
        }

        private void CheckForFood()
        {
            if(snake.CollidedWithFood(foodSpawner.Food))
            {
                snake.FoodEaten();
                foodSpawner.SpawnFood();
            }
        }

        private void CheckForDeath()
        {
            if(snake.Died(this.Width, this.Height))
            {
                gameTimer.Stop();
                MessageBox.Show("ENDE! Skóre: " + snake.Score);
            }
        }

        private void DoMovement()
        {
            snake.Move();
        }
    }
}
