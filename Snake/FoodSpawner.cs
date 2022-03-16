using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodSpawner
    {
        Snake snake;
        Food food;
        public Food Food => food;

        private int width;
        private int height;
        private int foodSize;

        Random rand = new Random();

        public FoodSpawner(Snake snake, int width, int height, int size)
        {
            this.snake = snake;
            this.width = width;
            this.height = height;
            this.foodSize = size;
        }

        public void SpawnFood()
        {
            int x = 0;
            int y = 0;
            for(int i = 0; i < 1000; i++)
            {
                x = rand.Next(width - 1);
                y = rand.Next(height - 1);
                if(snake.Contains(x,y))
                {
                    Console.WriteLine("THIS IS WEIRD...");
                } else
                {
                    break;
                }
            }
            food = new Food(foodSize, x,y, Color.Blue);
        }

    }
}
