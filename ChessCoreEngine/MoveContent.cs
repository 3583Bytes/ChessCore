using System;

namespace ChessEngine.Engine
{
    
    public struct PieceMoving
    {
        public byte DstPosition;
        public bool Moved;
        public ChessPieceColor PieceColor;
        public ChessPieceType PieceType;
        public byte SrcPosition;
        
        public PieceMoving(ChessPieceColor pieceColor, ChessPieceType pieceType, bool moved,
                           byte srcPosition, byte dstPosition)
        {
            PieceColor = pieceColor;
            PieceType = pieceType;
            SrcPosition = srcPosition;
            DstPosition = dstPosition;
            Moved = moved;
        }

        public PieceMoving(PieceMoving pieceMoving)
        {
            PieceColor = pieceMoving.PieceColor;
            PieceType = pieceMoving.PieceType;
            SrcPosition = pieceMoving.SrcPosition;
            DstPosition = pieceMoving.DstPosition;
            Moved = pieceMoving.Moved;
        }

        public PieceMoving(ChessPieceType pieceType)
        {
            PieceType = pieceType;
            PieceColor = ChessPieceColor.White;
            SrcPosition = 0;
            DstPosition = 0;
            Moved = false;
        }
    }
   
    public struct PieceTaken
    {
        public bool Moved;
        public ChessPieceColor PieceColor;
        public ChessPieceType PieceType;
        public byte Position;

        public PieceTaken(ChessPieceColor pieceColor, ChessPieceType pieceType, bool moved,
                          byte position)
        {
            PieceColor = pieceColor;
            PieceType = pieceType;
            Position = position;
            Moved = moved;
        }

        public PieceTaken(ChessPieceType pieceType)
        {
            PieceColor = ChessPieceColor.White;
            PieceType = pieceType;
            Position = 0;
            Moved = false;
        }
    }
   
    public sealed class MoveContent
    {
        public bool EnPassantOccured;
        public PieceMoving MovingPiecePrimary;
        public PieceMoving MovingPieceSecondary;
        public ChessPieceType PawnPromotedTo;
        public PieceTaken TakenPiece;

        public bool DoubleRowQueen;
        public bool DoubleColQueen;

        public bool DoubleRowRook;
        public bool DoubleColRook;

        public bool DoubleRowKnight;
        public bool DoubleColKnight;

        public string PgnMove;


        public MoveContent()
        {
            MovingPiecePrimary = new PieceMoving(ChessPieceType.None);
            MovingPieceSecondary = new PieceMoving(ChessPieceType.None);
            TakenPiece = new PieceTaken(ChessPieceType.None);
        }

        public MoveContent(MoveContent moveContent)
        {
            MovingPiecePrimary = new PieceMoving(moveContent.MovingPiecePrimary);
            MovingPieceSecondary = new PieceMoving(moveContent.MovingPieceSecondary);

            TakenPiece = new PieceTaken(moveContent.TakenPiece.PieceColor,
                                        moveContent.TakenPiece.PieceType,
                                        moveContent.TakenPiece.Moved,
                                        moveContent.TakenPiece.Position);

            EnPassantOccured = moveContent.EnPassantOccured;
            PawnPromotedTo = moveContent.PawnPromotedTo;
        }

