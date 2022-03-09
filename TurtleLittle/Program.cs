using Microsoft.SmallBasic.Library;
using System;

namespace TurtleLittle
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            /*GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10,10);
            Shapes.Move(eat, 200, 200);*/
            Turtle.X = 100;
            Turtle.Y = 100;
            
              while (true)
              {
                  Turtle.Move(10);
                GraphicsWindow.BrushColor = "Red";
                var eat = Shapes.AddRectangle(20, 20);
                Shapes.Move(eat, 200, 300);
              /*  if (20 == Turtle.X && 30 == Turtle.Y)*/
                    Shapes.Move(eat, 30, 40);
                    Shapes.Move(eat, Turtle.X, Turtle.Y+10);
                /* for (int i = 0; i < 7; i++)
                 {

                     //AddFood(200 - i * 7, 200 - i * i * (i + 1) * 15, 10 + i * 2, 10 - i, "Red");
                 }*/
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
