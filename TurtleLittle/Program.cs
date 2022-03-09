using Microsoft.SmallBasic.Library;
using System;


namespace TurtleLittle
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(29, 20);
            int x = 178;
            int y = 178;
            Shapes.Move(eat, x, y);
              while (true)
              {
                if (Turtle.X >= x && Turtle.X <= x +20 && Turtle.Y >= y && Turtle.Y <= y+20 )
                {
                    GraphicsWindow.BrushColor = "Green";
                   for(int i = 0; i < 7;i++)
                       Shapes.Move(Shapes.AddRectangle(i*i, i+2), 170+i*11, 180+i*i*i*i*2);
                    Random rand = new Random();
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x , y);
                    Shapes.Zoom(eat, 0.8, 0.8);
                    Turtle.Speed++;
                }
                Turtle.Move(10);
            }
        }

        private static void AddFood(int x, int y, int width,
            int height, string color)
        {
           
                GraphicsWindow.BrushColor = color;
                var eat = Shapes.AddRectangle(width, height);
                Shapes.Move(eat, x, y);
        }
        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if(GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
