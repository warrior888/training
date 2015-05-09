﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Wiosna.Chess
{
    class Coordinates : ICoordinates
    {
        protected int X;
        protected int Y;

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
