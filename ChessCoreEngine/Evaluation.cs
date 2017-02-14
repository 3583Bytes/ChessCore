
namespace ChessEngine.Engine
{
    internal static class Evaluation
    {
        private static short[] blackPawnCount;
        private static short[] whitePawnCount;
      
        private static readonly short[] PawnTable = new short[]
        {
       	     0,  0,  0,  0,  0,  0,  0,  0,
            50, 50, 50, 50, 50, 50, 50, 50,
            20, 20, 30, 40, 40, 30, 20, 20,
             5,  5, 10, 30, 30, 10,  5,  5,
             0,  0,  0, 25, 25,  0,  0,  0,
             5, -5,-10,  0,  0,-10, -5,  5,
             5, 10, 10,-30,-30, 10, 10,  5,
             0,  0,  0,  0,  0,  0,  0,  0
        };

        private static readonly short[] KnightTable = new short[]
        {
            -50,-40,-30,-30,-30,-30,-40,-50,
            -40,-20,  0,  0,  0,  0,-20,-40,
            -30,  0, 10, 15, 15, 10,  0,-30,
            -30,  5, 15, 20, 20, 15,  5,-30,
            -30,  0, 15, 20, 20, 15,  0,-30,
            -30,  5, 10, 15, 15, 10,  5,-30,
            -40,-20,  0,  5,  5,  0,-20,-40,
            -50,-30,-20,-30,-30,-20,-30,-50,
        };

        private static readonly short[] BishopTable = new short[]
        {
            -20,-10,-10,-10,-10,-10,-10,-20,
            -10,  0,  0,  0,  0,  0,  0,-10,
            -10,  0,  5, 10, 10,  5,  0,-10,
            -10,  5,  5, 10, 10,  5,  5,-10,
            -10,  0, 10, 10, 10, 10,  0,-10,
            -10, 10, 10, 10, 10, 10, 10,-10,
            -10,  5,  0,  0,  0,  0,  5,-10,
            -20,-10,-40,-10,-10,-40,-10,-20,
        };

        private static readonly short[] KingTable = new short[]
        {
          -30, -40, -40, -50, -50, -40, -40, -30,
          -30, -40, -40, -50, -50, -40, -40, -30,
          -30, -40, -40, -50, -50, -40, -40, -30,
          -30, -40, -40, -50, -50, -40, -40, -30,
          -20, -30, -30, -40, -40, -30, -30, -20,
          -10, -20, -20, -20, -20, -20, -20, -10, 
           20,  20,   0,   0,   0,   0,  20,  20,
           20,  30,  10,   0,   0,  10,  30,  20
        };

        private static readonly short[] KingTableEndGame = new short[]
        {
            -50,-40,-30,-20,-20,-30,-40,-50,
            -30,-20,-10,  0,  0,-10,-20,-30,
            -30,-10, 20, 30, 30, 20,-10,-30,
            -30,-10, 30, 40, 40, 30,-10,-30,
            -30,-10, 30, 40, 40, 30,-10,-30,
            -30,-10, 20, 30, 30, 20,-10,-30,
            -30,-30,  0,  0,  0,  0,-30,-30,
            -50,-30,-30,-30,-30,-30,-30,-50
        };

