using Moon_Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Contract
{
    public interface IDirection
    {
        IDirection Left();

        IDirection Right();

        Coordinate Move(Coordinate position);

        string direction { get; }
    }
}