        public MoveContent(string move) : this()
        {
            int srcCol =-1;
            
            bool comment = false;
            bool srcFound = false;

            if (move.Contains("=Q"))
            {
                PawnPromotedTo = ChessPieceType.Queen;
            }
            else if (move.Contains("=N"))
            {
                PawnPromotedTo = ChessPieceType.Knight;
            }
            else if (move.Contains("=R"))
            {
                PawnPromotedTo = ChessPieceType.Rook;
            }
            else if (move.Contains("=B"))
            {
                PawnPromotedTo = ChessPieceType.Bishop;
            }

            foreach (char c in move)
            {
                if (c=='{')
                {
                    comment = true;
                    continue;
                }
                if (c == '}')
                {
                    comment = false;
                    continue;
                }

                if (comment)
                {
                    continue;
                }
       
                if (MovingPiecePrimary.PieceType == ChessPieceType.None)
                {
                    //Get Piece Type
                    MovingPiecePrimary.PieceType = GetPieceType(c);

                    if (MovingPiecePrimary.PieceType == ChessPieceType.None)
                    {
                        MovingPiecePrimary.PieceType = ChessPieceType.Pawn;

                        //This is a column character
                        srcCol= GetIntFromColumn(c);
                    }
                    continue;
                }
                if (srcCol < 0)
                {
                    srcCol = GetIntFromColumn(c);
                    continue;
                }
                if (srcCol >= 0)
                {
                    int srcRow = int.Parse(c.ToString());

                    if (!srcFound)
                    {
                        MovingPiecePrimary.SrcPosition = GetBoardIndex(srcCol, 8 - srcRow);
                        srcFound = true;
                    }
                    else
                    {
                        MovingPiecePrimary.DstPosition = GetBoardIndex(srcCol, 8 - srcRow);
                    }

                    srcCol = -1;
                    continue;
                }
            }
        }

		public static bool ParseAN(string move, ref byte sourceColumn, ref byte sourceRow, ref byte destinationColumn, ref byte destinationRow)
		{
			if (move.Length != 4) return false;
			sourceColumn = (byte)GetIntFromColumn(move[0]);
			sourceRow = (byte)(8 - int.Parse(""+move[1]));
			destinationColumn = (byte)GetIntFromColumn(move[2]);
			destinationRow = (byte)(8 - int.Parse(""+move[3]));
			return true;
		}

		public string GetPureCoordinateNotation()
		{
            var srcCol = (byte) (MovingPiecePrimary.SrcPosition%8);
            var srcRow = (byte)(8 - (MovingPiecePrimary.SrcPosition / 8));
            var dstCol = (byte) (MovingPiecePrimary.DstPosition%8);
            var dstRow = (byte) (8 - (MovingPiecePrimary.DstPosition/8));
			
			string result = ""+(char)('a'+srcCol)+(srcRow) + (char)('a'+dstCol)+(dstRow);
            if (PawnPromotedTo == ChessPieceType.Queen)
            {
                result += "=Q";
            }
            else if (PawnPromotedTo == ChessPieceType.Rook)
            {
                result += "=R";
            }
            else if (PawnPromotedTo == ChessPieceType.Bishop)
            {
                result += "=B";
            }
            else if (PawnPromotedTo == ChessPieceType.Knight)
            {
                result += "=N";
            }
			return result;
		}
		
        public new string ToString()
        {
            if (!String.IsNullOrEmpty(PgnMove))
            {
                return PgnMove;
            }

            var srcCol = (byte) (MovingPiecePrimary.SrcPosition%8);
            var srcRow = (byte)(8 - (MovingPiecePrimary.SrcPosition / 8));
            var dstCol = (byte) (MovingPiecePrimary.DstPosition%8);
            var dstRow = (byte) (8 - (MovingPiecePrimary.DstPosition/8));

            if (MovingPieceSecondary.PieceType == ChessPieceType.Rook)
            {
                if (MovingPieceSecondary.PieceColor == ChessPieceColor.Black)
                {
                    if (MovingPieceSecondary.SrcPosition == 7)
                    {
                        PgnMove += "O-O";
                    }
                    else if (MovingPieceSecondary.SrcPosition == 0)
                    {
                        PgnMove += "O-O-O";
                    }
                }
                else if (MovingPieceSecondary.PieceColor == ChessPieceColor.White)
                {
                    if (MovingPieceSecondary.SrcPosition == 63)
                    {
                        PgnMove += "O-O";
                    }
                    else if (MovingPieceSecondary.SrcPosition == 56)
                    {
                        PgnMove += "O-O-O";
                    }
                }
            }
            else
            {
                PgnMove += GetPgnMove(MovingPiecePrimary.PieceType);

                switch (MovingPiecePrimary.PieceType)
                {
                    case ChessPieceType.Knight:
                        PgnMove += GetColumnFromInt(srcCol);
                        PgnMove += srcRow;
                        break;
                    case ChessPieceType.Rook:
                        PgnMove += GetColumnFromInt(srcCol);
                        PgnMove += srcRow;
                        break;
                    case ChessPieceType.Pawn:
                        if (srcCol != dstCol)
                        {
                            PgnMove += GetColumnFromInt(srcCol);
                        }
                        break;
                }

                if (TakenPiece.PieceType != ChessPieceType.None)
                {
                    PgnMove += "x";
                }

                PgnMove += GetColumnFromInt(dstCol);

                PgnMove += dstRow;

                if (PawnPromotedTo == ChessPieceType.Queen)
                {
                    PgnMove += "=Q";
                }
                else if (PawnPromotedTo == ChessPieceType.Rook)
                {
                    PgnMove += "=R";
                }
                else if (PawnPromotedTo == ChessPieceType.Bishop)
                {
                    PgnMove += "=B";
                }
                else if (PawnPromotedTo == ChessPieceType.Knight)
                {
                    PgnMove += "=N";
                }
            }

            return PgnMove;
        }

