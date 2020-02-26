using System;
using System.Drawing;
using System.Collections.Generic;

namespace DrawingWidgets
{
    public class Drawing    // Drawing class, holds a list of widgets and can print them to the console.
    {
        private List<Widget> widgets;

        public Drawing()
        {
            widgets = new List<Widget>();
        }

        public void AddWidget(Widget widget) 
        {
            if (widget == null) throw new ArgumentNullException("widget");
            widgets.Add(widget);
        }

        public void Print()
        {
            foreach (Widget widget in widgets)  Console.WriteLine(widget.ToString());
        }

    }
}
