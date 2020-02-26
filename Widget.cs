using System;
using System.Drawing;

namespace DrawingWidgets
{
    /*
    ** Define an abstract widget class to hold the common attributes of each widget,
    ** not allowing instantiation as a widget alone is not a meaningful object without 
    ** a size. "shape" and "location" are protected to allow access by derived classes 
    ** but not to allow changes.
    **
    ** Each specific type of widget has its own derived class with private variables to 
    ** describe the size. In the contructors for each widget type, size arguments are 
    ** checked for positivity.
    */
    public abstract class Widget  // Abstract class as we only want to instantiate derived classes
    {
        protected string shape;
        protected Point location;

        public Widget(string shape, int location_x, int location_y)
        {
            this.shape = shape;
            this.location = new Point(location_x, location_y);
        }
        public string GetShape()
        {
            return shape;
        }

        public Point GetLocation()
        {
            return location;
        }

        public override string ToString()   // Write the shape and location, common to all widgets.
        {
            return string.Format("{0} ({1},{2})", shape, location.X, location.Y);
        }
    }
}
