using System;
using System.Drawing;

namespace DrawingWidgets
{
    public class Ellipse : Widget
    {
        private int diameterH, diameterV;

        public Ellipse(int location_x, int location_y, int diameterH, int diameterV) : base("Ellipse", location_x, location_y)
        {
            if (diameterH <= 0)
            {
                throw new ArgumentOutOfRangeException("diameterH", "Dimensions must be positive.");
            }
            if (diameterV <= 0)
            {
                throw new ArgumentOutOfRangeException("diameterV", "Dimensions must be positive.");
            }
            this.diameterH = diameterH;
            this.diameterV = diameterV;
        }
        public int GetDiameterH()
        {
            return diameterH;
        }
        public int GetDiameterV()
        {
            return diameterV;
        }

        public override string ToString()
        {
            return string.Format("{0} diameterH={1} diameterV={2}",
                base.ToString(), diameterH, diameterV);
        }
    }
}