        internal string GeneratePGNString(Board board)
        {
            if (!String.IsNullOrEmpty(PgnMove))
            {
                return PgnMove;
            }

            bool doubleColumn = false;
            bool doubleRow = false;


            bool doubleDestination = false;

            var srcCol = (byte)(MovingPiecePrimary.SrcPosition % 8);
            var srcRow = (byte)(8 - (MovingPiecePrimary.SrcPosition / 8));
            var dstCol = (byte)(MovingPiecePrimary.DstPosition % 8);
            var dstRow = (byte)(8 - (MovingPiecePrimary.DstPosition / 8));

            PgnMove = "";

            for (byte x = 0; x < 64; x++)
            {
                if (x == MovingPiecePrimary.DstPosition)
                    continue;
                
                Square square = board.Squares[x];

                if (square.Piece == null)
                    continue;

                
                if (square.Piece.PieceType == MovingPiecePrimary.PieceType)
                {
                    if (square.Piece.PieceColor == MovingPiecePrimary.PieceColor)
                    {
                        foreach (byte move in square.Piece.ValidMoves)
                        {
                            if (move == MovingPiecePrimary.DstPosition)
                            {
                                doubleDestination = true;

                                byte col = (byte)(x % 8);
                                byte row = (byte)(8-(x / 8));
                               
                                if (col == srcCol)
                                {
                                    doubleColumn = true;
                                }

                                if (row == srcRow)
                                {
                                    doubleRow = true;
                                }
                               
                                break;
                            }
                        }

                        
                    }
                }
            }


            if (MovingPieceSecondary.PieceType == ChessPieceType.Rook)
            {
                if (MovingPieceSecondary.PieceColor == ChessPieceColor.Black)
                {
                    if (MovingPieceSecondary.SrcPosition == 7)
                    {
                        PgnMove += "O-O";
                    }
                    else if (MovingPieceSecondary.SrcPosition == 0)
                    {
                        PgnMove += "O-O-O";
                    }
                }
                else if (MovingPieceSecondary.PieceColor == ChessPieceColor.White)
                {
                    if (MovingPieceSecondary.SrcPosition == 63)
                    {
                        PgnMove += "O-O";
                    }
                    else if (MovingPieceSecondary.SrcPosition == 56)
                    {
                        PgnMove += "O-O-O";
                    }
                }
            }
            else
            {
                PgnMove += GetPgnMove(MovingPiecePrimary.PieceType);

                switch (MovingPiecePrimary.PieceType)
                {
                    case ChessPieceType.Knight:
                        {
                            if (doubleDestination)
                            {
                                if (!doubleColumn)
                                {
                                    PgnMove += GetColumnFromInt(srcCol);
                                }
                                else
                                {
                                    if (doubleRow)
                                    {
                                        PgnMove += GetColumnFromInt(srcCol);
                                    }

                                    PgnMove += srcRow;
                                }
                            }
                            break;
                        }
                    case ChessPieceType.Bishop:
                        {
                            if (doubleDestination)
                            {
                                if (!doubleColumn)
                                {
                                    PgnMove += GetColumnFromInt(srcCol);
                                }
                                else
                                {
                                    if (doubleRow)
                                    {
                                        PgnMove += GetColumnFromInt(srcCol);
                                    }

                                    PgnMove += srcRow;
                                }
                            }
                            break;
                        }
                    case ChessPieceType.Rook:
                        {
                            if (doubleDestination)
                            {
                                if (!doubleColumn)
                                {
                                    PgnMove += GetColumnFromInt(srcCol);
                                }
                                else
                                {
                                    if (doubleRow)
                                    {
                                        PgnMove += GetColumnFromInt(srcCol);
                                    }

                                    PgnMove += srcRow;
                                }
                            }
                            break;
                        }
                    case ChessPieceType.Queen:
                        {
                            if (doubleDestination)
                            {
                                if (!doubleColumn)
                                {
                                    PgnMove += GetColumnFromInt(srcCol);
                                }
                                else
                                {
                                    if (doubleRow)
                                    {
                                        PgnMove += GetColumnFromInt(srcCol);
                                    }

                                    PgnMove += srcRow;
                                }
                            }
                            break;
                        }
                    case ChessPieceType.Pawn:
                        {
                            if (doubleDestination && srcCol != dstCol)
                            {
                                PgnMove += GetColumnFromInt(srcCol);
                            }
                            else if (TakenPiece.PieceType != ChessPieceType.None)
                            {
                                PgnMove += GetColumnFromInt(srcCol);
                            }
                            break;
                        }
                }

                if (TakenPiece.PieceType != ChessPieceType.None)
                {
                    
                    PgnMove += "x";
                }

                PgnMove += GetColumnFromInt(dstCol);

                PgnMove += dstRow;

                if (PawnPromotedTo == ChessPieceType.Queen)
                {
                    PgnMove += "=Q";
                }
                else if (PawnPromotedTo == ChessPieceType.Rook)
                {
                    PgnMove += "=R";
                }
                else if (PawnPromotedTo == ChessPieceType.Bishop)
                {
                    PgnMove += "=B";
                }
                else if (PawnPromotedTo == ChessPieceType.Knight)
                {
                    PgnMove += "=N";
                }
            }

            return PgnMove;
        }

