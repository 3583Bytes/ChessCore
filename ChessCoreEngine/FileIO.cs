using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
//using ChessEngine.XML;

namespace ChessEngine.Engine
{
    internal static class FileIO
    {
        internal static void SaveCurrentGameMove(Board currentBoard, Board previousBoard, ICollection<OpeningMove> gameBook, MoveContent bestMove)
        {
            try
            {
                var move = new OpeningMove();

                move.StartingFEN = Board.Fen(true, previousBoard);
                move.EndingFEN = Board.Fen(true, currentBoard);
                move.Moves.Add(bestMove);

                gameBook.Add(move);

                foreach (OpeningMove move1 in gameBook)
                {
                    byte repeatedMoves = 0;

                    foreach (OpeningMove move2 in gameBook)
                    {
                        if (move1.EndingFEN == move2.EndingFEN)
                        {
                            repeatedMoves++;
                        }
                    }

                    if (previousBoard.RepeatedMove < repeatedMoves)
                    {
                        previousBoard.RepeatedMove = repeatedMoves;
                        currentBoard.RepeatedMove = repeatedMoves;
                    }
                }
                if (currentBoard.RepeatedMove >= 3)
                {
                    currentBoard.StaleMate = true;
                }
            }
            catch (Exception)
            {
                return;
            }

            return;
        }

        internal static bool SaveGame(String filePath, Board chessBoard, ChessPieceColor whoseMove, Stack<MoveContent> moveHistory)
        {
            if (String.IsNullOrEmpty(filePath))
                return false;

           /* var serializer = new XmlSerializer(typeof(XMLBoard));
            TextWriter writer = new StreamWriter(filePath);

            var xmlBoard = new XMLBoard();
            xmlBoard.Squares = new List<XMLBoard.XMLSquare>();
            xmlBoard.MoveHistory = new List<MoveContent>();

            xmlBoard.WhoseMove = whoseMove;
            xmlBoard.FiftyMoveCount = chessBoard.FiftyMove;

            for (byte x = 0; x < 64; x++)
            {
                var square = new XMLBoard.XMLSquare();

                if (chessBoard.Squares[x].Piece != null)
                {
                    square.CurrentPiece = new XMLBoard.XMLChessPiece();
                    square.CurrentPiece.Moved = chessBoard.Squares[x].Piece.Moved;
                    square.CurrentPiece.PieceColor = chessBoard.Squares[x].Piece.PieceColor;
                    square.CurrentPiece.PieceType = chessBoard.Squares[x].Piece.PieceType;
                    square.BoardColumn = (byte)(x % 8);
                    square.BoardRow = (byte)(x / 8);
                }

                xmlBoard.Squares.Add(square);
            }
            foreach (MoveContent move in moveHistory)
            {
                xmlBoard.MoveHistory.Add(move);
            }

            serializer.Serialize(writer, xmlBoard);
            writer.Close();*/

            return true;
        }

        internal static bool LoadGame(String filePath, ref Board chessBoard, ChessPieceColor whoseMove, ref Stack<MoveContent> moveHistory, ref List<OpeningMove> currentGameBook, ref List<OpeningMove> undoGameBook)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                return false;
            }

           /* chessBoard = new Board();
            moveHistory = new Stack<MoveContent>();

            currentGameBook = new List<OpeningMove>();
            undoGameBook = new List<OpeningMove>();

            for (byte x = 0; x < 64; x++)
            {
                var square = new Square();
                square.Piece = null;
                chessBoard.Squares[x] = square;
            }


            var serializer = new XmlSerializer(typeof(XMLBoard));
            TextReader reader = new StreamReader(filePath);

            var xmlBoard = (XMLBoard)serializer.Deserialize(reader);
            reader.Close();

            foreach (XMLBoard.XMLSquare square in xmlBoard.Squares)
            {
                if (square.CurrentPiece != null)
                {
                    RegisterPiece(square.BoardColumn, square.BoardRow, square.CurrentPiece, chessBoard);
                }
            }

            chessBoard.WhoseMove = xmlBoard.WhoseMove;
            chessBoard.FiftyMove = xmlBoard.FiftyMoveCount;

            chessBoard.ZobristHash = Zobrist.CalculateZobristHash(chessBoard);         

            foreach (MoveContent move in xmlBoard.MoveHistory)
            {
                moveHistory.Push(move);
            }

            PieceValidMoves.GenerateValidMoves(chessBoard);
            Evaluation.EvaluateBoardScore(chessBoard);*/

            return true;
        }      

        public static bool LoadOpeningBook(ref List<OpeningMove> openingBook)
        {
           /* if (File.Exists("OpeningBook\\OpeningBook.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<OpeningMove>));
                TextReader reader =
                    new StreamReader("OpeningBook\\OpeningBook.xml");

                openingBook = (List<OpeningMove>)serializer.Deserialize(reader);
                reader.Close();
            }

            List<OpeningMove> newOpeningBook = new List<OpeningMove>();

            //Delete Duplicates
            foreach (OpeningMove mv1 in openingBook)
            {
                bool duplicate = false;
                foreach (OpeningMove mv2 in newOpeningBook)
                {
                    if (mv1.StartingFEN == mv2.StartingFEN)
                    {
                        if (mv1.EndingFEN == mv2.EndingFEN)
                        {
                            duplicate = true;
                        }
                    }
                }
                if (duplicate == false)
                {
                    newOpeningBook.Add(mv1);
                }
            }

            openingBook = newOpeningBook; */

            return true;
        }
		/* 
        private static void RegisterPiece(byte boardColumn, byte boardRow, XMLBoard.XMLChessPiece piece, Board chessBoard)
        {
          byte position = (byte)(boardColumn + (boardRow * 8));
            chessBoard.Squares[position].Piece = new Piece(piece.PieceType, piece.PieceColor);
            chessBoard.Squares[position].Piece.Moved = piece.Moved;
			
            return;
        }*/
    }
}
