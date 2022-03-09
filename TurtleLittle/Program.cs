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
       
        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            //coordinates
            Turtle.X = 200;
            Turtle.Y = 200;

            //T
            Turtle.Angle = 0;
            Turtle.Move(60);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);

            Turtle.X = 260;
            Turtle.Y = 200;
            Turtle.Angle = 0;

            for(int i = 0; i < 4; i++)
            {
                Turtle.Move(60);
                Turtle.TurnRight();
            }

            //T
            Turtle.Angle = 0;
            Turtle.Move(60);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);

        }
    }
}
