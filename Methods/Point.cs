using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point NewLocation)
        {
            if (NewLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(NewLocation.X, NewLocation.Y);
            //this.X = NewLocation.X;
            //this.Y = NewLocation.Y;
        }
    }
}
