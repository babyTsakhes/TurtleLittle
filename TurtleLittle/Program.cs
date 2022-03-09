using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleLittle
{
    class Program
    {
        static void WriteT(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size*3);
            Turtle.TurnLeft();
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(size*2);
        }

        static void WriteO()
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(60);
                Turtle.TurnRight();
            }
        }

        static void WriteR(int size)
        {
            Turtle.Angle = 0;
            for( int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
            Turtle.Angle = 180;
            Turtle.Move(size);
        }

        static void WriteM(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.MoveTo(Turtle.X+size/2, Turtle.Y);
            Turtle.MoveTo(Turtle.X, Turtle.Y+size/2);
            Turtle.MoveTo(Turtle.X + size/4, Turtle.Y);
            Turtle.MoveTo(Turtle.X , Turtle.Y - size/2);
            Turtle.MoveTo(Turtle.X + size/2, Turtle.Y);
            Turtle.MoveTo(Turtle.X, Turtle.Y + size);


        }
        static void Main(string[] args)
        {
            /*  Turtle.Speed = 8;
              //coordinates
              Turtle.X = 200;
              Turtle.Y = 200;

              //T
              WriteT(40);

              Turtle.X = 260;
              Turtle.Y = 200;
              WriteO();

              Turtle.X = 360;
              Turtle.Y = 180;
              WriteR(40);



              //T
              Turtle.X = 440;
              Turtle.Y = 200;
              WriteT(20);*/
            Turtle.X = 200;
            Turtle.Y = 200;
            WriteM(50);
            Turtle.Hide();
        }
    }
}
