namespace ChessEngine.Engine
{
    internal static class PieceSquareTable
    {
        private static readonly short[] BishopTable = new short[]
        {
             -40, -20, -20, -20, -20, -20, -20, -40 ,
             -20,   0,   0,   0,   0,   0,   0, -20 ,
             -20,   0,  10,  20,  20,  10,   0, -20 ,
             -20,  10,  10,  20,  20,  10,  10, -20 ,
             -20,   0,  20,  20,  20,  20,   0, -20 ,
             -20,  20,  20,  20,  20,  20,  20, -20 ,
             -20,  10,   0,   0,   0,   0,  10, -20 ,
             -40, -20, -20, -20, -20, -20, -20, -40 
        };

        private static readonly short[] KingEndGameTable = new short[]
        {
            -175,-175,-175,-175,-175,-175,-175,-175,
            -175, -50, -50, -50, -50, -50, -50,-175,
            -175, -50,  50,  50,  50,  50, -50,-175,
            -175, -50,  50, 150, 150,  50, -50,-175,
            -175, -50,  50, 100, 100,  50, -50,-175,
            -175, -50,  50,  50,  50,  50, -50,-175,
            -175, -50, -50, -50, -50, -50, -50,-175,
            -175,-175,-175,-175,-175,-175,-175,-175
        };

        private static readonly short[] KingMiddleGameTable = new short[]
        {
             -60, -80, -80, -2, -20, -80, -80, -60 ,
             -60, -80, -80, -2, -20, -80, -80, -60 ,
             -60, -80, -80, -2, -20, -80, -80, -60 ,
             -60, -80, -80, -2, -20, -80, -80, -60 ,
             -40, -60, -60, -8, -80, -60, -60, -40 ,
             -20, -40, -40, -40,-40, -40, -40, -20 ,
              40,  40,   0,   0,  0,   0,  40,  40 ,
              40,  60,  20,   0,  0,  20,  60,  40 
        };

        private static readonly short[] KnightTable = new short[]
        {
             -20, -80, -60, -60, -60, -60, -80, -20 ,
             -80, -40,   0,   0,   0,   0, -40, -80 ,
             -60,   0,  20,  30,  30,  20,   0, -60 , 
             -60,  10,  30,  40,  40,  30,  10, -60 ,
             -60,   0,  30,  40,  40,  30,   0, -60 , 
             -60,  10,  20,  30,  30,  30,   1, -60 ,
             -80, -40,   0,  10,  10,   0,  -4, -80 ,
             -20, -80, -60, -60, -60, -60, -80, -20 ,
        };

        private static readonly short[] PawnTable = new short[]
        {
            9000,9000,9000,9000,9000,9000,9000,9000 ,
             200, 200, 200, 200, 200, 200, 200, 200 ,
             100, 100, 100, 100, 100, 100, 100, 100 ,
              40,  40,  90, 100, 100,  90,  40,  40 ,
              20,  20,  20, 100, 150,  20,  20,  20 ,
               2,   4,   0,  15,   4,   0,   4,   2 ,
             -10, -10, -10, -20, -35, -10, -10, -10 ,
               0,   0,   0,   0,   0,   0,   0,   0 
        };

        private static readonly short[] PawnTableEndGame = new short[]
        {
             9000,9000,9000,9000,9000,9000,9000,9000 ,
              500, 500, 500, 500, 500, 500, 500, 500 ,
              300, 300, 300, 300, 300, 300, 300, 300 ,
               90,  90,  90, 100, 100,  90,  90,  90 ,
               70,  70,  70,  85,  85,  70,  70,  70 ,
               20,  20,  20,  20,  20,  20,  20,  20 , 
              -10, -10, -10, -10, -10, -10, -10, -10 ,
                0,   0,   0,   0,   0,   0,   0,   0 
        };

        private static readonly short[] QueenTable = new short[]
        {
             -40, -20, -20, -10, -10, -20, -20, -40 ,
             -20,   0,   0,   0,   0,   0,   0, -20 ,
             -20,   0,  10,  10,  10,  10,   0, -20 ,
             -10,   0,  10,  10,  10,  10,   0, -10 ,
               0,   0,  10,  10,  10,  10,   0, -10 ,
             -20,  10,  10,  10,  10,  10,   0, -20 ,
             -20,   0,  10,   0,   0,   0,   0, -20 ,
             -40, -20, -20, -10, -10, -20, -20, -40 
        };

        private static readonly short[] RookTable = new short[]
        {
               0,  0,  0,  0,  0,  0,  0,   0 ,
              10, 20, 20, 20, 20, 20, 20,  10 ,
             -10,  0,  0,  0,  0,  0,  0, -10 ,
             -10,  0,  0,  0,  0,  0,  0, -10 ,
             -10,  0,  0,  0,  0,  0,  0, -10 ,
             -10,  0,  0,  0,  0,  0,  0, -10 , 
             -10,  0,  0,  0,  0,  0,  0, -10 ,
             -30, 30, 40, 10, 10,  0,  0, -30 
        };

        internal static int EvaluatePiecePosition( ChessPieceType PieceType,
                                                   ChessPieceColor PieceColor,
                                                   byte position, bool endGame )
        {
            switch (PieceColor)
            {
                case ChessPieceColor.White:
                    if (PieceType == ChessPieceType.Pawn)
                    {
                        if (endGame)
                        {
                            return PawnTableEndGame[position];
                        }

                        return PawnTable[position];
                    }
                    if (PieceType == ChessPieceType.Knight)
                    {
                        return KnightTable[position];
                    }
                    if (PieceType == ChessPieceType.Bishop)
                    {
                        return BishopTable[position];
                    }
                    if (PieceType == ChessPieceType.Rook)
                    {
                        return RookTable[position];
                    }
                    if (PieceType == ChessPieceType.Queen)
                    {
                        return QueenTable[position];
                    }
                    if (PieceType == ChessPieceType.King)
                    {
                        if (endGame)
                        {
                            return KingEndGameTable[position];
                        }

                        return KingMiddleGameTable[position];
                    }
                    break;
                case ChessPieceColor.Black:

                    byte index = (byte)(((byte)(position + 56)) - (byte)((byte)(position / 8) * 16));

                    if (PieceType == ChessPieceType.Pawn)
                    {
                        if (endGame)
                        {
                            return PawnTableEndGame[index];
                        }

                        return PawnTable[index];
                    }
                    if (PieceType == ChessPieceType.Knight)
                    {
                        return KnightTable[index];
                    }
                    if (PieceType == ChessPieceType.Bishop)
                    {
                        return BishopTable[index];
                    }
                    if (PieceType == ChessPieceType.Rook)
                    {
                        return RookTable[index];
                    }
                    if (PieceType == ChessPieceType.Queen)
                    {
                        return QueenTable[index];
                    }
                    if (PieceType == ChessPieceType.King)
                    {
                        if (endGame)
                        {
                            return KingEndGameTable[index];
                        }

                        return KingMiddleGameTable[index];
                    }
                    break;
            }

            return 0;
        }



        internal static int EvaluatePawnWhitePosition(byte position, bool endGame)
        {
            if (endGame)
            {
                return PawnTableEndGame[position];
            }

            return PawnTable[position];
        }

        internal static int EvaluatePawnBlackPosition(byte position, bool endGame)
        {
            byte index = (byte)(((byte)(position + 56)) - (byte)((byte)(position / 8) * 16));

            if (endGame)
            {
                return PawnTableEndGame[index];
            }

            return PawnTable[index];    
        }
    }
}