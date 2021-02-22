using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private char foodSymbol;
        private Wall wall;
        private Random random;
        protected Food(Wall wall, char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodSymbol = foodSymbol;
            this.random = new Random();
        }

        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = random.Next(2, this.wall.LeftX - 2);
            this.TopY = random.Next(2, this.wall.TopY - 2);

            bool isPointOfTheSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

            while (isPointOfTheSnake)
            {
                this.LeftX = random.Next(2, this.wall.LeftX - 2);
                this.TopY = random.Next(2, this.wall.TopY - 2);

                isPointOfTheSnake = snakeElements.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            }

            this.Draw(this.LeftX, this.TopY, this.foodSymbol);
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY && snake.LeftX == this.LeftX;
        }
    }
}
