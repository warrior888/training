﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
    public class Queen: ChessFigures
    {
        public Queen(FigureKind figureKind) : base(figureKind)
        {
        }
        public Queen() { }
    }
}