        private static int EvaluatePieceScore(Square square, byte position, bool endGamePhase,
                                                ref byte knightCount, ref byte bishopCount, ref bool insufficientMaterial)
        {
            int score = 0;

            byte index = position;

            if (square.Piece.PieceColor == ChessPieceColor.Black)
            {
                index = (byte)(63-position);
            }

            //Calculate Piece Values
            score += square.Piece.PieceValue;
            score += square.Piece.DefendedValue;
            score -= square.Piece.AttackedValue;

            //Double Penalty for Hanging Pieces
            if (square.Piece.DefendedValue < square.Piece.AttackedValue)
            {
                score -= ((square.Piece.AttackedValue - square.Piece.DefendedValue)* 10);
            }

            //Add Points for Mobility
            if (square.Piece.ValidMoves != null)
            {
                score += square.Piece.ValidMoves.Count;
            }

            if (square.Piece.PieceType == ChessPieceType.Pawn)
            {
                insufficientMaterial = false;

                if (position % 8 == 0 || position % 8 == 7)
                {
                    //Rook Pawns are worth 15% less because they can only attack one way
                    score -= 15;
                }

                //Calculate Position Values
                score += PawnTable[index];

                if (square.Piece.PieceColor == ChessPieceColor.White)
                {
                    if (whitePawnCount[position % 8] > 0)
                    {
                        //Doubled Pawn
                        score -= 15;
                    }

                    if (position >= 8 && position <= 15)
                    {
                        if (square.Piece.AttackedValue == 0)
                        {
                            whitePawnCount[position % 8] += 50;

                            if (square.Piece.DefendedValue != 0)
                                whitePawnCount[position % 8] += 50;
                        }
                    }
                    else if (position >= 16 && position <= 23)
                    {
                        if (square.Piece.AttackedValue == 0)
                        {
                            whitePawnCount[position % 8] += 25;


                            if (square.Piece.DefendedValue != 0)
                                whitePawnCount[position % 8] += 25;
                        }
                    }

                    whitePawnCount[position % 8]+=10;
                }
                else
                {
                    if (blackPawnCount[position % 8] > 0)
                    {
                        //Doubled Pawn
                        score -= 15;
                    }

                    if (position >= 48 && position <= 55)
                    {
                        if (square.Piece.AttackedValue == 0)
                        {
                            blackPawnCount[position % 8] += 200;

                            if (square.Piece.DefendedValue != 0)
                                blackPawnCount[position % 8] += 50;
                        }
                    }
                    //Pawns in 6th Row that are not attacked are worth more points.
                    else if (position >= 40 && position <= 47)
                    {
                        if (square.Piece.AttackedValue == 0)
                        {
                            blackPawnCount[position % 8] += 100;

                            if (square.Piece.DefendedValue != 0)
                                blackPawnCount[position % 8] += 25;
                        }
                    }

                    blackPawnCount[position % 8] += 10;
                    
                }
            }
            else if (square.Piece.PieceType == ChessPieceType.Knight)
            {
                knightCount++;

                score += KnightTable[index];

                //In the end game remove a few points for Knights since they are worth less
                if (endGamePhase)
                {
                    score -= 10;
                }

            }
            else if (square.Piece.PieceType == ChessPieceType.Bishop)
            {
                bishopCount++;

                if (bishopCount >= 2)
                {
                    //2 Bishops receive a bonus
                    score += 10;
                }

                //In the end game Bishops are worth more
                if (endGamePhase)
                {
                    score += 10;
                }

                score += BishopTable[index];
            }
            else if (square.Piece.PieceType == ChessPieceType.Rook)
            {
                insufficientMaterial = false;
            }
            else if (square.Piece.PieceType == ChessPieceType.Queen)
            {
                insufficientMaterial = false;

                if (square.Piece.Moved && !endGamePhase)
                {
                    score -= 10;
                }
            }
            else if (square.Piece.PieceType == ChessPieceType.King)
            {
                if (square.Piece.ValidMoves != null)
                {
                    if (square.Piece.ValidMoves.Count < 2)
                    {
                        score -= 5;
                    }
                }

                if (endGamePhase)
                {
                    score += KingTableEndGame[index];
                }
                else
                {
                    score += KingTable[index];
                }

                


            }

            return score;
        }

