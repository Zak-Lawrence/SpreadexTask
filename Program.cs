using System;
using System.Drawing;

namespace DrawingWidgets
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        ** Create an empty drawing then add the 5 specified widgets, before 
        ** printing the attributes of the widgets to the console.
        */
            Drawing drawing = new Drawing();

            drawing.AddWidget(new Rect(10, 10, 30, 40));

            drawing.AddWidget(new Square(15, 30, 35));

            drawing.AddWidget(new Circle(1, 1, 300));

            drawing.AddWidget(new Ellipse(100, 150, 300, 200));

            drawing.AddWidget(new Textbox("sample text", 5, 5, 200, 100));

            drawing.Print();

            Console.ReadKey();
        }
    }
}


