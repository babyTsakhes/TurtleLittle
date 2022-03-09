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
            Turtle.Speed = 9;

            Turtle.Move(100);
            Turtle.TurnRight();

            Turtle.Move(100);
            Turtle.TurnRight();

            Turtle.Move(100);
            Turtle.TurnRight();

            Turtle.Move(90);
            Turtle.TurnRight();

            Turtle.Move(80);
            Turtle.TurnRight();

            Turtle.Move(80);
            Turtle.TurnRight();

            Turtle.Move(70);
            Turtle.TurnRight();

            Turtle.Move(70);
            Turtle.TurnRight();

            Turtle.Move(60);
            Turtle.TurnRight();
        }
    }
}
