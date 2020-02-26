using System;
using System.Drawing;

namespace DrawingWidgets
{
    public class Rect : Widget
    {
        private int width, height;

        public Rect(int location_x, int location_y, int width, int height) : base("Rectangle", location_x, location_y)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Dimensions must be positive.");
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("height", "Dimensions must be positive.");
            }
            this.width = width;
            this.height = height;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public override string ToString()
        {
            return string.Format("{0} width={1} height={2}", base.ToString(), width, height);
        }
    }
}
