using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.Connect4.Models
{
    public class Space
    {
        public PieceEnum? Piece { get; protected set; }

        public void SetPiece(PieceEnum piece)
        {
            Piece = piece;
        }

    }
}
