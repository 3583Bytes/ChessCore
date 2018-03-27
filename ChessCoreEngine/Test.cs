using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ChessEngine.Engine
{
	public class CorrectnessTest
	{
		public void RunAllCorrectnessTests()
		{
			TestBlankBoard();
			TestStandardBoardShortFEN();
			TestStandardBoardFullFEN();
			TestNotation();
			TestValidMoves();
			TestSimpleMoves();
			TestAI();
		}
		
		[Test]
		public void TestBlankBoard()
		{
			var board = new Board();
			var fen = Board.Fen(false, board);
			Assert.AreEqual("8/8/8/8/8/8/8/8/ w - 0 0", fen);
		}

		[Test]
		public void TestStandardBoardShortFEN()
		{
			var standardFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w -";
			var board = new Board(standardFen);
			var fen = Board.Fen(true, board);
			Assert.AreEqual(standardFen, fen);
		}

		[Test]
		public void TestStandardBoardFullFEN()
		{
			var standardFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
			var board = new Board(standardFen);
			var fen = Board.Fen(false, board);
			Assert.AreEqual(standardFen, fen);
		}
		
		[Test]
		public void TestBoardOrientation()
		{
			var standardFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
			var board = new Board(standardFen);

			// 0,0 is a8
			// 7,7 is h1

			// is the board oriented the way we expect?
			var piece = board.Squares[0].Piece;
			Assert.AreEqual(ChessPieceColor.Black, piece.PieceColor);
			Assert.AreEqual(ChessPieceType.Rook, piece.PieceType);

			piece = board.Squares[3].Piece;
			Assert.AreEqual(ChessPieceColor.Black, piece.PieceColor);
			Assert.AreEqual(ChessPieceType.Queen, piece.PieceType);

			piece = board.Squares[63].Piece;
			Assert.AreEqual(ChessPieceColor.White, piece.PieceColor);
			Assert.AreEqual(ChessPieceType.Rook, piece.PieceType);

			piece = board.Squares[59].Piece;
			Assert.AreEqual(ChessPieceColor.White, piece.PieceColor);
			Assert.AreEqual(ChessPieceType.Queen, piece.PieceType);
		}
		
		[Test]
		public void TestNotation()
		{
			byte sourceColumn=0, sourceRow=0, destinationColumn=0, destinationRow=0;

			Assert.IsFalse(MoveContent.ParseAN("toolong", ref sourceColumn, ref sourceRow, ref destinationColumn, ref destinationRow));
			Assert.IsFalse(MoveContent.ParseAN("abc", ref sourceColumn, ref sourceRow, ref destinationColumn, ref destinationRow));

			Assert.IsTrue(MoveContent.ParseAN("a8h1", ref sourceColumn, ref sourceRow, ref destinationColumn, ref destinationRow));
			Assert.AreEqual(sourceColumn, 0);
			Assert.AreEqual(sourceRow, 0);
			Assert.AreEqual(destinationColumn, 7);
			Assert.AreEqual(destinationRow, 7);

			Assert.IsTrue(MoveContent.ParseAN("b3e4", ref sourceColumn, ref sourceRow, ref destinationColumn, ref destinationRow));
			Assert.AreEqual(sourceColumn, 1);
			Assert.AreEqual(sourceRow, 5);
			Assert.AreEqual(destinationColumn, 4);
			Assert.AreEqual(destinationRow, 4);
		}

		[Test]
		public void TestValidMoves()
		{
			var engine = new Engine("rnbqkbnr/ppppppp1/8/8/8/8/8/8 w KQkq - 0 1");
			
			// rook
			Assert.IsFalse(engine.IsValidMove(0,0,7,7));
			Assert.IsFalse(engine.IsValidMove(0,0,0,1));
			Assert.IsFalse(engine.IsValidMoveAN("a8g1"));
			Assert.IsFalse(engine.IsValidMoveAN("a8a7"));
			
			// pawn
			Assert.IsTrue(engine.IsValidMove(0,1,0,2));
			Assert.IsTrue(engine.IsValidMove(0,1,0,3));
			Assert.IsFalse(engine.IsValidMove(0,1,0,4));
			Assert.IsTrue(engine.IsValidMoveAN("a7a6"));
			Assert.IsTrue(engine.IsValidMoveAN("a7a5"));
			Assert.IsFalse(engine.IsValidMoveAN("a7a4"));
			
			// knight
			Assert.IsTrue(engine.IsValidMove(1,0,0,2));
			Assert.IsTrue(engine.IsValidMove(1,0,2,2));
			Assert.IsFalse(engine.IsValidMove(1,0,3,1));
			Assert.IsTrue(engine.IsValidMoveAN("b8a6"));
			Assert.IsTrue(engine.IsValidMoveAN("b8c6"));
			Assert.IsFalse(engine.IsValidMoveAN("b8d7"));

			// rook2
			Assert.IsTrue(engine.IsValidMove(7,0,7,1));
			Assert.IsTrue(engine.IsValidMove(7,0,7,7));
			Assert.IsFalse(engine.IsValidMove(7,0,6,7));
			Assert.IsTrue(engine.IsValidMoveAN("h8h7"));
			Assert.IsTrue(engine.IsValidMoveAN("h8h1"));
			Assert.IsFalse(engine.IsValidMoveAN("h8g1"));
		}
		
		[Test]
		public void TestSimpleMoves()
		{
			var standardFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
			var engine = new Engine(standardFen);
			
			engine.MovePieceAN("e2e4");
			Assert.AreEqual("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1", engine.FEN);

			engine.MovePieceAN("c7c5");
			Assert.AreEqual("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2", engine.FEN);

			engine.MovePieceAN("g1f3");
			Assert.AreEqual("rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 1 2", engine.FEN);
		}
		
		[Test]
		public void TestAI()
		{
			// set up a simple scenario with an obvious checkmate in 1 move
			var engine = new Engine("k7/7R/6R1/8/8/8/8/K7 w - - 0 1");
			engine.GameDifficulty = Engine.Difficulty.Easy;
			engine.AiPonderMove();
			MoveContent lastMove = engine.GetMoveHistory().ToArray()[0];
			string move = lastMove.GetPureCoordinateNotation();
			// did the AI find the checkmate?
			Assert.AreEqual("g6g8", move);
		}
	}
	
    public class PerformanceTest
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