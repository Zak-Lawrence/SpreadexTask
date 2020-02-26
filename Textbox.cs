using System;
using System.Drawing;

namespace DrawingWidgets
{
    public class Textbox : Widget
    {
        private string text;
        private Rect bounding_box;

        public Textbox(string text, Rect bounding_box) : base("Textbox", bounding_box.GetLocation().X, bounding_box.GetLocation().Y)
        {
            if (bounding_box == null)
            {
                throw new ArgumentNullException("bounding_box");
            }
            this.text = text;
            this.bounding_box = bounding_box;
        }

        /* Overload the constructor to alternatively allow a location, width and 
        ** height to be provided to construct the bounding box.
        */
        public Textbox(string text, int location_x, int location_y, int width, int height) : base("Textbox", location_x, location_y)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Arguments must be positive.");
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("height", "Arguments must be positive.");
            }
            this.text = text;
            this.bounding_box = new Rect(location_x, location_y, width, height);
        }

        public string GetText()
        {
            return text;
        }

        public Rect GetBoundingBox()
        {
            return bounding_box;
        }

        public override string ToString()
        {
            return string.Format("{0} width={1} height={2} Text=\"{3}\"",
                base.ToString(), bounding_box.GetWidth(), bounding_box.GetHeight(), text);
        }
    }
}
