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
        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            //coordinates
            Turtle.X = 200;
            Turtle.Y = 200;

            //T
            WriteT(20);

            Turtle.X = 260;
            Turtle.Y = 200;
            WriteO();



            //T
            Turtle.X = 400;
            Turtle.Y = 200;
            WriteT(20);

        }
    }
}