        internal static void EvaluateBoardScore(Board board)
        {
            //Black Score - 
            //White Score +
            board.Score = 0;

            bool insufficientMaterial = true;

            if (board.StaleMate)
            {
                return;
            }
            if (board.FiftyMove >= 50)
            {
                return;
            }
            if (board.RepeatedMove >= 3)
            {
                return;
            }
            if (board.BlackMate)
            {
                board.Score = 32767;
                return;
            }
            if (board.WhiteMate)
            {
                board.Score = -32767;
                return;
            }
            if (board.BlackCheck)
            {
                board.Score += 70;
                if (board.EndGamePhase)
                    board.Score += 10;
            }
            else if (board.WhiteCheck)
            {
                board.Score -= 70;
                if (board.EndGamePhase)
                    board.Score -= 10;
            }
            if (board.BlackCastled)
            {
                board.Score -= 50;
            }
            if (board.WhiteCastled)
            {
                board.Score += 50;
            }
            //Add a small bonus for tempo (turn)
            if (board.WhoseMove == ChessPieceColor.White)
            {
                board.Score += 10;
            }
            else
            {
                board.Score -= 10;
            }

            byte blackBishopCount = 0;
            byte whiteBishopCount = 0;

            byte blackKnightCount = 0;
            byte whiteKnightCount = 0;


            byte knightCount = 0;


            blackPawnCount = new short[8];
            whitePawnCount = new short[8];

            for (byte x = 0; x < 64; x++)
            {
                Square square = board.Squares[x];

                if (square.Piece == null)
                    continue;


                if (square.Piece.PieceColor == ChessPieceColor.White)
                {
                    board.Score += EvaluatePieceScore(square, x, board.EndGamePhase,
                        ref whiteKnightCount, ref whiteBishopCount, ref insufficientMaterial);

                    if (square.Piece.PieceType == ChessPieceType.King)
                    {
                        if (x != 59 && x != 60)
                        {
                            int pawnPos = x - 8;

                            board.Score += CheckPawnWall(board, pawnPos, x);

                            pawnPos = x - 7;

                            board.Score += CheckPawnWall(board, pawnPos, x);

                            pawnPos = x - 9;

                            board.Score += CheckPawnWall(board, pawnPos, x);
                        }
                    }
                }
                else if (square.Piece.PieceColor == ChessPieceColor.Black)
                {
                    board.Score -= EvaluatePieceScore(square, x, board.EndGamePhase,
                        ref blackKnightCount, ref blackBishopCount, ref insufficientMaterial);


                    if (square.Piece.PieceType == ChessPieceType.King)
                    {
                        if (x != 3 && x != 4)
                        {
                            int pawnPos = x + 8;

                            board.Score -= CheckPawnWall(board, pawnPos, x);

                            pawnPos = x + 7;

                            board.Score -= CheckPawnWall(board, pawnPos, x);

                            pawnPos = x + 9;

                            board.Score -= CheckPawnWall(board, pawnPos, x);
                        }

                    }
                   
                }

                if (square.Piece.PieceType == ChessPieceType.Knight)
                {
                    knightCount++;

                    if (knightCount > 1)
                    {
                        insufficientMaterial = false;
                    }
                }

                if ((blackBishopCount + whiteBishopCount) > 1)
                {
                    insufficientMaterial = false;
                }
                else if ((blackBishopCount + blackKnightCount) > 1)
                {
                    insufficientMaterial = false;
                }
                else if ((whiteBishopCount + whiteKnightCount) > 1)
                {
                    insufficientMaterial = false;
                }

            }

            if (insufficientMaterial)
            {
                board.Score = 0;
                board.StaleMate = true;
                board.InsufficientMaterial = true;
                return;
            }

            if (board.EndGamePhase)
            {
                if (board.BlackCheck)
                {
                    board.Score += 10;
                }
                else if (board.WhiteCheck)
                {
                    board.Score -= 10;
                }
            }
            else
            {
                if (!board.WhiteCanCastle && !board.WhiteCastled)
                {
                    board.Score -= 50;
                }
                if (!board.BlackCanCastle && !board.BlackCastled)
                {
                    board.Score += 50;
                }
            }

            //Black Isolated Pawns
            if (blackPawnCount[0] >= 1 && blackPawnCount[1] == 0)
            {
                board.Score += 12;
            }
            if (blackPawnCount[1] >= 1 && blackPawnCount[0] == 0 &&
                blackPawnCount[2] == 0)
            {
                board.Score += 14;
            }
            if (blackPawnCount[2] >= 1 && blackPawnCount[1] == 0 &&
                blackPawnCount[3] == 0)
            {
                board.Score += 16;
            }
            if (blackPawnCount[3] >= 1 && blackPawnCount[2] == 0 &&
                blackPawnCount[4] == 0)
            {
                board.Score += 20;
            }
            if (blackPawnCount[4] >= 1 && blackPawnCount[3] == 0 &&
                blackPawnCount[5] == 0)
            {
                board.Score += 20;
            }
            if (blackPawnCount[5] >= 1 && blackPawnCount[4] == 0 &&
                blackPawnCount[6] == 0)
            {
                board.Score += 16;
            }
            if (blackPawnCount[6] >= 1 && blackPawnCount[5] == 0 &&
                blackPawnCount[7] == 0)
            {
                board.Score += 14;
            }
            if (blackPawnCount[7] >= 1 && blackPawnCount[6] == 0)
            {
                board.Score += 12;
            }

            //White Isolated Pawns
            if (whitePawnCount[0] >= 1 && whitePawnCount[1] == 0)
            {
                board.Score -= 12;
            }
            if (whitePawnCount[1] >= 1 && whitePawnCount[0] == 0 &&
                whitePawnCount[2] == 0)
            {
                board.Score -= 14;
            }
            if (whitePawnCount[2] >= 1 && whitePawnCount[1] == 0 &&
                whitePawnCount[3] == 0)
            {
                board.Score -= 16;
            }
            if (whitePawnCount[3] >= 1 && whitePawnCount[2] == 0 &&
                whitePawnCount[4] == 0)
            {
                board.Score -= 20;
            }
            if (whitePawnCount[4] >= 1 && whitePawnCount[3] == 0 &&
                whitePawnCount[5] == 0)
            {
                board.Score -= 20;
            }
            if (whitePawnCount[5] >= 1 && whitePawnCount[4] == 0 &&
                whitePawnCount[6] == 0)
            {
                board.Score -= 16;
            }
            if (whitePawnCount[6] >= 1 && whitePawnCount[5] == 0 &&
                whitePawnCount[7] == 0)
            {
                board.Score -= 14;
            }
            if (whitePawnCount[7] >= 1 && whitePawnCount[6] == 0)
            {
                board.Score -= 12;
            }

            //Black Passed Pawns
            if (blackPawnCount[0] >= 1 && whitePawnCount[0] == 0)
            {
                board.Score -= blackPawnCount[0];
            }
            if (blackPawnCount[1] >= 1 && whitePawnCount[1] == 0)
            {
                board.Score -= blackPawnCount[1];
            }
            if (blackPawnCount[2] >= 1 && whitePawnCount[2] == 0)
            {
                board.Score -= blackPawnCount[2];
            }
            if (blackPawnCount[3] >= 1 && whitePawnCount[3] == 0)
            {
                board.Score -= blackPawnCount[3];
            }
            if (blackPawnCount[4] >= 1 && whitePawnCount[4] == 0)
            {
                board.Score -= blackPawnCount[4];
            }
            if (blackPawnCount[5] >= 1 && whitePawnCount[5] == 0)
            {
                board.Score -= blackPawnCount[5];
            }
            if (blackPawnCount[6] >= 1 && whitePawnCount[6] == 0)
            {
                board.Score -= blackPawnCount[6];
            }
            if (blackPawnCount[7] >= 1 && whitePawnCount[7] == 0)
            {
                board.Score -= blackPawnCount[7];
            }

            //White Passed Pawns
            if (whitePawnCount[0] >= 1 && blackPawnCount[1] == 0)
            {
                board.Score += whitePawnCount[0];
            }
            if (whitePawnCount[1] >= 1 && blackPawnCount[1] == 0)
            {
                board.Score += whitePawnCount[1];
            }
            if (whitePawnCount[2] >= 1 && blackPawnCount[2] == 0)
            {
                board.Score += whitePawnCount[2];
            }
            if (whitePawnCount[3] >= 1 && blackPawnCount[3] == 0)
            {
                board.Score += whitePawnCount[3];
            }
            if (whitePawnCount[4] >= 1 && blackPawnCount[4] == 0)
            {
                board.Score += whitePawnCount[4];
            }
            if (whitePawnCount[5] >= 1 && blackPawnCount[5] == 0)
            {
                board.Score += whitePawnCount[5];
            }
            if (whitePawnCount[6] >= 1 && blackPawnCount[6] == 0)
            {
                board.Score += whitePawnCount[6];
            }
            if (whitePawnCount[7] >= 1 && blackPawnCount[7] == 0)
            {
                board.Score += whitePawnCount[7];
            }
        }

        private static int CheckPawnWall(Board board, int pawnPos, int kingPos)
        {

            if (kingPos % 8 == 7 && pawnPos % 8 == 0)
            {
                return 0;
            }

            if (kingPos % 8 == 0 && pawnPos % 8 == 7)
            {
                return 0;
            }

            if (pawnPos > 63 || pawnPos < 0)
            {
                return 0;
            }

            if (board.Squares[pawnPos].Piece != null)
            {
                if (board.Squares[pawnPos].Piece.PieceColor == board.Squares[kingPos].Piece.PieceColor)
                {
                    if (board.Squares[pawnPos].Piece.PieceType == ChessPieceType.Pawn)
                    {
                        return 10;
                    }
                }
            }

            return 0;
        }
    }
}