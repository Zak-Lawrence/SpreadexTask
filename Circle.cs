using System;
using System.Drawing;

namespace DrawingWidgets
{
    public class Circle : Widget
    {
        private int diameter;

        public Circle(int location_x, int location_y, int diameter) : base("Circle", location_x, location_y)
        {
            if (diameter <= 0)
            {
                throw new ArgumentOutOfRangeException("diameter", "Dimensions must be positive.");
            }
            this.diameter = diameter;
        }

        public int GetDiameter()
        {
            return diameter;
        }

        public override string ToString()
        {
            return string.Format("{0} size={1}", base.ToString(), diameter);
        }
    }
}