        private static byte GetBoardIndex(int col, int row)
        {
            return (byte)(col + (row * 8));
        }

        private static string GetColumnFromInt(int column)
        {
            switch (column)
            {
                case 0:
                    return "a";
                case 1:
                    return "b";
                case 2:
                    return "c";
                case 3:
                    return "d";
                case 4:
                    return "e";
                case 5:
                    return "f";
                case 6:
                    return "g";
                case 7:
                    return "h";
                default:
                    return "Unknown";
            }
        }

        private static int GetIntFromColumn(char column)
        {
            switch (column)
            {
                case 'a':
                    return 0;
                case 'b':
                    return 1;
                case 'c':
                    return 2;
                case 'd':
                    return 3;
                case 'e':
                    return 4;
                case 'f':
                    return 5;
                case 'g':
                    return 6;
                case 'h':
                    return 7;
                default:
                    return -1;
            }
        }

        private static ChessPieceType GetPieceType(char c)
        {
            switch (c)
            {
                case 'B':
                    return ChessPieceType.Bishop;
                case 'K':
                    return ChessPieceType.King;
                case 'N':
                    return ChessPieceType.Knight;
                case 'Q':
                    return ChessPieceType.Queen;
                case 'R':
                    return ChessPieceType.Rook;
                default:
                    return ChessPieceType.None;
            }
        }

        private static string GetPgnMove(ChessPieceType pieceType)
        {
            switch (pieceType)
            {
                case ChessPieceType.Bishop:
                    return "B";

                case ChessPieceType.King:
                    return "K";

                case ChessPieceType.Knight:
                    return "N";

                case ChessPieceType.Queen:
                    return "Q";

                case ChessPieceType.Rook:
                    return "R";
                default:
                    return "";
            }
        }
    }
}