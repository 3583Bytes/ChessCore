using System;
using System.Collections.Generic;

namespace ChessEngine.Engine
{
    public class Test
    {
        private static ResultBoards resultBoards = new ResultBoards { Positions = new List<Board>(30) };

        private static ChessPieceColor GetOppositeColor(ChessPieceColor color)
        {
            return color == ChessPieceColor.Black ? ChessPieceColor.White : ChessPieceColor.Black;
        }

        private static int SideToMoveScore(int score, ChessPieceColor color)
        {
            if (color == ChessPieceColor.Black)
                return -score;

            return score;
        }

        internal static PerformanceResult RunPerfTest(int depth, Board board)
        {
            var performanceResult = new PerformanceResult();

            DateTime startTime = DateTime.Now;

            performanceResult.Nodes = Performance(depth, board, ChessPieceColor.White);
            performanceResult.TimeSpan = (DateTime.Now - startTime);
            performanceResult.Depth = depth;

            return performanceResult;
        }

        private static long Performance(int depth, Board board, ChessPieceColor color)
        {
            long nodes = 0;

            if (depth == 0) return 1;

            ResultBoards moveList = GetPossibleBoards(GetOppositeColor(color), board);

            for (int i = 0; i < moveList.Positions.Count; i++)
            {
                nodes += Performance(depth - 1, moveList.Positions[i], GetOppositeColor(color));
            }

            return nodes;
        }

        private static ResultBoards GetPossibleBoards(ChessPieceColor movingSide, Board examineBoard)
        {
            //We are going to store our result boards here           
            resultBoards = new ResultBoards
            {
                Positions = new List<Board>()
            };

            for (byte x = 0; x < 64; x++)
            {
                Square sqr = examineBoard.Squares[x];

                //Make sure there is a piece on the square
                if (sqr.Piece == null)
                    continue;

                //Make sure the color is the same color as the one we are moving.
                if (sqr.Piece.PieceColor != movingSide)
                    continue;

                //For each valid move for this piece
                foreach (byte dst in sqr.Piece.ValidMoves)
                {
                    //We make copies of the board and move so that we can move it without effecting the parent board
                    Board board = examineBoard.FastCopy();

                    //Make move so we can examine it
                    Board.MovePiece(board, x, dst, ChessPieceType.Queen);

                    //We Generate Valid Moves for Board
                    PieceValidMoves.GenerateValidMoves(board);

                    
                    if (board.BlackCheck && movingSide == ChessPieceColor.Black)
                    {
                        continue;
                    }

                    if (board.WhiteCheck && movingSide == ChessPieceColor.White)
                    {
                        continue;
                    } 

                    //We calculate the board score
                    Evaluation.EvaluateBoardScore(board);

                    //Invert Score to support Negamax
                    board.Score = SideToMoveScore(board.Score, GetOppositeColor(movingSide));

                    resultBoards.Positions.Add(board);
                }
            }

            return resultBoards;
        }

        #region Nested type: PerformanceResult

        public struct PerformanceResult
        {
            public int Depth;
            public long Nodes;
            public TimeSpan TimeSpan;
        }

        #endregion
    }
}