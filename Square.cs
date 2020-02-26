using System;
using System.Drawing;

namespace DrawingWidgets
{
    public class Square : Widget
    {
        private int width;

        public Square(int location_x, int location_y, int width) : base("Square", location_x, location_y)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Dimensions must be positive.");
            }
            this.width = width;
        }

        public int GetWidth()
        {
            return width;
        }

        public override string ToString()
        {
            return string.Format("{0} size={1}", base.ToString(), width);
        }
    }
}
