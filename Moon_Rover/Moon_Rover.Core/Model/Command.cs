using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class Command
    {
        string[] command = new string[50];

        Rover rover = new Rover();
        public void GetCommand(string[] command)
        {
            for(int i=0;i<=command[i].Length;i++)
            {
                if (command[i] == "M")
                    rover.move();
                else if (command[i] == "R")
                    rover.TurnRight();
                else if (command[i] == "L")
                    rover.TurnLeft();
                
            }
        }
    }
}
