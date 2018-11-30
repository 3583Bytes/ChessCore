using System;
using ChessEngine.Engine;

class Program
{

	static void Main(string[] args)
	{
		RunEngine();
	}

	private static void RunEngine()
	{
		bool ShowBoard = false;

		var engine = new Engine();



		Console.WriteLine("Chess Core");
		Console.WriteLine("Created by Adam Berent");
		Console.WriteLine("Version: 1.0.1");
		Console.WriteLine("");
		Console.WriteLine("Type quit to exit");
		Console.WriteLine("Type show to show board");
		Console.WriteLine("");
		Console.WriteLine("feature setboard=1");


		while (true)
		{
			try
			{
				if (ShowBoard)
				{
					DrawBoard(engine);
				}

				if (engine.WhoseMove != engine.HumanPlayer)
				{
					MakeEngineMove(engine);
				}
				else
				{
					Console.WriteLine();

					string move = Console.ReadLine();

					if (String.IsNullOrEmpty(move))
					{
						continue;
					}

					move = move.Trim();


					if (move == "new")
					{
						engine.NewGame();
						continue;
					}
					if (move == "quit")
					{
						return;
					}
					if (move == "xboard")
					{
						continue;
					}
					if (move == "show")
					{
						ShowBoard = !ShowBoard;

						continue;
					}
					if (move.StartsWith("edit"))
					{
						continue;
					}
					if (move == "hint")
					{
						continue;
					}
					if (move == "bk")
					{
						continue;
					}
					if (move == "undo")
					{
						engine.Undo();
						continue;
					}
					if (move == "remove")
					{
						continue;
					}
					if (move == "remove")
					{
						continue;
					}
					if (move == "hard")
					{
						engine.GameDifficulty = Engine.Difficulty.Hard;
						continue;
					}
					if (move == "easy")
					{
						continue;
					}
					if (move.StartsWith("accepted"))
					{
						continue;
					}
					if (move.StartsWith("rejected"))
					{
						continue;
					}
					if (move.StartsWith("variant"))
					{
						continue;
					}
					if (move == "random")
					{
						continue;
					}
					if (move == "force")
					{
						continue;
					}
					if (move == "go")
					{
						continue;
					}
					if (move == "playother")
					{
						if (engine.WhoseMove == ChessPieceColor.White)
						{
							engine.HumanPlayer = ChessPieceColor.Black;
						}
						else if (engine.WhoseMove == ChessPieceColor.Black)
						{
							engine.HumanPlayer = ChessPieceColor.White;
						}

						continue;
					}
					if (move == "white")
					{
						engine.HumanPlayer = ChessPieceColor.Black;

						if (engine.WhoseMove != engine.HumanPlayer)
						{
							MakeEngineMove(engine);
						}
						continue;
					}
					if (move == "black")
					{
						engine.HumanPlayer = ChessPieceColor.White;

						if (engine.WhoseMove != engine.HumanPlayer)
						{
							MakeEngineMove(engine);
						}
						continue;
					}

					if (move.StartsWith("level"))
					{
						continue;
					}
					if (move.StartsWith("st"))
					{
						continue;
					}
					if (move.StartsWith("sd"))
					{
						continue;
					}
					if (move.StartsWith("time"))
					{
						continue;
					}
					if (move.StartsWith("otim"))
					{
						continue;
					}
					if (move.StartsWith("otim"))
					{
						continue;
					}
					if (move == "?")
					{
						continue;
					}
					if (move.StartsWith("ping"))
					{
						if (move.IndexOf(" ") > 0)
						{
							string pong = move.Substring(move.IndexOf(" "), move.Length - move.IndexOf(" "));

							Console.WriteLine("pong " + pong);
						}
						continue;
					}

					if (move.StartsWith("result"))
					{
						continue;
					}

					if (move.StartsWith("setboard"))
					{
						if (move.IndexOf(" ") > 0)
						{
							string fen = move.Substring(move.IndexOf(" "), move.Length - move.IndexOf(" ")).Trim();

							engine.InitiateBoard(fen);
						}

						continue;
					}

					if (move.StartsWith("setboard"))
					{
						continue;
					}
					if (move.StartsWith("edit"))
					{
						engine.NewGame();
						continue;
					}
					if (move.StartsWith("1/2-1/2"))
					{
						engine.NewGame();
						continue;
					}
					if (move.StartsWith("0-1"))
					{
						engine.NewGame();
						continue;
					}
					if (move.StartsWith("1-0"))
					{
						engine.NewGame();
						continue;
					}

					if (move.Length < 4)
					{
						continue;
					}

					if (move.Length > 5)
					{
						continue;
					}

					string src = move.Substring(0, 2);
					string dst = move.Substring(2, 2);


					byte srcCol;
					byte srcRow;
					byte dstRow;
					byte dstCol;

					try
					{
						srcCol = GetColumn(src);
						srcRow = GetRow(src);
						dstRow = GetRow(dst);
						dstCol = GetColumn(dst);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						continue;
					}

					if (!engine.IsValidMove(srcCol, srcRow, dstCol, dstRow))
					{
						Console.WriteLine("Invalid Move");
						continue;
					}

					engine.MovePiece(srcCol, srcRow, dstCol, dstRow);

					MakeEngineMove(engine);
					    

					if (engine.StaleMate)
					{
						if (engine.InsufficientMaterial)
						{
							Console.WriteLine("1/2-1/2 {Draw by insufficient material}");
						}
						else if (engine.RepeatedMove)
						{
							Console.WriteLine("1/2-1/2 {Draw by repetition}");
						}
						else if (engine.FiftyMove)
						{
							Console.WriteLine("1/2-1/2 {Draw by fifty move rule}");
						}
						else
						{
							Console.WriteLine("1/2-1/2 {Stalemate}");
						}
						engine.NewGame();
					}
					else if (engine.GetWhiteMate())
					{
						Console.WriteLine("0-1 {Black mates}");
						engine.NewGame();
					}
					else if (engine.GetBlackMate())
					{
						Console.WriteLine("1-0 {White mates}");
						engine.NewGame();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}
	}

	private static void MakeEngineMove(Engine engine)
	{
		DateTime start = DateTime.Now;

		engine.AiPonderMove();

		MoveContent lastMove = engine.GetMoveHistory().ToArray()[0];

		string tmp = "";

		var sourceColumn = (byte)(lastMove.MovingPiecePrimary.SrcPosition % 8);
		var srcRow = (byte)(8 - (lastMove.MovingPiecePrimary.SrcPosition / 8));
		var destinationColumn = (byte)(lastMove.MovingPiecePrimary.DstPosition % 8);
		var destinationRow = (byte)(8 - (lastMove.MovingPiecePrimary.DstPosition / 8));

		tmp += GetPgnMove(lastMove.MovingPiecePrimary.PieceType);

		if (lastMove.MovingPiecePrimary.PieceType == ChessPieceType.Knight)
		{
			tmp += GetColumnFromInt(sourceColumn + 1);
			tmp += srcRow;
		}
		else if (lastMove.MovingPiecePrimary.PieceType == ChessPieceType.Rook)
		{
			tmp += GetColumnFromInt(sourceColumn + 1);
			tmp += srcRow;
		}
		else if (lastMove.MovingPiecePrimary.PieceType == ChessPieceType.Pawn)
		{
			if (sourceColumn != destinationColumn)
			{
				tmp += GetColumnFromInt(sourceColumn + 1);
			}
		}

		if (lastMove.TakenPiece.PieceType != ChessPieceType.None)
		{
			tmp += "x";
		}

		tmp += GetColumnFromInt(destinationColumn + 1);

		tmp += destinationRow;

		if (lastMove.PawnPromotedTo == ChessPieceType.Queen)
		{
			tmp += "=Q";
		}
		else if (lastMove.PawnPromotedTo == ChessPieceType.Rook)
		{
			tmp += "=R";
		}
		else if (lastMove.PawnPromotedTo == ChessPieceType.Knight)
		{
			tmp += "=K";
		}
		else if (lastMove.PawnPromotedTo == ChessPieceType.Bishop)
		{
			tmp += "=B";
		}

		DateTime end = DateTime.Now;

		TimeSpan ts = end - start;

		Console.Write(engine.PlyDepthReached + " ");

		int score = engine.GetScore();

		if (score > 0)
		{
			score = score / 10;
		}

		Console.Write(score + " ");
		Console.Write(ts.Seconds * 100 + " ");
		Console.Write(engine.NodesSearched + engine.NodesQuiessence + " ");
		Console.Write(engine.PvLine);
		Console.WriteLine();

		Console.Write("move ");
		Console.WriteLine(tmp);
	}

	public static string GetColumnFromInt(int column)
	{
		string returnColumnt;

		switch (column)
		{
			case 1:
				returnColumnt = "a";
				break;
			case 2:
				returnColumnt = "b";
				break;
			case 3:
				returnColumnt = "c";
				break;
			case 4:
				returnColumnt = "d";
				break;
			case 5:
				returnColumnt = "e";
				break;
			case 6:
				returnColumnt = "f";
				break;
			case 7:
				returnColumnt = "g";
				break;
			case 8:
				returnColumnt = "h";
				break;
			default:
				returnColumnt = "Unknown";
				break;
		}

		return returnColumnt;
	}

	private static string GetPgnMove(ChessPieceType pieceType)
	{
		string move = "";

		if (pieceType == ChessPieceType.Bishop)
		{
			move += "B";
		}
		else if (pieceType == ChessPieceType.King)
		{
			move += "K";
		}
		else if (pieceType == ChessPieceType.Knight)
		{
			move += "N";
		}
		else if (pieceType == ChessPieceType.Queen)
		{
			move += "Q";
		}
		else if (pieceType == ChessPieceType.Rook)
		{
			move += "R";
		}

		return move;
	}

	private static byte GetRow(string move)
	{
		if (move != null)
		{
			if (move.Length == 2)
			{
				return (byte)(8 - int.Parse(move.Substring(1, 1).ToLower()));
			}
		}

		return 255;
	}

	private static byte GetColumn(string move)
	{
		if (move != null)
		{
			if (move.Length == 2)
			{
				string col = move.Substring(0, 1).ToLower();

				switch (col)
				{
					case "a":
						{
							return 0;
						}
					case "b":
						{
							return 1;
						}
					case "c":
						{
							return 2;
						}
					case "d":
						{
							return 3;
						}
					case "e":
						{
							return 4;
						}
					case "f":
						{
							return 5;
						}
					case "g":
						{
							return 6;
						}
					case "h":
						{
							return 7;
						}
					default:
						return 255;
				}
			}
		}

		return 255;
	}

	private static void DrawBoard(Engine engine)
	{
		//Console.Clear();

		for (byte i = 0; i < 64; i++)
		{
			if (i % 8 == 0)
			{
				Console.WriteLine();
				Console.WriteLine(" ---------------------------------");
				Console.Write((8 - (i / 8)));
			}

			ChessPieceType PieceType = engine.GetPieceTypeAt(i);
			ChessPieceColor PieceColor = engine.GetPieceColorAt(i);
			string str;

			switch (PieceType)
			{
				case ChessPieceType.Pawn:
					{
						str = "| " + "P ";
						break;
					}
				case ChessPieceType.Knight:
					{
						str = "| " + "N ";
						break;
					}
				case ChessPieceType.Bishop:
					{
						str = "| " + "B ";
						break;
					}
				case ChessPieceType.Rook:
					{
						str = "| " + "R ";
						break;
					}

				case ChessPieceType.Queen:
					{
						str = "| " + "Q ";
						break;
					}

				case ChessPieceType.King:
					{
						str = "| " + "K ";
						break;
					}
				default:
					{
						str = "| " + "  ";
						break;
					}
			}

			if (PieceColor == ChessPieceColor.Black)
			{
				str = str.ToLower();
			}

			Console.Write(str);

			if (i % 8 == 7)
			{
				Console.Write("|");
			}
		}

		Console.WriteLine();
		Console.WriteLine(" ---------------------------------");
		Console.WriteLine("   A   B   C   D   E   F   G   H");

	}
}
