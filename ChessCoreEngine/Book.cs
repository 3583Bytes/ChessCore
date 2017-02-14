using System;
using System.Collections.Generic;
using System.IO;

namespace ChessEngine.Engine
{
    internal class Book
    {
        public static List<OpeningMove> LoadOpeningBook()
		{
			return PopulateOpeningBook();
        }

        internal static List<OpeningMove> PopulateOpeningBook()
        {
            List<OpeningMove> openingBook = new List<OpeningMove>();
            string moveLine;
            OpeningMove openingMove;
            string[] moves;

            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -";
            moveLine = @"e2e4{3820} b2b3{15} c2c4{540} d2d4{2619} g1f3{851} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/5P2/5N2/PPPPP1PP/RNBQKB1R b KQkq -";
            moveLine = @"g7g6";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }

            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/8/1P6/P1PPPPPP/RNBQKBNR w KQkq d6";
            moveLine = @"c1b2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6";
            moveLine = @"g1f3{1517} c2c3{25} b1c3{82} g1e2{5} d2d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/8/5N2/PPPPPPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{310} c7c5{88} d7d5{87} d7d6{5} g7g6{21} b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3";
            moveLine = @"g8f6{1544} d7d5{506} e7e6{41} f7f5{30} d7d6{10} g7g6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3";
            moveLine = @"c7c5{1283} g8f6{10} e7e5{690} c7c6{248} e7e6{150} d7d6{20} g7g6{15} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/2P5/8/PP1PPPPP/RNBQKBNR b KQkq c3";
            moveLine = @"g7g6{44} c7c5{45} g8f6{107} e7e5{121} e7e6{31} f7f5{5} c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6";
            moveLine = @"g1f3{1166} f1c4{21} f2f4{10} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/8/1P6/P1PPPPPP/RNBQKBNR w KQkq e6";
            moveLine = @"c1b2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
            moveLine = @"g7g6{549} e7e6{657} c7c5{47} b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/2p5/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{347} b1c3{5} c2c4{5} d2d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
            moveLine = @"c7c5{5} f8g7{23}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{767} f1b5{26} f1c4{5} c2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{378} d2d3{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3d4{726} d1d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{325} f1b5{36} b1c3{26} c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{211} f8g7{227}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/3p1n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{716}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3d4{320}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{282} b1c3{10} c2c4{5} c2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3d4{272}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g4{40} f1e2{11} c1e3{17} f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{20} b8c6{10} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3e5{219} d2d4{67} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p1p1ppp/p3p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{65} b1c3{22} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"f8g7{78}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6";
            moveLine = @"b1d2{80} b1c3{252} e4e5{30} e4d5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
            moveLine = @"c2c4{1593} g1f3{175} c1g5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"f8b4{276} c7c5{5} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/8/5NP1/PPPPPP1P/RNBQKB1R b KQkq -";
            moveLine = @"b7b5{5} d7d5{20} g7g6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{167} c1g5{56} c1e3{276} f2f4{21} f1c4{20} g2g3{5} f2f3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/2P5/8/PP1PPPPP/RNBQKBNR w KQkq c6";
            moveLine = @"g1f3{77} b1c3{10} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/3p4/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{107}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq e6";
            moveLine = @"d4b3{56}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
            moveLine = @"b8c6{480} g8f6{180}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1b5{739} f1c4{46} d2d4{70} b1c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{574} b1c3{314} g2g3{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{190}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{142} d7d6{664} b8c6{334}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1ppp1ppp/p1n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"b5a4{579} b5c6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2bppp/3ppn2/8/3NP1P1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
            moveLine = @"g4g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6";
            moveLine = @"c2c4{649} g1f3{63}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2pp4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq c6";
            moveLine = @"e4d5{30} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/6P1/PPPP1P1P/RNBQKBNR b KQkq -";
            moveLine = @"g7g6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/2P5/8/PP1PPPPP/RNBQKBNR w KQkq e6";
            moveLine = @"b1c3{73} g2g3{41}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6";
            moveLine = @"b1c3{71} b1d2{154} e4d5{36} e4e5{76} f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/5P2/8/PPPPP1PP/RNBQKBNR b KQkq f3";
            moveLine = @"d7d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n2n2/4p3/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq e6";
            moveLine = @"d4b5{83}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{28} b1c3{72} d2d4{10} g2g3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{5} c1e3{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{5} c1g5{91} c1e3{5} g2g3{15} f2f3{20} f1c4{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d5{11} b8c6{10} e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{69}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/p1pppppp/1p6/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{82} d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"a7a6{6} b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
            moveLine = @"c5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/2p5/8/2P1P3/8/PP1P1PPP/RNBQKBNR b KQkq c3";
            moveLine = @"d7d5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/8/3Pp3/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"d2e4{144}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/3p1n2/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/p1pp1ppp/1p2p3/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
            moveLine = @"e8g8{50} c7c5{30} b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{123} g2g3{11} d2d4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"c4d5{6} g1f3{151} b1c3{166}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq d6";
            moveLine = @"d2d4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4g3{5} e4f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{538} d2d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/6B1/3P4/8/PPP1PPPP/RN1QKBNR b KQkq -";
            moveLine = @"d7d6{6} e7e6{21} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq d6";
            moveLine = @"b1c3{156} c1g5{5} e2e3{5} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/3p1n2/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{71} f2f3{16} f1d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"e5d4{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"b7b6{216} d7d5{80} c7c5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
            moveLine = @"e7e5{35} c7c5{17} e7e6{5} g7g6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{37} b1c3{104} d2d4{10} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{46} g2g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{60} f2f4{26} a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e3{10} g2g3{262} b1c3{38} a2a3{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"a7a6{330} f8c5{5} c6d4{5} g8f6{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p5/5b2/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4g3{70} e4c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{46} e2e3{15} d2d4{26} e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{444} g1f3{50} g2g3{71}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3pp1/3ppn1p/8/3NP1P1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
            moveLine = @"h2h4{15} h1g1{5} h2h3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1d2{16} c1d2{37}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/2p5/8/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1pppbppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"f1e1{326} d1e2{15} a4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/2p5/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
            moveLine = @"d7d5{206}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{32} b1c3{136}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PPP3/2N5/PP3PPP/R1BQKBNR b KQkq e3";
            moveLine = @"d7d6{221}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/3p1np1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f2f4{5} g1f3{15} g2g3{10} c1e3{26} f1e2{5} c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{55} d7d6{5} b8c6{21} f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP4PP/R1BQKBNR b KQkq -";
            moveLine = @"e8g8{104}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{484} g2g3{10} d2d4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq d6";
            moveLine = @"d2d4{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/8/5N2/PPPPPPPP/RNBQKB1R w KQkq d6";
            moveLine = @"c2c4{15} d2d4{200} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e3{5} b1c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{216} e2e3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4N3/4P3/8/PPPP1PPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d6{140}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1ppp1p1p/p1n3p1/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"d2d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq c3";
            moveLine = @"g8f6{22} b8c6{36} g7g6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n1p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"d4b5{15} b1c3{116} f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{110}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p1n2/4N3/4P3/8/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"e5f3{204} e5f7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n5/4p3/B3n3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"d2d4{76}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2pp1ppp/p1n5/1p2p3/B2Pn3/5N2/PPP2PPP/RNBQ1RK1 w kq b6";
            moveLine = @"a4b3{66}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPPP2/2N5/PP4PP/R1BQKBNR b KQkq f3";
            moveLine = @"e8g8{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
            moveLine = @"c4d5{146} c1f4{10} g1f3{96} c1g5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p3b1/8/3P4/6N1/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"h2h4{50} g1f3{5} g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/2p5/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1c4{25} e4g5{64} g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1ppp1ppp/p1n5/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"g8f6{310}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p4/8/4n3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{184} b1c3{5} f1d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2ppbppp/p1n2n2/1p2p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 w kq b6";
            moveLine = @"a4b3{311}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
            moveLine = @"c8a6{121} c8b7{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR b KQkq -";
            moveLine = @"f8g7{26} c7c6{20} c7c5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/4P3/8/PPPP1PPP/RNBQKBNR w KQkq d6";
            moveLine = @"e4d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/3p1n2/8/3pP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f3d4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 w - -";
            moveLine = @"c1e3{20} g1h1{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/8/3p4/3Pn3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{174}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pp1p/3p2p1/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2B1P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"f8c5{20} g8f6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2pp4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq c6";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/ppp1pppp/8/3q4/8/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR b KQ -";
            moveLine = @"a7a6{11} e7e5{51} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p1n2/8/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
            moveLine = @"f6e4{125}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq c6";
            moveLine = @"b1c3{70} g2g3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2ppp1/2p3bp/8/3P3P/6N1/PPP2PP1/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/3P1N2/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"b8c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkbnr/pp1nppp1/2p3bp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"h4h5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq c3";
            moveLine = @"b7b6{30} c7c5{36} g7g6{119} e7e6{75} c7c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/1P3NP1/P3PP1P/RNBQKB1R b KQkq -";
            moveLine = @"f8b4{60} a6b7{20} b6b5{5} d7d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2pp4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq c6";
            moveLine = @"c4d5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{142} d2d4{5} g2g3{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2p1bppp/p1np1n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 w kq -";
            moveLine = @"c2c3{168}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{71} g7g6{111} c7c6{6} d7d5{31} c7c5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{15} f8c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
            moveLine = @"b2b3{196} d1a4{10} b1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppppppp/2n5/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/2p2p2/8/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/2PP4/5N2/PP1bPPPP/RN1QKB1R w KQkq -";
            moveLine = @"d1d2{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{138} d1c2{10} c4d5{5} c1f4{41} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{6} g8f6{16} c7c6{5} e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/1p2bppp/p2pbn2/4p3/4P3/1NN1B3/PPP1BPPP/R2Q1RK1 w - -";
            moveLine = @"d1d2{10} c3d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p4/8/3Pn3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"d6d5{105}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
            moveLine = @"e7e6{96} c7c6{247} d5c4{85} b8c6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"f8e7{66} c7c5{5} c7c6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{66}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{27} d1c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"c7c6{21} d5c4{10} b8d7{25} f8e7{42}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/2p1p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e4{5} e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
            moveLine = @"d2d4{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{65} c4d5{40} c1f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"f8e7{185} f6e4{35} b7b5{35} f8c5{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{76}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQ -";
            moveLine = @"e2e3{37} d1c2{5} c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pn2/8/1bPP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
            moveLine = @"c1d2{60}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{47} e2e3{66} d1c2{167} c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"c5d4{605} g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bpp1/4pn1p/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"g5f6{30} g5h4{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1pppbppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 b kq -";
            moveLine = @"b7b5{175}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/4p3/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{46}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{5} c7c5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"h7h6{41} e8g8{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 b kq -";
            moveLine = @"d7d6{100} e8g8{70}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{589}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"c5d4{110}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"b8c6{46} g8f6{48} a7a6{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4p3/8/1bPPn3/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/8/3p4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"c1f4{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bpp1/4pB1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"e7f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/3p1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"a7a6{464} b8c6{75} g7g6{40} e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 b kq -";
            moveLine = @"e8g8{95}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pn2/6B1/1bPP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2PP4/8/PP2PPPP/RNBQKBNR w KQkq c6";
            moveLine = @"d4d5{36} g1f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"g2g3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1p1p/2n3p1/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"c2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1pp1/1p2pn1p/6B1/1bPP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"g5h4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2p1ppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/3P4/2N5/PPP1PPPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1pp1ppp/bp2pn2/8/1bPP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
            moveLine = @"c1d2{100}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{31} c8b7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/4p3/3P4/3P4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"e6d5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq c6";
            moveLine = @"g2g3{27}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq c6";
            moveLine = @"d4d5{51} e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/3p4/8/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
            moveLine = @"c7c6{10} e7e6{5} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/Q1PP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"c8d7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppnbppp/4pn2/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"d1c2{6} a1c1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{16} g2g3{11} e2e4{10} c2c4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"e7e6{57}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/8/3Pp3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"c3e4{60}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq c6";
            moveLine = @"c2c4{5} d4d5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pppppp/1p3n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"g2g3{55} d2d4{5} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq d6";
            moveLine = @"f1g2{25} g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
            moveLine = @"c1d2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p1n2/8/4P3/3N4/PPPP1PPP/RNBQKB1R b KQkq -";
            moveLine = @"f6e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{141}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{95}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N2NP1/PP2PP1P/R1BQKB1R b KQkq -";
            moveLine = @"b8c6{5} c5d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/8/1bPp4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
            moveLine = @"f3d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"b8c6{65} f8e7{15} f8d6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/8/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR b KQkq -";
            moveLine = @"c7c6{5} g8f6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/5n2/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2pp1/4pb1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3p4/2PP1B2/2N5/PP2PPPP/R2QKBNR b KQkq -";
            moveLine = @"f8g7{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2pp1/4pb1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"f8g7{44}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 w - -";
            moveLine = @"h2h3{163}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{72}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1b3{71} c4d5{10} c1f4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/6B1/1bPP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"c8b7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/8/2pP4/1QN2N2/PP2PPPP/R1B1KB1R w KQkq -";
            moveLine = @"b3c4{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1pp1ppp/bp2pn2/8/1bPP4/1P3NP1/P2BPP1P/RN1QKB1R b KQkq -";
            moveLine = @"b4e7{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pp1/4pb1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"a1c1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pppppp/1p3n2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{15} e7e6{5} c8b7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq c6";
            moveLine = @"d2b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq e6";
            moveLine = @"f1b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e4{177}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n1pn2/2p5/2P5/2N1PN2/PP1P1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1P3NP1/P2BPP1P/RN1QKB1R w KQkq -";
            moveLine = @"b1c3{25} f1g2{65}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3P4/2P5/8/PP1P1PPP/RNBQKBNR b KQkq -";
            moveLine = @"c6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2pP4/2P5/8/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"e7e6{10} b7b5{31}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p1p1ppp/p3pn2/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
            moveLine = @"b7b6{16} c7c5{30} f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"c4d5{26} g1f3{5} c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp2pp1/p3pb1p/3p4/2PP4/2N1PN2/PP3PPP/2RQKB1R w K -";
            moveLine = @"a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp2pp/4p3/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR w KQkq f6";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"b8c6{70}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppn1ppp/4p3/3pP3/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{5} b8c6{5} d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
            moveLine = @"g1f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppbppp/4pn2/8/2PP4/6P1/PP1BPP1P/RN1QKBNR w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{67} c1g5{5} g2g3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq a6";
            moveLine = @"e1g1{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp2pp/4p3/5p2/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq f6";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"e7e6{56} e7e5{41} f6g4{79} b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"c8d7{11} b8d7{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/3p4/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1p1bppp/bp2pn2/3p4/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq d6";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1p1bppp/bp2p3/3n4/3P4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq -";
            moveLine = @"c3d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/p1ppbppp/bp2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQ -";
            moveLine = @"e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{30} g7g6{5} c6d4{5} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppp1p/2p2np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{20} b1c3{5} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq e6";
            moveLine = @"g1f3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/3n4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e4{135}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3P4/3P4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"f6d5{107}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/3p4/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"g2g3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/3n4/3PP3/2N5/PP3PPP/R1BQKBNR b KQkq e3";
            moveLine = @"d5c3{96}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/8/3PP3/2P5/P4PPP/R1BQKBNR b KQkq -";
            moveLine = @"f8g7{86}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"d5c4{62}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQK2R b KQkq -";
            moveLine = @"e8g8{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq d3";
            moveLine = @"f8e7{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"e8g8{57}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/2pp4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B2PP3/5N2/PPP2PPP/RNBQK2R b KQkq d3";
            moveLine = @"e5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/5n2/2pp4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c4d5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{56}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d6{33} b8c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{5} b7b5{33}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppppppbp/6p1/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{30} c2c4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR b KQkq -";
            moveLine = @"g8f6{20} d7d6{5} b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{15} g1f3{5} e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/pp1ppppp/1qn5/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"d4b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/2p2n2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{5} b1c3{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQ -";
            moveLine = @"a2a3{90} e2e4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1Q1RK1 w - -";
            moveLine = @"d1c2{40} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"c8b7{20} c8a6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
            moveLine = @"e7e6{6} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{40} g2g3{62}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/2PP4/P1b5/1PQ1PPPP/R1B1KBNR w KQ -";
            moveLine = @"c2c3{85}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{71} f2f3{81} h2h3{5} f1e2{15} g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{42}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
            moveLine = @"e8g8{95} c7c5{15} d7d5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppppp1pp/8/5p2/3P4/8/PPP1PPPP/RNBQKBNR w KQkq f6";
            moveLine = @"g2g3{30} c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpppppp/1p3n2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{25} d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2n2n2/3pp3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{87} g2g3{5} d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2P2/PP2P1PP/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/8/3NPP2/2N5/PPP3PP/R1BQKB1R b KQkq f3";
            moveLine = @"a7a6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/3P4/4PN2/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{5} b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/6P1/PP1BPP1P/RN1QKBNR w KQkq c6";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/4pn2/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2p2ppp/p1n5/1p1pp3/3Pn3/1B3N2/PPP2PPP/RNBQ1RK1 w kq d6";
            moveLine = @"d4e5{56}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/8/5NP1/PPPPPPBP/RNBQ1RK1 b kq -";
            moveLine = @"c8f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"a2a4{106}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/8/3PP3/2n5/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"b2c3{125}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{91} e2e3{70}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/3ppn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR w KQ -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/6P1/PP2PP1P/RNBQKBNR b KQkq -";
            moveLine = @"d7d5{45} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/2PP4/5N2/PP1QPPPP/RN2KB1R w KQ -";
            moveLine = @"g2g3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pb1p1ppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq d6";
            moveLine = @"a2a3{6} c4d5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/2pp4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq c6";
            moveLine = @"c2c4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2pppp/2p2n2/5b2/P1pP4/2N2N2/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"f3e5{72} e2e3{28}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppbppp/1p2pn2/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
            moveLine = @"b1c3{35} e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/2p1pn2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"f2f3{46}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/P1N2N2/1P2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/5n2/3p4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"c1g5{37}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/8/2pP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"e2e4{65} g1f3{46} e2e3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
            moveLine = @"c4d5{23}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e4{12} g1f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3pP3/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"c8f5{45} c6c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP1B2/2N1P3/PP3PPP/R2QKBNR b KQkq -";
            moveLine = @"c7c5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/3P4/2N2N2/PPP1PPPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/8/2pPP3/8/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"e4e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/8/3nP3/2pP4/8/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/2p5/8/4P3/3P4/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"e7e5{5} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p2n2/3p2B1/3P4/2N5/PP2PPPP/R2QKBNR w KQkq -";
            moveLine = @"d1c2{6} e2e3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1pp1ppp/1p2pn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR w KQ -";
            moveLine = @"c1g5{69} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/8/2BPP3/2P5/P4PPP/R1BQK1NR b KQkq -";
            moveLine = @"c7c5{36} e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/3Pp3/2P1P3/2N1BP2/PP4PP/R2QKBNR b KQ -";
            moveLine = @"c7c6{17} f6h5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/5np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R b KQ e3";
            moveLine = @"b8a6{22} a7a6{25} c8g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P5/P4PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1c4{40} c1e3{35} f1b5{5} g1f3{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2NBP3/PP3PPP/R1BQK1NR b KQ -";
            moveLine = @"c7c5{25} d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/6p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R b KQkq -";
            moveLine = @"e8g8{10} b8c6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 b - -";
            moveLine = @"f6d7{25} c8b7{55} f8e8{5} c6a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bpp1/4pn1p/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"g5h4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R b KQkq f3";
            moveLine = @"e7e6{34} e7e5{5} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R b KQkq f3";
            moveLine = @"d8c7{5} d8b6{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3p1n2/2pP4/8/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{141}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq -";
            moveLine = @"f2f4{20} a2a4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"e7e6{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/8/2pp4/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1b5{10} g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bpp1/4p2p/3p4/2PPn2B/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"h4e7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/P1NBP3/1P3PPP/R1BQK1NR b KQ -";
            moveLine = @"b4c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"d2d3{15} f3g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R w KQkq -";
            moveLine = @"e1c1{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/3p4/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"c2c4{26} f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1pp2ppp/p1np4/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"a4c6{5} e1g1{5} c2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
            moveLine = @"d5c4{20} f8e7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{11} e8g8{18} d7d5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/2p1bppp/p1npbn2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f2f4{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq d6";
            moveLine = @"c2c4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/4pn2/3p4/2PP4/5NP1/PP1QPP1P/RN2KB1R w KQ d6";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
            moveLine = @"f8g7{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/2p1bppp/p2p1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"f8e7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2NBPN2/PP3PPP/R1BQK2R b KQ -";
            moveLine = @"d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{5} f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp2bppp/2p5/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR w KQkq -";
            moveLine = @"e2e3{10} d1c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppppp1pp/8/5p2/2P5/8/PP1PPPPP/RNBQKBNR w KQkq f6";
            moveLine = @"d2d4{5} g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2pP4/8/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/2P1P3/8/PP1P1PPP/RNBQKBNR b KQkq e3";
            moveLine = @"f8g7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq -";
            moveLine = @"d2c3{40} e1g1{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/5n2/3p4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
            moveLine = @"c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"f8e7{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2bppp/3ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq f3";
            moveLine = @"e8g8{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/3p4/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"f8g7{67} d7d5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/1b1p1ppp/pp2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
            moveLine = @"b2b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1PB2NP1/P3PPBP/RN1QK2R w KQkq d6";
            moveLine = @"f3e5{25} b1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq d6";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2pnbppp/p1np4/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 b - d3";
            moveLine = @"e7f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/P1N5/1PQ1PPPP/R1B1KBNR b KQ -";
            moveLine = @"b4c3{75}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/5N2/PP1NPPPP/R1BQKB1R w KQkq -";
            moveLine = @"a2a3{5} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{56}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/ppppqppp/4pn2/8/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq -";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/8/4p3/2pPP3/8/PP3PPP/RNBQKBNR w KQkq e6";
            moveLine = @"g1f3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/8/2Pp4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"f3d4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/1BN5/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"b8d7{5} b7b5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/5n2/3p2B1/3P4/2N5/PP2PPPP/R2QKBNR w KQkq -";
            moveLine = @"e2e3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"g2g3{5} g1f3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq c6";
            moveLine = @"g1f3{15} g2g3{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/6p1/8/2BPP3/2P5/P4PPP/R1BQK1NR w KQ -";
            moveLine = @"g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3p1p/3p1np1/2pP4/8/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"h2h3{15} e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n5/1B2p3/4n3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"d2d4{75}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/Q1PP4/5NP1/PP2PP1P/RNB1KB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R w KQ -";
            moveLine = @"f1e2{130} h2h3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2pnbppp/p1np4/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{46} c1e3{25} g2g3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/p1p2ppp/1p2p3/3pP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"f1b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1ppbp/3p2p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1e2{5} c1e3{15} f2f4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppppbppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"f1e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N3P1/PPP2P1P/R1BQKBNR w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q5/1P2PPPP/R3KBNR w KQ -";
            moveLine = @"f2f3{31} g1h3{5} e2e3{11} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/3p4/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
            moveLine = @"e2e4{16} g1f3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n5/4p3/3NP3/8/PPP2PPP/RNBQKB1R w KQkq e6";
            moveLine = @"d4b5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/5NP1/PP1NPP1P/R1BQKB1R b KQkq -";
            moveLine = @"a6b7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppppp1pp/8/5p2/3P4/2N5/PPP1PPPP/R1BQKBNR b KQkq -";
            moveLine = @"d7d5{5} g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1pppbp/2p2np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qr1k1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
            moveLine = @"b1d2{72}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/8/2pp4/3P4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"g2g3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppppppp/2n5/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
            moveLine = @"f8g7{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1pqp1ppp/p3pn2/8/3NP3/3B4/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"d1e2{5} c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 w - -";
            moveLine = @"c2c3{50} a2a4{17} h2h3{51} d2d3{10} a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2n3p1/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{15} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{31} c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq c6";
            moveLine = @"c2c3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/4pn2/2pp4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq c6";
            moveLine = @"c4d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1p1p/2n3p1/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/5n2/2pPp3/2P5/8/PP2PPPP/RNBQKBNR w KQkq e6";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq e3";
            moveLine = @"e7e6{5} d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 b - d3";
            moveLine = @"f8e8{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/2p2np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq d6";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1p2ppp/bp2pn2/3p4/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq d6";
            moveLine = @"f1g2{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qr1k1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 b - -";
            moveLine = @"e7f8{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP4PP/R1BQKBNR w KQ -";
            moveLine = @"c1e3{61} c1g5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2ppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
            moveLine = @"a2a4{42} d4d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2ppp/p1np1n2/1p2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 b - a3";
            moveLine = @"h7h6{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP2BPPP/R1BQK2R b KQ -";
            moveLine = @"e7e5{128} b8a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2pn1ppp/p1np1b2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
            moveLine = @"a2a4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQK2R w KQ e6";
            moveLine = @"c1e3{20} e1g1{90} d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P1B3/P4PPP/R2QKBNR b KQkq -";
            moveLine = @"c7c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2pn1ppp/p1np1b2/1p2p3/P2PP3/1BP2N1P/1P3PP1/RNBQR1K1 b - a3";
            moveLine = @"c8b7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3d4{64}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/6p1/2p5/3PP3/2P1B3/P4PPP/R2QKBNR w KQkq c6";
            moveLine = @"d1d2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/6p1/2p5/3PP3/2P1B3/P2Q1PPP/R3KBNR w KQ -";
            moveLine = @"g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bpn1ppp/p1np1b2/1p2p3/P2PP3/1BP2N1P/1P3PP1/RNBQR1K1 w - -";
            moveLine = @"b1a3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"c7c6{31} f6g4{10} e5d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p1np1n1p/1p2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 w - -";
            moveLine = @"b3c2{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ e6";
            moveLine = @"d4d5{15} g1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p1np1n1p/1p2p3/P2PP3/2P2N1P/1PBN1PP1/R1BQR1K1 b - -";
            moveLine = @"e5d4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p2p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"f1d3{5} d1d2{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{120} d5c4{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1p2ppp/bp2pn2/8/2pP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
            moveLine = @"f3e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1BPP1N1P/PP3PP1/RNBQR1K1 b - -";
            moveLine = @"f8e8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{40} b1c3{26} c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/5N2/PPQ1PPPP/RNB1KB1R b KQkq -";
            moveLine = @"d5c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2BPPP/R1BQK1NR b KQkq -";
            moveLine = @"e8g8{33}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/1bpp1pp1/1p2pn1p/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
            moveLine = @"b1c3{5} a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1a4{20} e2e4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/2p2n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{11} d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"d4c6{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e3{78} g1f3{66}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n2n2/3Np3/1bP5/5NP1/PP1PPP1P/R1BQKB1R b KQkq -";
            moveLine = @"b4c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"c5d4{274}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"e8g8{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qr1k1/1bp1bpp1/p1np1n1p/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
            moveLine = @"d2f1{5} b3c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"c7c5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p2p1/3Pp2n/2P1P3/2N1BP2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2bppp/2p2n2/3p2B1/3P4/2N1P3/PP3PPP/R2QKBNR w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQ -";
            moveLine = @"f1g2{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2P1P3/2N5/PP1P1PPP/R1BQKBNR w KQkq c6";
            moveLine = @"e4e5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{61}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
            moveLine = @"d7d6{32} e7e6{20} b8c6{30} g7g6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/3p4/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq e3";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/8/2pn4/8/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR b KQkq -";
            moveLine = @"e7e6{10} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppqppppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{5} c2c4{5} d4b5{5} f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/8/Q1pP4/2N2N2/PP2PPPP/R1B1KB1R w KQkq -";
            moveLine = @"a4c4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppppp1pp/5n2/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
            moveLine = @"d7d6{56}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/3p4/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
            moveLine = @"g8f6{10} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/8/5NP1/PPPPPP1P/RNBQKB1R w KQkq c6";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"d5e4{60}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pp1bpppp/2np1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1nppbp/6p1/2p5/3PP3/2P1BN2/P2Q1PPP/R3KB1R w KQ -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c4d5{5} c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppbppp/1p2p3/8/2PPn3/2N2NP1/PP2PPBP/R1BQK2R w KQkq -";
            moveLine = @"c1d2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/3Pp3/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"d2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbp2ppp/1p2pn2/3p4/Q1PP4/P1N2N2/1P2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"d8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4P3/2P1P3/2N1BN2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"d6e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p1np1n1p/1p6/P2pP3/2P2N1P/1PBN1PP1/R1BQR1K1 w - -";
            moveLine = @"c3d4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/5n2/3p2B1/3P4/2N1P3/PP3PPP/R2QKBNR w KQ -";
            moveLine = @"f1d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2p1p/3p2p1/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R w KQkq -";
            moveLine = @"d1c2{75} f1d3{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ2PPP/R1B1KB1R w KQkq -";
            moveLine = @"f1e2{25} b2b3{5} f1d3{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp2ppp/4p3/3p4/1bPP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{10} e2e3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3P4/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"c6d5{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/P1N2P2/1P2P1PP/R1BQKBNR b KQkq -";
            moveLine = @"b4c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p1p1p1p/p3p1p1/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
            moveLine = @"d7d5{135}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPPN1PPP/R1BQKBNR b KQkq -";
            moveLine = @"c7c5{15} f8e7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/8/2pP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{15} a7a6{10} e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/3PP3/2N2N2/PPP1BPPP/R1BQK2R w KQ -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pb1p1ppp/1p2pn2/2p5/1bPP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq c6";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B1K2R w KQ -";
            moveLine = @"e1g1{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/8/2pP4/2N1PN2/PPQ1BPPP/R1B2RK1 w - -";
            moveLine = @"e2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR b KQ -";
            moveLine = @"b7b6{70}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p4/2PP4/P1P2P2/4P1PP/R1BQKBNR b KQkq -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N2Q2/PPP3PP/R1B1KB1R b KQkq -";
            moveLine = @"d8b6{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p1n2/4p3/3PP3/3B4/PPP2PPP/RNBQK1NR w KQkq e6";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4e5{52} c1g5{88}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/p1pp1ppp/2p2n2/8/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"e4e5{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"b8d7{96}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BP2/PP2N1PP/R2QKB1R b KQ -";
            moveLine = @"c7c6{18}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/1p1p1ppp/p3p3/2b5/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"d4b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/4pn2/3P4/3P4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e6d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/3Pp3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"c3e4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2n5/3np3/8/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2npp3/1N6/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"e4e5{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP1QBPPP/R3K2R b KQ -";
            moveLine = @"e5d4{6} d8e7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"f8b4{15} d5e4{10} g8f6{55} b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/6N1/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1c4{6} f1d3{42}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/2b5/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"c1e3{6} d4c6{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppppppbp/6p1/8/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
            moveLine = @"e7e5{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/2P5/4PN2/PP1P1PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQ -";
            moveLine = @"d7d6{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
            moveLine = @"b8c6{46} b8a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp2pbp/2np1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"d4d5{60}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp2pp/4pn2/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR w KQkq -";
            moveLine = @"g1h3{5} c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"c8b7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/1P3NP1/P3PPBP/RNBQK2R b KQkq -";
            moveLine = @"f8b4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbppbppp/1p2p3/8/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQ -";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp2pbp/2np1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
            moveLine = @"c6e7{41}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/pp3ppp/4p3/2pq4/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/2p5/3pp3/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq e6";
            moveLine = @"d4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/3p4/2PP4/8/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP1Q2PP/R3KBNR b KQ -";
            moveLine = @"c6d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1c2{46} g2g3{20} d1b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/8/5N2/PPPPPPPP/RNBQKB1R w KQkq c6";
            moveLine = @"c2c4{56} e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
            moveLine = @"f7f5{5} g8f6{5} b7b6{5} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"d1c2{10} d1b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{10} c8f5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N2N2/PPQ1PPPP/R1B1KB1R b KQ -";
            moveLine = @"c7c5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2ppbppp/p1n2n2/1p2p3/B3P3/5N2/PPPPQPPP/RNB2RK1 w kq b6";
            moveLine = @"a4b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{106}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
            moveLine = @"e7e6{40} a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/5np1/3p4/3P4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/pp2ppbp/6p1/q1p5/3PP3/2P1B3/P2Q1PPP/R3KBNR w KQkq -";
            moveLine = @"a1b1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/6B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
            moveLine = @"f8g7{23}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/8/2pPP3/8/PP3PPP/RNBQKBNR b KQkq e3";
            moveLine = @"c7c5{15} g8f6{10} e7e5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n1p3/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/5N2/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"a2a4{10} f2f3{42} f1e2{30} g2g4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2nn4/1B2p3/3P4/5N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"b5c6{55}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2NBPN2/PP3PPP/R1BQK2R b KQkq -";
            moveLine = @"d5c4{30} f8d6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pppp1pbp/6p1/4p3/2P5/2N3P1/PP1PPPBP/R1BQK1NR b KQkq -";
            moveLine = @"d7d6{6} f7f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq e3";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/2b1p3/2B1P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"c2c3{5} b2b4{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1p1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"f1e2{10} d1b3{5} f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2pP4/3P4/8/PPPN1PPP/R1BQKBNR b KQkq -";
            moveLine = @"d8d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R w KQ -";
            moveLine = @"d2d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbp2ppp/1p2pn2/3P4/3P4/P1N2N2/1P2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"f6d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq d3";
            moveLine = @"e8g8{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1n2n2/1p1pp3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 w - d6";
            moveLine = @"e4d5{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2PP4/8/PP2PPPP/RNBQKBNR w KQkq e6";
            moveLine = @"d4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w - -";
            moveLine = @"f2f4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3pp1/2p1pn1p/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"g5f6{25} g5h4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1p3ppp/p1npp3/1N6/2P1P3/8/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"b5c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/2p1p3/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{65}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{40} b7b6{5} d7d5{15} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQK2R w KQ -";
            moveLine = @"e1g1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1p2ppp/bp2pn2/3p4/1bPP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
            moveLine = @"c1d2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/p3ppbp/1p4p1/q1p5/3PP3/2P1B3/P2Q1PPP/1R2KBNR w Kkq -";
            moveLine = @"f1b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppnppbp/3p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/8/2BPN3/8/PPP2PPP/R1BQK1NR w KQkq -";
            moveLine = @"e4g5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1r1k/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p1n2/4p3/3PP3/5P2/PPP3PP/RNBQKBNR w KQkq e6";
            moveLine = @"d4e5{5} g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3P4/3P4/8/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"c6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/b3pn2/1p6/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
            moveLine = @"c4b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/8/2pP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
            moveLine = @"e2e4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/8/3PN3/8/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"b8d7{85} c8f5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/6N1/2BP4/8/PPP2PPP/R1BQK1NR w KQkq -";
            moveLine = @"d1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pb2/8/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQkq -";
            moveLine = @"d1c2{5} e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{177} e7e6{27} e7e5{15} g7g6{15} d8c7{20} d8b6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p1p2n2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"a2a4{5} d1c2{5} c1g5{5} c4c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bP5/2N2N2/PPQPPPPP/R1B1KB1R w KQkq c6";
            moveLine = @"a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1pp1ppp/1p2pn2/6B1/2PP4/P1Q5/1P2PPPP/R3KBNR b KQ -";
            moveLine = @"c7c5{15} h7h6{5} c8b7{35} c8a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/1pp1ppbp/p2p2p1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"d1d2{5} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"c3d5{5} f1g2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/3P1B2/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n1pn2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p2p1np1/8/2PPP3/2N1BP2/PP1Q2PP/R3KBNR b KQ -";
            moveLine = @"b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/1pqp1ppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"e7e6{95}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"d5c4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/2pP4/2p1P3/8/PP3PPP/RNBQKBNR b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/2pP4/2p1P3/2N5/PP3PPP/R1BQKBNR b KQkq -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/5n2/3p2B1/3P4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R b KQkq -";
            moveLine = @"f8e7{55} a7a6{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1pp1/1p2pn1p/8/2PP3B/2b1PN2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"b2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp2ppp/4p3/3p4/1b1PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4e5{72}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p2nbppp/bpp1p3/3pN3/2PP4/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
            moveLine = @"e5d7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4ppp/2p1pn2/1p6/2QP4/2N2N2/PP2PPPP/R1B1KB1R w KQkq b6";
            moveLine = @"c4d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppbppp/1p2pn2/8/2PP4/2N2NP1/PP2PPBP/R1BQK2R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BP2/PP2N1PP/R2QKB1R w KQ -";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbp2ppp/1p2pn2/3p2B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR w KQ d6";
            moveLine = @"e2e3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N1PN2/PP1P1PPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N5/PP1NBPPP/R1BQ1RK1 b - -";
            moveLine = @"a7a5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/2p5/2pPP3/8/PP3PPP/RNBQKBNR w KQkq c6";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/2pp1ppp/p1n5/1p2p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq b6";
            moveLine = @"a4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/8/4p3/3Pn3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{46} f3e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{27}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"d5c4{15} h7h6{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppb1pp/1p2p3/5p2/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQkq f6";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BP2/PP1QN1PP/R3KB1R b KQ -";
            moveLine = @"b8d7{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/6p1/2p5/2BPP3/2P5/P4PPP/R1BQK1NR w KQkq c6";
            moveLine = @"g1e2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pn2/6B1/2PP4/2b1PN2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"b2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"e7e5{5} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2NBP3/PP3PPP/R1BQK1NR b KQkq -";
            moveLine = @"b8c6{15} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppn1ppp/4p3/3pP3/3P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f2f4{22} c3e2{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/5np1/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R w KQ -";
            moveLine = @"e2e4{51}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{31}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1n1ppp/p2ppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"g2g4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/3p1np1/2p5/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ c6";
            moveLine = @"g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1PP/2N5/PPP2P2/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N5/PP2BPPP/R1BQNRK1 b - -";
            moveLine = @"f6e8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq d3";
            moveLine = @"b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R b kq -";
            moveLine = @"e8g8{40} c6d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pp3ppp/2p1pn2/4Nb2/PbpP4/2N2P2/1P2P1PP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq c6";
            moveLine = @"g2g3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/4pn2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/1np1pn2/6N1/2BP4/8/PPP1QPPP/R1B1K1NR w KQkq -";
            moveLine = @"c4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/1bp2ppp/1p1ppn2/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
            moveLine = @"b1c3{5} d2g5{5} d2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d6{80} e7e5{72} e7e6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{5} b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"g2g3{10} e2e4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{20} d1a4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/8/P1pP4/2N2N2/1P2PPPP/R1BQKB1R b KQkq a3";
            moveLine = @"c8f5{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"c8g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1p1p1ppp/p1n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{5} c1e3{5} d4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1pq1pppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R w KQkq -";
            moveLine = @"d1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"f1e1{36} c2c4{76}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1n1ppp/4p3/2ppP3/3P1P2/2N5/PPP3PP/R1BQKBNR w KQkq c6";
            moveLine = @"g1f3{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/6B1/3P4/2P2N2/PP2PPPP/RN1QKB1R b KQkq -";
            moveLine = @"b7b6{6} c7c5{6} e8g8{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp2ppp/8/4p3/1bpPP3/5N2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"c1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n5/1N2p3/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"d8c7{30} d7d6{23} a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"a7a6{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"e7e5{27} e7e6{77}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2bppp/2nppn2/6B1/3NPP2/2N5/PPPQ2PP/2KR1B1R b - f3";
            moveLine = @"c6d4{25} h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/1pq1bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 w kq -";
            moveLine = @"g1h1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2bppp/3ppn2/6B1/3nPP2/2N5/PPPQ2PP/2KR1B1R w - -";
            moveLine = @"d2d4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 b kq -";
            moveLine = @"g8f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq -";
            moveLine = @"g1h1{5} c1e3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1npppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R w KQkq -";
            moveLine = @"d4f3{5} f1e2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2bppp/3ppn2/6B1/3QPP2/2N5/PPP3PP/2KR1B1R b - -";
            moveLine = @"d8a5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R w KQkq -";
            moveLine = @"e1c1{31}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/pq1ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"d4b3{15} a2a3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R b kq -";
            moveLine = @"h7h6{20} c6d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1pn2/2pp4/2PP4/2N1PN2/PP3PPP/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pppp1ppp/8/4p3/1bP5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"c3d5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4p3/2pn4/8/2N2N2/PPP1PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c3d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/P1N2N2/1P1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"g7g6{5} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2P5/1bP5/2N2N2/PPQ1PPPP/R1B1KB1R b KQ -";
            moveLine = @"b8a6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n2n2/2p1p3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq e6";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq d3";
            moveLine = @"f8g7{5} g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R b KQkq -";
            moveLine = @"e7e5{5} e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{75}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"g7g6{30} e7e6{5} g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppp1p/2n2np1/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp3ppp/4p3/2ppP3/1b1P4/2N5/PPP2PPP/R1BQKBNR w KQkq c6";
            moveLine = @"a2a3{57}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/6B1/2PPP3/2N2P2/PP4PP/R2QKBNR b KQ -";
            moveLine = @"a7a6{11} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R w KQ -";
            moveLine = @"e2e3{25} a1c1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/2p5/8/2BPN3/8/PPP2PPP/R1BQK1NR b KQkq -";
            moveLine = @"g8f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/6B1/3PP3/8/PPP2PPP/RN1QKBNR b KQkq e3";
            moveLine = @"h7h6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ d6";
            moveLine = @"e1g1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/5N2/PPP1BPPP/RNBQK2R b KQkq -";
            moveLine = @"c6c5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p1pnppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b2rk1/pp2bppp/3ppn2/q5B1/3QPP2/2N5/PPP3PP/2KR1B1R w - -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b2rk1/pp2bppp/3ppn2/q5B1/2BQPP2/2N5/PPP3PP/2KR3R b - -";
            moveLine = @"c8d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/3p4/2PP4/8/PP3PPP/RNBQKBNR b KQkq c3";
            moveLine = @"g8f6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/8/3p4/3P4/3B4/PPP2PPP/RNBQK1NR b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n5/4p3/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"d4e5{5} f3e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
            moveLine = @"e5d4{5} f6e4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/8/2Pp4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"f3d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
            moveLine = @"g1f3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/3PP3/8/PPPN1PPP/R1BQKBNR b KQkq -";
            moveLine = @"d5e4{55}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq d3";
            moveLine = @"g8f6{37} c8f5{5} e7e6{5} c7c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P2N2/P4PPP/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{5} c7c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n2n2/2bNp3/2P5/5NP1/PP1PPPBP/R1BQK2R b KQkq -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq -";
            moveLine = @"f8e7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r4rk1/pp1bbppp/3ppn2/q3P1B1/2BQ1P2/2N5/PPP3PP/2KR3R b - -";
            moveLine = @"d6e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/8/3n4/3p4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
            moveLine = @"f8g7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq e6";
            moveLine = @"d4b3{82} d4f3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP1NPPBP/R1BQK2R b KQkq -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1n1pp1/p2ppn1p/8/3NP1P1/2N1BP2/PPP4P/R2QKB1R w KQkq -";
            moveLine = @"h1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2pppp/2p2n2/5b2/P1pP4/2N1PN2/1P3PPP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"b8c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/2p1pn2/5b2/P1pP4/2N1PN2/1P3PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1c4{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/8/2pP4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
            moveLine = @"d3c4{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p3ppp/p2pp3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/6N1/2BP4/8/PPP2PPP/R1BQK1NR b KQkq -";
            moveLine = @"e7e6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/6B1/2pP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e4{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/8/2BP4/2N1PN2/PP3PPP/R1BQK2R b KQkq -";
            moveLine = @"b7b5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3pp1/2p1pB1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"d8f6{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/pq1ppn2/8/3NPP2/P1N2Q2/1PP3PP/R1B1KB1R b KQkq -";
            moveLine = @"b8c6{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3pp1/2nppn1p/8/3NP1PP/2N5/PPP2P2/R1BQKB1R w KQkq -";
            moveLine = @"h1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbp2ppp/1p2pn2/3p4/2PP4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n1pn2/8/2PN4/2N5/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pp1pppbp/2n3p1/8/2PNP3/8/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pp1p/3p2p1/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2n3p1/8/2PNP3/8/PP3PPP/RNBQKB1R b KQkq c3";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQ -";
            moveLine = @"g1e2{5} f1d3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQkq c6";
            moveLine = @"g1e2{15} f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pp3ppp/2p1pn2/4N3/PbpPb3/2N2P2/1P4PP/R1BQKB1R w KQkq -";
            moveLine = @"f3e4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/8/1bPp4/2N1P3/PP2NPPP/R1BQKB1R w KQkq -";
            moveLine = @"e3d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2pP4/2P5/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d6{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2bppp/2p2n2/3p4/3P1B2/2N1P3/PP3PPP/R2QKBNR w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n1pn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"d4b5{27} d4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppppp1pp/8/5p2/8/5N2/PPPPPPPP/RNBQKB1R w KQkq f6";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"f8g7{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2NPPP/R1BQKB1R b KQkq -";
            moveLine = @"a7a6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/5n2/3p4/3P1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp3ppp/4p3/2ppP3/3P4/P1b5/1PP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"b2c3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/2pP4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQK2R b KQ -";
            moveLine = @"a7a5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4ppp/2p1pn2/1p4B1/2pPP3/2N2N2/PP3PPP/R2QKB1R w KQkq b6";
            moveLine = @"e4e5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pp3ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2np1n2/1N2p3/4P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{77}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppppbppp/8/3Np3/2P5/8/PP1PPPPP/R1BQKBNR w KQkq -";
            moveLine = @"d2d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2B3p1/2p5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"d7c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQK2R b KQkq -";
            moveLine = @"f8e7{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/p2n1ppp/2p1pn2/1p6/2BP4/2N1PN2/PP3PPP/R1BQK2R w KQkq b6";
            moveLine = @"c4d3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/3n1ppp/p1p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
            moveLine = @"e3e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
            moveLine = @"d7d5{5} e8g8{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"e7e5{5} d7d6{5} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp1bpppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"b5d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1p2bppp/p1npbn2/4p3/4P3/1NN1B3/PPPQBPPP/R4RK1 w - -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbp1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP2BPPP/R2QK2R w KQ -";
            moveLine = @"h4f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2QK2R b KQkq -";
            moveLine = @"e8g8{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n2n2/1N2p3/4P3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d6{67}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/6N1/2BP4/8/PPP1QPPP/R1B1K1NR b KQkq -";
            moveLine = @"d7b6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1n5/1p1np3/8/1BP2N2/PP1P1PPP/RNBQR1K1 w - -";
            moveLine = @"f3e5{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbp2ppp/1p2p3/3n4/3P4/P1N2N2/1P1BPPPP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/4P3/2pP4/8/PP3PPP/RNBQKBNR b KQkq -";
            moveLine = @"f6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/1N6/4P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"c1f4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/8/3nP3/8/8/PPPP1PPP/RNBQKBNR w KQkq -";
            moveLine = @"d2d4{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/2p1bppp/p1np1n2/1p2p3/3PP3/1bP2N1P/PP3PP1/RNBQR1K1 w - -";
            moveLine = @"a2b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{5} g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2P5/5NP1/PP1PPPBP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pp3ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQ1RK1 w - -";
            moveLine = @"d1e2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2nppp/4p3/2ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
            moveLine = @"d1g4{6} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/5NP1/PP2PPBP/RNBQ1RK1 b - -";
            moveLine = @"c7c5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp2pp/2n5/1B2pp2/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq f6";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/8/2pP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"b8c6{5} a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2npp3/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"g8f6{18}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2n2n2/2pp4/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq d6";
            moveLine = @"d2d4{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c4d5{15} d1c2{6} c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp2ppp/pnnp1b2/1p2p3/P2PP3/NBP2N1P/1P3PP1/R1BQR1K1 w - -";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2np1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"d8b6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/pp1n1ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQ1RK1 w kq -";
            moveLine = @"f3h4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqr1k1/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B2RK1 w - -";
            moveLine = @"f1d1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/4pn2/3p4/2PP4/2N2N2/PPQ1PPPP/R1B1KB1R w KQ -";
            moveLine = @"c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{40} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/1B6/3PP3/2P5/P4PPP/R1BQK1NR b KQkq -";
            moveLine = @"c8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1e2{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n1b3/1p1pP3/4n3/1B3N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"c1e3{5} b1d2{46}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"f3d2{5} b2b4{50}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p3bppp/bpp1p3/3pN3/2PPn3/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/ppp1pppp/8/3p1b2/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3P4/3P4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
            moveLine = @"f6d5{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq d3";
            moveLine = @"e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/2p2np1/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq d6";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/6B1/1bPP4/2N5/PP2PPPP/R2QKBNR b KQkq -";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb2rk1/ppp1qpp1/4p2p/3p4/2PPn3/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"a1c1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p1p2n2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5} d1c2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f1d3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/8/3pp3/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq d6";
            moveLine = @"f3e5{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp2ppp/4p3/3pP3/1b1P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"b7b6{5} c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2pn2/8/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1pn2/2pp4/2PP4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/ppp2ppp/4p3/3p1b2/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2p3/8/2PPn3/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c3e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/2p5/6N1/3P4/8/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{40} e7e6{10} d7f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1ppbp/2np1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/ppp1pppp/2n5/8/2pPP3/8/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"c1e3{10} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2N2Q2/PPP2PPP/R3KB1R b KQkq -";
            moveLine = @"b8d7{5} h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p1np1n1p/1p6/P2PP3/5N1P/1PBN1PP1/R1BQR1K1 b - -";
            moveLine = @"c6b4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p1pp1ppp/1p2p3/8/1bPPn3/2N1P3/PP2NPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1pppbp/5np1/2p5/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"d8a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppppp1pp/8/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR b KQkq -";
            moveLine = @"g8f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/4pn2/3p4/1bPP4/2NBP3/PP3PPP/R1BQK1NR w KQ d6";
            moveLine = @"g1f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppppp1pp/5n2/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR b KQkq -";
            moveLine = @"d7d6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1pp1pppp/p7/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
            moveLine = @"b8c6{10} e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/6B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/2pp1np1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"f2f3{10} h2h3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/6B1/3Pp3/2N5/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"c3e4{63}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1pppbp/5np1/2p5/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq c6";
            moveLine = @"f1g2{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q1P3/1P3PPP/R3KBNR b KQ -";
            moveLine = @"d7d6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR b KQkq -";
            moveLine = @"e7e6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p2p1ppp/1p2pn2/2p5/1bPP1B2/1QN2N2/PP2PPPP/R3KB1R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/5n2/1ppP4/2P5/8/PP2PPPP/RNBQKBNR w KQkq b6";
            moveLine = @"c4b5{10} b1d2{5} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/3p4/1Bp5/3PP3/5N2/PPP2PPP/RNBQK2R b KQkq d3";
            moveLine = @"g8f6{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq d6";
            moveLine = @"c4d5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/2pP4/2P5/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e6d5{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2n5/1Bpp4/3P4/8/PPPN1PPP/R1BQK1NR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2n5/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e5c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"f8e7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppn1ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkbnr/1ppb1ppp/p1np4/4p3/B3P3/2P2N2/PP1P1PPP/RNBQK2R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/8/5NP1/PPPPPP1P/RNBQKB1R b KQkq -";
            moveLine = @"c8g4{10} g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2pp1ppp/p1n2n2/1p2p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq b6";
            moveLine = @"a4b3{55}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f2f3{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPPQPPP/RNB2RK1 w - -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPPQPPP/RNB1K2R b KQkq -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1pp1pppp/p7/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQK2R b KQkq -";
            moveLine = @"e8g8{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
            moveLine = @"g7g6{5} e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/1p3ppp/p2pbn2/4p3/4P3/1NN1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f2f3{52} d1d2{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/2qp1ppp/p1n1p3/1p6/3NP3/2NBB3/PPP2PPP/R2QK2R w KQkq b6";
            moveLine = @"e1g1{5} d4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pn2/6B1/1bPP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p1pp1ppp/1p2pn2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/3p1np1/8/2P1P3/2N5/PP1P1PPP/R1BQKBNR w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/1np1pn2/6N1/3P4/3B4/PPP1QPPP/R1B1K1NR b KQkq -";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/4p3/2ppPb2/3P4/5N2/PPP1BPPP/RNBQK2R w KQkq -";
            moveLine = @"c1e3{15} e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppp1p/2p2np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/4p3/3pPb2/3p4/4BN2/PPP1BPPP/RN1QK2R w KQkq -";
            moveLine = @"f3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/3ppppp/p4n2/1PpP4/8/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"b5a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2P5/6P1/PP1PPPBP/RNBQK1NR b KQkq -";
            moveLine = @"b8c6{10} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppnbpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p2p1ppp/1p2pn2/2p3B1/2PP4/P1Q5/1P2PPPP/R3KBNR w KQ c6";
            moveLine = @"d4c5{5} e2e3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp1pppp/2n2n2/8/2pPP3/4B3/PP3PPP/RN1QKBNR w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p2p1ppp/1p2pn2/2P3B1/2P5/P1Q5/1P2PPPP/R3KBNR b KQ -";
            moveLine = @"b6c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4pp1/2p1pn1p/1p2P1B1/2pP4/2N2N2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"g5h4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1n1ppp/2p1pn2/q2p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1ppp1ppp/p1n5/4p3/B2Pn3/5N2/PPP2PPP/RNBQ1RK1 b kq d3";
            moveLine = @"b7b5{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p2p1n1p/1p6/Pn1PP3/5N1P/1PBN1PP1/R1BQR1K1 w - -";
            moveLine = @"c2b1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2pp1ppp/p1n5/1p2p3/3Pn3/1B3N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"d7d5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2pp1/p2p1n1p/1p6/Pn1PP3/5N1P/1P1N1PP1/RBBQR1K1 b - -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqr1k1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/6p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R w KQ -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R w KQkq -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p7/1p1nn3/8/1BP5/PP1P1PPP/RNBQR1K1 w - -";
            moveLine = @"e1e5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/2B1P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"g8f6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p2B1/3P4/8/PPP1PPPP/RN1QKBNR b KQkq -";
            moveLine = @"c7c6{5} h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/3p1n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"g2g3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{10} e7e5{6} c6d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3P4/8/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"f6d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/ppp1pppp/2n5/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{10} c4d5{11} g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppppbppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2p2ppp/p1n5/1p1pP3/4n3/1B3N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"c8e6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{15} e2e3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq -";
            moveLine = @"d2d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1p1ppp/2n1pn2/2p5/1bPP4/2NBP3/PP2NPPP/R1BQK2R b KQkq -";
            moveLine = @"c5d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/4P3/3P4/PPP2PPP/RNBQKBNR w KQkq d6";
            moveLine = @"b1d2{10} d1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 b kq -";
            moveLine = @"f8e7{41} b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/P2NP3/2N5/1PP1BPPP/R1BQ1RK1 b kq a3";
            moveLine = @"b8c6{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1p2bppp/p1nppn2/8/P2NP3/2N5/1PP1BPPP/R1BQ1RK1 w kq -";
            moveLine = @"c1e3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n1b3/1pnpP3/8/1B3N2/PPPN1PPP/R1BQ1RK1 w kq -";
            moveLine = @"c2c3{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1B3/PPPQ1PPP/R3KB1R b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/ppp1pppp/8/q7/8/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppppp2p/5np1/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR w KQkq -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppppppp/2n5/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2np4/1N2p3/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{5} b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp2pppp/1qnp1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"d4b5{15} d4c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pp1npppp/2p2n2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"e5c4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/3n4/8/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{5} d1a4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PPP3/2N2N2/PP3PPP/R2QKB1R b KQkq e3";
            moveLine = @"d5e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2n3p1/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{10} b5c6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp2pbp/3p1np1/p2Pp1B1/2P1P3/2N2N2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"h7h6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp2pb1/3p1npp/p2Pp3/2P1P2B/2N2N2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"b8a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pp1p/p2p1np1/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
            moveLine = @"g2g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bppbppp/p1n2n2/1p2p3/P3P3/1B3N2/1PPP1PPP/RNBQR1K1 w - -";
            moveLine = @"d2d3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq f3";
            moveLine = @"f8e7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{25} d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2n2n2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR w KQkq -";
            moveLine = @"c1g5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1e2{16} g2g3{10} g1f3{10} f1b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pb3ppp/1p1ppn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
            moveLine = @"b2b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP1QN1PP/R3KB1R b KQ -";
            moveLine = @"c6d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"c4b3{10} e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e3{41} e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkbnr/pp1n1ppp/2p1p3/3pPb2/3P4/5N2/PPP1BPPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2n1p3/2ppP3/3P1P2/2N2N2/PPP3PP/R1BQKB1R w KQkq -";
            moveLine = @"c1e3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/2qp1ppp/p1n1p3/1p6/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq b6";
            moveLine = @"d4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5} f2f4{5} g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p1p1ppp/p3p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppppppbp/6p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp2pppp/1qnp1n2/8/2B1P3/1NN5/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/4p3/2ppPb2/3P4/4BN2/PPP1BPPP/RN1QK2R b KQkq -";
            moveLine = @"g8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/6B1/2pPP3/2N2N2/PP3PPP/R2QKB1R b KQkq e3";
            moveLine = @"b7b5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pp3ppp/2p1p3/4N3/PbpPn3/2N5/1P4PP/R1BQKB1R w KQkq -";
            moveLine = @"c1d2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/2N1BN2/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qrbk1/1bp2ppp/p2p1n2/1p1Pp3/4P3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
            moveLine = @"d2f1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp1pppbp/2p3p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3pp1/p1nppn1p/8/3NP3/2N1B3/PPPQ1PPP/2KR1B1R b kq -";
            moveLine = @"f8e7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/6N1/3P4/3B4/PPP2PPP/R1BQK1NR w KQkq -";
            moveLine = @"g1f3{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4ppp/2p1pn2/1p2P1B1/2pP4/2N2N2/PP3PPP/R2QKB1R b KQkq -";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3p1n2/2pP4/8/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"g7g6{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 b - -";
            moveLine = @"c8b7{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/p2n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R b KQkq -";
            moveLine = @"c8b7{10} a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/4pn2/2p1Nb2/P1pP4/2N2P2/1P2P1PP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1p2bppp/p1nppn2/8/P2NP3/2N1B3/1PP1BPPP/R2Q1RK1 b kq -";
            moveLine = @"e8g8{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/3n4/3P4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/1p3ppp/pqNppn2/8/4PP2/P1N2Q2/1PP3PP/R1B1KB1R b KQkq -";
            moveLine = @"b7c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/8/3QP3/5N2/PPP2PPP/RNB1KB1R b KQkq -";
            moveLine = @"c8d7{5} b8c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb2rk1/1pq1bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1R1K w - -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bppbppp/p1n2n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 w - -";
            moveLine = @"d2d3{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2ppbp/2np1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n1b3/1p1pP3/4n3/1B3N2/PPPN1PPP/R1BQ1RK1 b kq -";
            moveLine = @"e4c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/4pn2/4Nb2/P1ppP3/2N2P2/1P4PP/R1BQKB1R w KQkq -";
            moveLine = @"e4f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp2pppp/1qnp1n2/1N6/2B1P3/2N5/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"c8g4{5} a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2N1PN2/PPQ2PPP/R1B1KB1R b KQkq -";
            moveLine = @"f8d6{46}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/8/2PpP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"f3d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1pp1pppp/p4n2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/4pn2/3p4/2PP4/2N2N2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{5} f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2BPPP/R1BQK1NR w KQ -";
            moveLine = @"c1g5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/p1ppqppp/2p2n2/4P3/8/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"d1e2{24}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppppppp/2n2n2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/P2NP3/2N5/1PP1BPPP/R1BQK2R b KQkq a3";
            moveLine = @"b8c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1P3NP1/P2BPPBP/RN1QK2R b KQkq -";
            moveLine = @"c7c6{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/p2n1ppp/2p1pn2/1p6/3P4/2NQ1N2/PP2PPPP/R1B1KB1R w KQkq -";
            moveLine = @"a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p4np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R w KQ -";
            moveLine = @"e4e5{36} c4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1p1ppp/1qn1pn2/8/2PN4/2N3P1/PP2PP1P/R1BQKB1R w KQkq -";
            moveLine = @"d4b5{5} d4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppbppp/1p2pn2/8/2P5/5NP1/PP1PPPBP/RNBQ1RK1 w kq -";
            moveLine = @"b1c3{10} f1e1{5} d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbp2ppp/1p1ppn2/2P3B1/3P4/P1Q1P3/1P3PPP/R3KBNR b KQ -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQ1RK1 b kq -";
            moveLine = @"a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1n1ppp/p2ppn2/8/3NP3/1BN5/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2NBB3/PPP2PPP/R2QK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/2p5/8/3PN3/5N2/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1ppp1ppp/p1n2n2/2b1p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"f3e5{5} c2c3{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR w KQ -";
            moveLine = @"b1c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
            moveLine = @"e7e6{33} c7c6{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3p1n2/2pp4/2P5/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c4d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 b kq -";
            moveLine = @"e8g8{10} c8e6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/3p4/3nP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p1np1/3Pp3/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 b - b3";
            moveLine = @"a7a5{10} f6h5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/6N1/3P4/3B4/PPP2PPP/R1BQK1NR b KQkq -";
            moveLine = @"e7e6{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2QK2R w KQ -";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pppbpp1p/6p1/3n4/Q7/2N2N2/PP1PPPPP/R1B1KB1R w KQkq -";
            moveLine = @"a4h4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1np1n2/1N2p1B1/4P3/2N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"b5a3{66}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1n1ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
            moveLine = @"e2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1pp1/4pB1p/8/3PP3/8/PPP2PPP/RN1QKBNR b KQkq -";
            moveLine = @"d8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n1b3/1pn1P3/3p4/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
            moveLine = @"b3e6{5} f3g5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1qrk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"d4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 w - -";
            moveLine = @"g1h1{5} d1e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/8/3p4/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1n1pp1/2p1pq1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
            moveLine = @"f1d3{5} a1c1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1pp2ppp/p3p3/8/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"e8g8{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQ e3";
            moveLine = @"d7d6{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B1K2R w KQ -";
            moveLine = @"e1g1{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/3p4/8/1P3N2/P1PPPPPP/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p2p1/3Pp2n/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 w - -";
            moveLine = @"f1e1{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb2rk1/pp2qpbp/2pp1np1/3Pp3/2P1P3/2N1BN2/PP1QBPPP/R3K2R b KQ -";
            moveLine = @"c6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppppppbp/6p1/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/4p3/1bB1P3/5N2/P1PP1PPP/RNBQK2R w KQkq -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4p2/2p1pn1p/1p2P1p1/2pP3B/2N2N2/PP3PPP/R2QKB1R w KQkq g6";
            moveLine = @"f3g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppp1p/6p1/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
            moveLine = @"c5d4{5} f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
            moveLine = @"d5c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/8/3P4/2P5/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{5} c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1p2bpp1/p1nppn1p/8/3NPP2/2N1B3/PPPQ2PP/2KR1B1R b kq f3";
            moveLine = @"c6d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2n3p1/1Bp5/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"f8g7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1ppbp/2n2np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R w KQ -";
            moveLine = @"f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1PB2NP1/P3PPBP/RN1QK2R b KQkq -";
            moveLine = @"d7d5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2p1pn2/6N1/3P4/3B1N2/PPP2PPP/R1BQK2R b KQkq -";
            moveLine = @"f8d6{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/2p1ppbp/p4np1/1p2P3/2QP4/2N2N2/PP3PPP/R1B1KB1R w KQ b6";
            moveLine = @"c4b3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbp2ppp/1p2p3/3n4/3P4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B1K2R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/6N1/3P4/3B1N2/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"d1e2{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1p1ppp/2n1pn2/8/1bPP4/2NB4/PP2NPPP/R1BQK2R b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2pP4/2P5/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/p2nbppp/bpp1p3/3p4/2PP4/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
            moveLine = @"b1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/4bppp/p1p5/1p1nR3/8/1BP5/PP1P1PPP/RNBQ2K1 w - -";
            moveLine = @"d2d3{10} e5e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/p3pppp/1qpp1n2/8/2B1P3/2N5/PPP2PPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/8/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1c4{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p4/6B1/3NP1n1/2N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"h7h6{58}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1nppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"e4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/pq1ppn2/8/4PP2/1NN2Q2/PPP3PP/R1B1KB1R b KQkq -";
            moveLine = @"b6c7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/8/2Pp4/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2ppp1/p2p3p/8/3NP1nB/2N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"g7g5{53}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p2p1/4p1B1/2PPP1n1/2N2N2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"f7f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p4/8/3NP1n1/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"e3g5{62} e3c1{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"e4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/pppp1pp1/4pq1p/8/3PP3/2N5/PPP2PPP/R2QKBNR b KQkq -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bpp1ppp/np2pn2/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
            moveLine = @"d2g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p4/8/3NP1n1/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"g4f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQK2R w KQ -";
            moveLine = @"c3d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQ1RK1 b - -";
            moveLine = @"b4c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/8/3PN3/5N2/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"e4f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1p1ppp/4pn2/2p5/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq c6";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B1K2R b KQkq -";
            moveLine = @"e8g8{31}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/8/1bpPP3/2N2N2/PP3PPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2ppp1/p2p3p/6B1/3NP1n1/2N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"g5h4{57}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/1BN5/PPP2PPP/R1BQ1RK1 b kq -";
            moveLine = @"b5b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bpp1/4pn1p/8/2pP3B/2N2N2/PP2PPPP/2RQKB1R w K -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/6N1/3P4/3B1N2/PPP1QPPP/R1B1K2R b KQkq -";
            moveLine = @"h7h6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb2rk1/pp2qpp1/2p1p2p/3p4/2PPn3/2N1PN2/PP3PPP/2RQKB1R w K -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp2ppp/4p3/3p4/1bPP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/4pn2/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R w KQ -";
            moveLine = @"e2e3{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1nppp/4p3/3pP3/1b1P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"a2a3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp1pppp/8/8/2pP4/4P3/PP3PPP/RNBQKBNR b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/pp1p1ppp/1q2p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1pq2ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"g5f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1pp1bppp/p1np1n2/4p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 w kq -";
            moveLine = @"c2c3{5} a4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1pp1npbp/3p1np1/p2Pp3/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 w - a6";
            moveLine = @"c1a3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bP5/2N2N2/PPQPPPPP/R1B1KB1R w KQ -";
            moveLine = @"a2a3{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq d3";
            moveLine = @"d5c4{5} c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/2P5/P1b2N2/1PQPPPPP/R1B1KB1R w KQ -";
            moveLine = @"c2c3{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3P4/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"e6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/3PP3/2P5/PP3PPP/RNBQKBNR b KQkq d3";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/P4N2/1PP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4PP2/2N5/PPPP2PP/R1BQKBNR b KQkq f3";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2pppp/2p2n2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{15} b8d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/1bpp1ppp/1p2pn2/p7/2PP4/1P3NP1/P1QbPPBP/RN3RK1 w - -";
            moveLine = @"b1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1pp1/2pbpn1p/6N1/3P4/3B1N2/PPP1QPPP/R1B1K2R w KQkq -";
            moveLine = @"g5e4{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 b - -";
            moveLine = @"d5c4{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k1nr/pp3ppp/4p3/q1ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
            moveLine = @"c1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
            moveLine = @"b8d7{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2bppp/4pn2/3p4/2PP4/2N2N2/PP3PPP/R1BQKB1R w KQkq -";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2Q1RK1 b - -";
            moveLine = @"e5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1ppp1ppp/p1B5/4p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"d7c6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p1p1ppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQ -";
            moveLine = @"e2e4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/1B3N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"a2a4{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/8/4p3/3Pn3/3B1N2/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3ppp/4pn2/2pp4/1bPP4/2NBPN2/PP3PPP/R1BQ1RK1 b - -";
            moveLine = @"b8c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N1P3/PP1P1PPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1n1bp/3p2p1/3Ppp1n/1PP1P3/2N2N2/P3BPPP/R1BQR1K1 w - f6";
            moveLine = @"f3g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2p1n2/4p3/4P3/1NN1B3/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"c8e6{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/8/2pP4/4P3/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"f1c4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq c6";
            moveLine = @"d4c5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2ppbp/2np1np1/8/3NP3/2N1BP2/PPPQ2PP/R3KB1R w KQ -";
            moveLine = @"f1c4{5} e1c1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppp1p/6p1/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/2pp1ppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"c8b7{5} f8c5{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p3pn2/3p4/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
            moveLine = @"g4g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1pp2ppp/p1p5/4p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"c8g4{5} f7f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1p2bppp/p1nppn2/8/P2NPP2/2N1B3/1PP1B1PP/R2Q1RK1 b - f3";
            moveLine = @"d8c7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p2p1np1/6B1/2PPP3/2N2P2/PP4PP/R2QKBNR w KQ -";
            moveLine = @"d1d2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2bppp/3ppn2/6B1/3QP3/2N5/PPP2PPP/2KR1B1R b kq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/8/3np3/3P4/5N2/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"f3e5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1k2r/1pqp1ppp/p1n1pn2/8/1b1NP3/2N1B3/PPP1BPPP/R2Q1RK1 w kq -";
            moveLine = @"c3a4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b2rk1/pp1nqppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
            moveLine = @"c4c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1n1pp1/2p1pq1p/3p4/2PP4/2NBPN2/PP3PPP/R2QK2R b KQkq -";
            moveLine = @"d5c4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1ppp1ppp/p1n2n2/2b1p3/B3P3/2P2N2/PP1P1PPP/RNBQ1RK1 b kq -";
            moveLine = @"b7b5{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3pp1/p1nppn1p/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
            moveLine = @"g5e3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1pp2ppp/p1p5/4p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/5n2/3p4/3P4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"c1g5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p2p1np1/6B1/2PPP3/2N2P2/PP1Q2PP/R3KBNR b KQ -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pp2/p2p3p/6p1/3NP1n1/2N3B1/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"f8g7{48}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1b1ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2NBP3/PP3PPP/R1BQK1NR w KQ c6";
            moveLine = @"g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 b - -";
            moveLine = @"d7d6{5} d7d5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1p2ppbp/p2p1np1/2p3B1/2PPP3/2N2P2/PP1Q2PP/R3KBNR w KQ c6";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/5n2/1ppP4/2P5/5N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3p1p/3p1np1/2pP4/4P3/2N2N2/PP3PPP/R1BQKB1R b KQkq e3";
            moveLine = @"a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/2p1bppp/p1n1b3/1pnpP3/8/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
            moveLine = @"b3c2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/5n2/1PpP4/8/8/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"a7a6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1pq2ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1n1ppp/2n1p3/3pP3/3p1P2/2N1BN2/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"f3d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1pp1pppp/p7/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
            moveLine = @"c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp1b1ppp/4p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 b kq a3";
            moveLine = @"a8b8{10} c8b7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp2pbp/n2p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/pq1ppn2/6B1/4PP2/1NN5/PPP3PP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p2p1/3Pp3/1PP1Pn2/2N2N2/P3BPPP/R1BQR1K1 w - -";
            moveLine = @"e2f1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPP1BPPP/R2QK2R b KQkq -";
            moveLine = @"h6h5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p2B1/1b1PP3/2N5/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"e4e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/8/1b1NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/2N3P1/PP2PPBP/R1BQK1NR w KQ -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2npp3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2pbp/3p1np1/8/2PpP3/2N1BN2/PP2BPPP/R2QK2R w KQ -";
            moveLine = @"f3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/8/4p3/2pPP3/5N2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"e5d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1npbp/1p1p1np1/p2Pp3/1PP1P3/B1N2N2/P3BPPP/R2Q1RK1 w - -";
            moveLine = @"b4a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqr1k1/ppp2pbp/3p1np1/8/2PNP3/2N5/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppppbppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1p1ppp/n3pn2/2P5/1bP5/P1N2N2/1PQ1PPPP/R1B1KB1R b KQ -";
            moveLine = @"b4c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p2p1ppp/bp2pn2/2p5/2PP4/P4N2/1PQ1PPPP/RNB1KB1R w KQkq c6";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkbnr/pp1npppb/2p4p/7P/3P4/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/3P4/5NP1/PPP1PP1P/RNBQKB1R w KQkq -";
            moveLine = @"f1g2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2p1ppp/4pn2/1ppP4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq b6";
            moveLine = @"d5e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pp2/p2p3p/6p1/3NP1nB/2N5/PPP2PPP/R2QKB1R w KQkq g6";
            moveLine = @"h4g3{52}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"f8e7{60}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1p2bppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
            moveLine = @"f2f4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/2n5/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 b kq c3";
            moveLine = @"c6b4{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR b KQ -";
            moveLine = @"h7h6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2N2/PPQPPPPP/R1B1KB1R b KQkq -";
            moveLine = @"e8g8{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"g2g4{22} d1d2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bppp/4pn2/3p4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R b KQ -";
            moveLine = @"c7c5{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp2ppbp/2n3p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R w KQkq -";
            moveLine = @"c1e3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP2NPPP/R1BQKB1R b KQ -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/3ppppp/P4n2/2pP4/8/8/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1bpp1/4pn1p/3p4/2PP3B/2N1PN2/PP3PPP/R2QKB1R b KQ -";
            moveLine = @"b7b6{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1P3/PP2NPPP/R1BQKB1R b KQkq -";
            moveLine = @"c5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/8/2pP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
            moveLine = @"d3c4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p2p1n2/np2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
            moveLine = @"b3c2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq b6";
            moveLine = @"g2g4{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/3n1ppp/p2pbn2/1p2p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R w KQkq b6";
            moveLine = @"g4g5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p1p1ppp/p3p3/8/3pP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp2ppbp/2pp2p1/8/3PPP2/2N5/PPP3PP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/ppp1pppp/8/3p4/6b1/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
            moveLine = @"b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pb1pbppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
            moveLine = @"f1e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p3/3p1b2/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1n1pp1/2p1pq1p/8/2BP4/2N1PN2/PP3PPP/R2QK2R b KQkq -";
            moveLine = @"g7g6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3p1p/3p1np1/2pP4/8/2N2N1P/PP2PPP1/R1BQKB1R b KQkq -";
            moveLine = @"f8g7{5} a7a6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/1p1b1ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"f4f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"1rbqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 w k -";
            moveLine = @"c2c3{15} a4b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/1p2bpp1/p1nppn1p/8/3NP3/2N1B3/PPPQ1PPP/2KR1B1R w kq -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 w - -";
            moveLine = @"a2a3{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2np1n2/1N2p1B1/4P3/2N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"a7a6{62}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1np1n2/4p1B1/4P3/N1N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"b7b5{57}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"1rbqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1BP2N2/1P1P1PPP/RNBQ1RK1 b k -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/5np1/8/2pP4/5NP1/PP2PPBP/RNBQ1RK1 w - -";
            moveLine = @"b1a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2bppp/4pn2/2Pp4/2P2B2/2N1PN2/PP3PPP/R2QKB1R b KQ -";
            moveLine = @"e7c5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1pp1/p2pbn1p/4p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R w KQkq -";
            moveLine = @"d1d2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1npppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"d2d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq d6";
            moveLine = @"g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5ppp/p1np1B2/1p2p3/4P3/N1N5/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"g7f6{36}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP1P1/2N1B3/PPP2P1P/R2QKB1R b KQkq g3";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/2b1p3/2B1P3/2P2N2/PP1P1PPP/RNBQK2R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/1p1p1ppp/pq2p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"d4b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1npbp/3p2p1/3Pp2n/1PP1P3/2N2N2/P3BPPP/R1BQR1K1 b - -";
            moveLine = @"f7f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1B3/PPPQ1PPP/R3KB1R w KQkq -";
            moveLine = @"f2f3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5ppp/p1np1n2/1p2p1B1/4P3/N1N5/PPP2PPP/R2QKB1R w KQkq b6";
            moveLine = @"g5f6{45} c3d5{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/1p3ppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{10} b8d7{15} h7h5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/6p1/2p5/3PP3/2P2N2/P4PPP/R1BQKB1R w KQkq c6";
            moveLine = @"a1b1{15} h2h3{5} c1e3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2ppp/p1np1n2/1p1Pp3/4P3/1BP2N1P/PP1N1PP1/R1BQR1K1 b - -";
            moveLine = @"c6b8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppppbppp/2n5/1B2p3/3Pn3/5N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"d4e5{5} d1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2bppp/2nppn2/6B1/3NP3/2N2P2/PPPQ2PP/2KR1B1R b - -";
            moveLine = @"c6d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f1c4{5} f1e2{16} h2h3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R b KQkq -";
            moveLine = @"d8c7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/8/3PP3/2n2N2/PP3PPP/R1BQKB1R w KQkq -";
            moveLine = @"b2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1p2ppp/bp1bpn2/3p4/2PP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/1bP5/P1N2N2/1PQPPPPP/R1B1KB1R b KQ -";
            moveLine = @"b4c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1pp1/2pbp2p/8/3Pn3/3B1N2/PPP1QPPP/R1B1K2R w KQkq -";
            moveLine = @"e2e4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1n1ppp/2p1p3/6N1/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1p1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP2BPPP/R2QK2R b KQ -";
            moveLine = @"c8b7{5} b8d7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1p3/2pn4/3P4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N1B3/PPP2PPP/R2QK2R b KQkq -";
            moveLine = @"f8e7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppppppbp/5np1/8/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p5/5b2/3P4/6N1/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"f5g6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/pp1pppbp/5np1/q1p5/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
            moveLine = @"b1c3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5ppp/p1np1n2/1p1Np1B1/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"f8e7{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1pppbp/2p2np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
            moveLine = @"b1c3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/1pqp1ppp/p3p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{6} f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/P1N5/1PQ1PPPP/R1B1KBNR b KQkq -";
            moveLine = @"b4c3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
            moveLine = @"d7d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1ppbp/n4np1/8/2QPP3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
            moveLine = @"c7c5{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3pp1/2p1p1bp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"f3e5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppppp/2n2n2/8/2PN4/8/PP2PPPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2np1n2/4p3/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq e6";
            moveLine = @"d4b3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2P5/1bP5/2N5/PPQ1PPPP/R1B1KBNR w KQ -";
            moveLine = @"a2a3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2b5/2P5/P1N5/1PQ1PPPP/R1B1KBNR w KQ -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pppbpp1p/5np1/3p4/Q1P5/2N2N2/PP1PPPPP/R1B1KB1R w KQkq -";
            moveLine = @"a4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n1p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/ppp2ppp/2np4/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n5/2p1p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq e6";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/bp1p1ppp/p3p3/8/4P3/1N1B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/ppp1bppp/2n5/3p4/3Pn1b1/3B1N2/PPP2PPP/RNBQR1K1 w kq -";
            moveLine = @"c2c3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/8/3p4/1nPPn3/3B1N2/PP3PPP/RNBQ1RK1 w kq -";
            moveLine = @"d3e2{51} f1e1{5} c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2QK2R w KQ -";
            moveLine = @"e1g1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1pp1npbp/3p1np1/3Pp3/1pP1P3/B1N2N2/P3BPPP/R2Q1RK1 w - -";
            moveLine = @"a3b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/8/2p5/3P4/2n2N2/PP2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"b2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/5ppp/p1pb4/1p1nR3/8/1BPP4/PP3PPP/RNBQ2K1 w - -";
            moveLine = @"e5e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2pn4/4p3/3P4/5N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"d4e5{45}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/4pn2/3p4/1bPPP3/2N5/PPQ2PPP/R1B1KBNR w KQ d6";
            moveLine = @"e4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/8/2pP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
            moveLine = @"b7b5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/8/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e5d7{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/2pnppbp/p5p1/1p2P3/3P4/1QN2N2/PP3PPP/R1B1KB1R w KQ -";
            moveLine = @"e5e6{11} h2h4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq c6";
            moveLine = @"f1g2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/5np1/3p4/Q1P5/2N2N2/PP1PPPPP/R1B1KB1R b KQkq -";
            moveLine = @"c8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/3n1ppp/p2pbn2/4p1P1/1p2P3/1NN1BP2/PPP4P/R2QKB1R w KQkq -";
            moveLine = @"c3e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"d1d8{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/4pn2/2p5/2BP4/4PN2/PP3PPP/RNBQK2R w KQkq c6";
            moveLine = @"e1g1{35}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1R1K b - -";
            moveLine = @"b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n1b3/1pnpP3/8/1BP2N2/PP1N1PPP/R1BQ1RK1 b kq -";
            moveLine = @"d5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1n2n2/1p1Pp3/8/1BP2N2/PP1P1PPP/RNBQR1K1 b - -";
            moveLine = @"f6d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/B3P3/2P2N2/PP1P1PPP/RNBQ1RK1 w kq b6";
            moveLine = @"a4c2{25} d2d4{5} a4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1nppp/4p3/3pP3/3P4/P1b5/1PP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"b2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/ppp1b1pp/2n5/3p1p2/3Pn1b1/2PB1N2/PP3PPP/RNBQR1K1 w kq f6";
            moveLine = @"d1b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p3pp1p/2pp1np1/1p6/3PP3/2N1BP2/PPP3PP/R2QKBNR w KQkq b6";
            moveLine = @"g2g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"1rbqk2r/2p2ppp/p1np1n2/1pb1p3/P3P3/1BP2N2/1P1P1PPP/RNBQ1RK1 w k -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1ppp1p1p/p1n3p1/1B2p3/4P3/2P2N2/PP1P1PPP/RNBQK2R w KQkq -";
            moveLine = @"b5a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/3n4/4P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
            moveLine = @"d5c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/3p1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQ -";
            moveLine = @"d1d2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQ d3";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1pp1/p2pbn2/4p2p/4P3/1NN1BP2/PPPQ2PP/R3KB1R w KQkq h6";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p2B1/3PP3/2N5/PPP2PPP/R2QKBNR b KQkq -";
            moveLine = @"d5e4{30} f8b4{5} f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2nppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbpp1pp1/1p2pn1p/6B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR w KQ -";
            moveLine = @"g5h4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bk1b1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNB2RK1 w - -";
            moveLine = @"b1c3{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 w kq -";
            moveLine = @"d1e2{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2P5/1bP5/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p3ppp/p1n1pn2/2p5/2BP4/4PN2/PP2QPPP/RNB2RK1 w kq -";
            moveLine = @"a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"g5f6{42}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p2B1/2PP4/2N5/PP2PPPP/R2QKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pppp1ppp/4pn2/8/2P5/P1Q2N2/1P1PPPPP/R1B1KB1R b KQ -";
            moveLine = @"b7b6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/3p1n2/8/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/2b1p3/1PB1P3/5N2/P1PP1PPP/RNBQK2R b KQkq b3";
            moveLine = @"c5b6{5} c5b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/P3P3/1B3N2/1PPP1PPP/RNBQR1K1 b - a3";
            moveLine = @"b5b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{17} d8b6{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP2PPP/R1BQKBR1 b Qkq -";
            moveLine = @"b7b5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppppp/5n2/4P3/8/8/PPPP1PPP/RNBQKBNR b KQkq -";
            moveLine = @"f6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppp1pppp/2n5/3q4/3P4/8/PP2PPPP/RNBQKBNR w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"d7d6{5} d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/4pppp/p2p1n2/1p6/3NP1P1/2N5/PPP2P1P/R1BQKBR1 b Qkq g3";
            moveLine = @"c8b7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p4np1/8/2QPP3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQR1K1 b kq -";
            moveLine = @"c8g4{10} c8f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/4bppp/p2p1n2/npp1p3/4P3/2P2N1P/PPBP1PP1/RNBQR1K1 w - c6";
            moveLine = @"d2d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pppb1ppp/8/3p4/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"d1d2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/6p1/2p5/3P4/2P2N2/P3PPPP/R1BQKB1R w KQkq -";
            moveLine = @"e2e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/3ppn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
            moveLine = @"c1g5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2ppbp/5np1/2Pp4/2P2B2/2N1P3/PP3PPP/R2QKBNR b KQkq -";
            moveLine = @"d8a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/5n2/3pp3/2P5/6P1/PP1PPPBP/RNBQK1NR w KQkq d6";
            moveLine = @"c4d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/2pP4/8/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
            moveLine = @"f6d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/2pnp1bp/p3p1p1/1p6/3P4/1QN2N2/PP3PPP/R1B1KB1R w KQ -";
            moveLine = @"c1e3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/4bppp/p1np1n2/1p1Np1B1/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"g5f6{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
            moveLine = @"f6e4{35} f8c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5p1p/p1np1p2/1p2p3/4P3/N1N5/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"c3d5{40}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p4/6pp/3NP1B1/2N3B1/PPP2PPP/R2QK2R b KQkq -";
            moveLine = @"h5g4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2n2n2/3p4/2Pp4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
            moveLine = @"f3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3pP3/3P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"f6d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppp1p/2n3p1/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5p1p/p1np1p2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"f6f5{15} f8g7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/4pppp/p2p1n2/1p6/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq b6";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p4/6pp/3NP1n1/2N3B1/PPP1BPPP/R2QK2R w KQkq -";
            moveLine = @"e2g4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppppppbp/2n2np1/8/2PP4/2N3P1/PP2PPBP/R1BQK1NR w KQ -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppp1p/6p1/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
            moveLine = @"b7b6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/8/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"b8d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p3bppp/bpp1pn2/3pN3/2PP4/1PB3P1/P3PPBP/RN1QK2R b KQkq -";
            moveLine = @"f6d7{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/p2p1ppp/1p2pn2/2p5/1bPP4/PQN2N2/1P2PPPP/R1B1KB1R b KQkq -";
            moveLine = @"b4a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/1BP2N2/PP1P1PPP/RNBQ1RK1 b kq -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2N2n2/8/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"b7c6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2ppbp/n4np1/2pP4/2Q1P3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
            moveLine = @"e7e6{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/4N3/2pP4/2N5/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"b8d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/2p2n2/8/2NP4/2N5/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p2Nbppp/bpp1p3/3p4/2PP4/1PB3P1/P3PPBP/RN1QK2R b KQkq -";
            moveLine = @"b8d7{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp3pbp/n3pnp1/2pP4/2Q1P3/2N2N2/PP2BPPP/R1B2RK1 b - -";
            moveLine = @"e6d5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pn2/3P4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
            moveLine = @"d8d5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2N5/2b5/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"d8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2pppp/2p2n2/3p1b2/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp2pppp/2np4/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
            moveLine = @"d2d4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p3pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 w kq -";
            moveLine = @"d4c5{10} c4b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/ppp1bppp/2n5/3p1b2/3Pn3/3B1N2/PPP2PPP/RNBQR1K1 w kq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1ppp/2pbpn2/8/2BP4/2N1PN2/PPQ2PPP/R1B2RK1 b - -";
            moveLine = @"a7a6{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/4p3/3p4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"e4e5{10} f1d3{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R b KQkq g3";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p4/6p1/3NP1p1/2N3B1/PPP2PPP/R2QK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1pp1ppp/1p2pn2/8/2P5/P1Q2N2/1P1PPPPP/R1B1KB1R w KQ -";
            moveLine = @"g2g3{5} e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1P1/2N4P/PPP2P2/R1BQKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2N2NP1/PP2PP1P/R1BQKB1R w KQ -";
            moveLine = @"f1g2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1bppp/8/3p4/1nPPn3/5N2/PP2BPPP/RNBQ1RK1 w - -";
            moveLine = @"b1c3{41}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1bppp/4p3/3pP3/3P4/8/PPPN1PPP/R1BQKBNR b KQkq -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/p3pppp/2p5/1p6/2pPP3/2N5/PP3PPP/R1BQKBNR w KQkq b6";
            moveLine = @"a2a4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/ppp2ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 w - -";
            moveLine = @"h2h3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/p1ppqppp/2p5/3nP3/8/8/PPP1QPPP/RNB1KB1R w KQkq -";
            moveLine = @"c2c4{18}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppn1ppp/4p3/3pP3/3P1P2/2N5/PPP3PP/R1BQKBNR b KQkq f3";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2ppp1/2p2nbp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"f3e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B1P1N2/PPP2PPP/RNBQR1K1 b - -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp2pppp/2n2n2/2pp4/2PP4/2N2NP1/PP2PP1P/R1BQKB1R b KQkq d3";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPPQ1PPP/R3KB1R b KQkq -";
            moveLine = @"b8c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/ppp1bppp/2n5/3p4/3Pn1b1/2PB1N2/PP3PPP/RNBQR1K1 b kq -";
            moveLine = @"f7f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bppbppp/p1n2n2/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 b - -";
            moveLine = @"h7h6{10} d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/8/8/2ppP3/5N2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1p2bppp/p1nppn2/8/P2NP3/2N1B3/1PP1BPPP/R2Q1RK1 w - -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n2n2/1Bb1p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"c2c3{10} f3e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N3P1/PPPP1P1P/R1BQKBNR b KQkq -";
            moveLine = @"b8c6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/3nppbp/p5p1/1pp1P3/3P3P/1QN2N2/PP3PP1/R1B1KB1R w KQ c6";
            moveLine = @"e5e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbp2ppp/1p1ppn2/6B1/2PP4/P1Q1P3/1P3PPP/R3KBNR w KQ -";
            moveLine = @"g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbp2pp1/1p2pn1p/3p4/2PP3B/P1Q2P2/1P2P1PP/R3KBNR w KQ d6";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5ppp/p2ppn2/1p6/3NP1P1/2N1BP2/PPP4P/R2QKB1R b KQkq g3";
            moveLine = @"h7h6{17}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p3b1/8/3P3P/6N1/PPP2PP1/R1BQKBNR b KQkq h3";
            moveLine = @"h7h6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2p5/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq c6";
            moveLine = @"f1c4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/6p1/2p5/3PP3/2P2N2/P4PPP/1RBQKB1R w K -";
            moveLine = @"f1e2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/R3KB1R b KQkq -";
            moveLine = @"b8d7{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 w - -";
            moveLine = @"c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N3P1/PPPP1P1P/R1BQKBNR b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2Q1RK1 b - -";
            moveLine = @"c8g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p2p1n2/np2p3/4P3/PB1P1N1P/1PP2PP1/RNBQR1K1 w - -";
            moveLine = @"b3a2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
            moveLine = @"c5d4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/2p5/1bP5/1QN2N2/PP1PPPPP/R1B1KB1R w KQkq c6";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQ1RK1 b - -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppppp1p/5np1/8/8/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp1n1pp1/2pbpn1p/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
            moveLine = @"b2b3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppN1ppp/8/3p4/3Pn3/3B4/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"c8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pppp1ppp/2n5/1Bb1p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5} c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pbpp1p1p/1p2pnp1/8/2PP4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"d1c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/3pP3/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"c7c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/3P4/5NP1/PPP1PPBP/RNBQK2R w KQkq d6";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2P5/5NP1/PP1PPPBP/RNBQK2R w KQkq d6";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppnbppp/4pn2/3p4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"f1e2{6} c4c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbppbppp/1p2pn2/8/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w - -";
            moveLine = @"f1e1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/3p4/2p5/4PP2/2N5/PPPP2PP/R1BQKBNR b KQkq f3";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/2p1pn2/5b2/P1BP4/2N1PN2/1P3PPP/R1BQK2R b KQkq -";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 w - -";
            moveLine = @"c2c4{22}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp3ppp/2n1pn2/2pp4/1bPP4/P1NBPN2/1P3PPP/R1BQ1RK1 b - -";
            moveLine = @"b4c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1pp1/2pbpn1p/8/3PN3/3B1N2/PPP1QPPP/R1B1K2R b KQkq -";
            moveLine = @"f6e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"e8g8{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn2k2r/pp3ppp/2p1p3/4N3/Pbpqn3/2N5/1P1B2PP/R2QKB1R w KQkq -";
            moveLine = @"c3e4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3P4/3P4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"f6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/6P1/PP1PPPBP/RNBQK1NR w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp3ppp/4p3/b1ppP3/3P4/P1N5/1PP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"b2b4{20} d1g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/5pbp/p1np1p2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f1d3{10} c2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/8/3p4/1nPPn3/5N2/PP2BPPP/RNBQ1RK1 b kq -";
            moveLine = @"e8g8{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2pP4/8/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g7g6{5} b7b5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/1p1p1ppp/p1n1p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"d4c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/2p1bppp/p1n1b3/1pn1P3/3p4/2P2N2/PPBN1PPP/R1BQ1RK1 w kq -";
            moveLine = @"c3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pb2/8/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"g1f3{26}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pp1p/6p1/3n4/3P4/2N5/PP1BPPPP/R2QKBNR b KQkq -";
            moveLine = @"f8g7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/pp1ppppp/1qn5/8/4P3/1N6/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2bppp/4pn2/2pp4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R w KQ c6";
            moveLine = @"d4c5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1bppp/8/3p4/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
            moveLine = @"c8e6{10} c8f5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR b KQkq -";
            moveLine = @"f8e7{20} b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/3p1n2/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r3kb1r/ppqnpppp/2p2n2/5b2/P1NP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
            moveLine = @"g2g3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/p1pp1ppp/1p2pn2/8/1PP5/P1Q2N2/3PPPPP/R1B1KB1R b KQ b3";
            moveLine = @"a7a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPP4P/R2QKB1R w KQkq -";
            moveLine = @"d1d2{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"d5c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp1p1ppp/4pn2/8/1bPN4/2N3P1/PP2PP1P/R1BQKB1R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/3b4/3p4/2PPn3/3B1N2/PP3PPP/RNBQK2R b KQkq c3";
            moveLine = @"d6b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/3P4/PPP2PPP/RNBQK1NR b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/p1ppqppp/1np5/4P3/2P5/8/PP2QPPP/RNB1KB1R w KQkq -";
            moveLine = @"b1c3{12}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppn1ppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"e4f6{5} g1f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/6p1/3n4/3P4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"d5b6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/ppp1bppp/4b3/3p4/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"f3e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5p1p/p1np4/1p1Npp2/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"c2c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp3ppp/4p3/b2pP3/1P1p4/P1N5/2P2PPP/R1BQKBNR w KQkq -";
            moveLine = @"c3b5{5} d1g4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p1n1p/6p1/3NP3/2N3BP/PPP2PP1/R2QKB1R w KQkq -";
            moveLine = @"f1c4{11} d1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/4p3/3P4/PPP1QPPP/RNB1KBNR w KQkq -";
            moveLine = @"d3e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/ppp1bppp/2n1p3/3p4/3PP3/3B4/PPPN1PPP/R1BQK1NR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1ppppp/1qn2n2/8/4P3/1N1B4/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3pp1/2np1n1p/4p3/4P3/1NN2P2/PPP3PP/R1BQKB1R w KQkq -";
            moveLine = @"c1e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1p1n1ppp/p1pbpn2/8/P1BP4/2N1PN2/1PQ2PPP/R1B2RK1 b - a3";
            moveLine = @"c6c5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/p1pp1ppp/1np1q3/4P3/2P5/2N5/PP2QPPP/R1B1KB1R w KQkq -";
            moveLine = @"e2e4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1BP2/PPPQ2PP/R3KB1R b KQkq -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qrbk1/1bp2ppp/p2p1n2/np2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 w - -";
            moveLine = @"b3a2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1ppppp/2n5/8/2PN4/8/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/1p3ppp/p7/2pp4/3P4/5N2/PPPN1PPP/R1BQKB1R w KQkq -";
            moveLine = @"f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/3b4/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 b - c3";
            moveLine = @"c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1ppppp/8/2p5/4P3/1P6/P1PP1PPP/RNBQKBNR b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1pq2ppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R w KQkq -";
            moveLine = @"a2a4{5} a2a3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bp1p/4pp2/8/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"g1f3{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1pp1bp1p/p3pp2/8/3PN3/5N2/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq d3";
            moveLine = @"d5e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/ppp1bppp/8/3p1b2/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
            moveLine = @"a2a3{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"g2g4{21}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k1nr/ppq2ppp/4p3/2ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
            moveLine = @"d1g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/3P4/PPP2PPP/RNBQKBNR w KQkq c6";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3BP/PPP2PP1/R2QKB1R b KQkq -";
            moveLine = @"g4f6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p1n5/1p1nN3/8/1BP5/PP1P1PPP/RNBQR1K1 b - -";
            moveLine = @"c6e5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/2p2ppp/p1n5/1pnpP3/6b1/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
            moveLine = @"b3c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp3ppp/2p1pn2/4Nb2/P1pP4/2N2P2/1P2P1PP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppn1ppp/4pb2/8/3PN3/5N2/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/1p1npppp/p2p1n2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
            moveLine = @"f2f3{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/pp2bppp/4p3/2pp4/3PP3/3B4/PPPN1PPP/R1BQK1NR w KQkq c6";
            moveLine = @"d4c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/1p1n1ppp/p1pbpn2/8/2BP4/2N1PN2/PPQ2PPP/R1BR2K1 b - -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/2N1BP2/PPPQ2PP/R3KB1R b KQkq -";
            moveLine = @"b8d7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/3p4/8/4n3/3B1N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"e4f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/1pqp1ppp/p3p3/8/4P3/1N1B4/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kbnr/pp3ppp/4p3/2pq4/3P4/5N2/PPPN1PPP/R1BQKB1R b KQkq -";
            moveLine = @"c5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/5n2/2pp4/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq d6";
            moveLine = @"d2d4{5} c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp1Bpppp/3p4/2p5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
            moveLine = @"d8d7{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pp1pppbp/2n3p1/1Bp5/4P3/2P2N2/PP1P1PPP/RNBQ1RK1 b kq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppp1ppp/2n2n2/1Bb1p3/4P3/2P2N2/PP1P1PPP/RNBQ1RK1 w - -";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/4PP2/8/PPPP2PP/RNBQKBNR b KQkq f3";
            moveLine = @"e5f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppqppppp/2n5/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pB2/8/3PN3/8/PPP2PPP/R2QKBNR b KQkq -";
            moveLine = @"e7f6{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/P2NP3/2N1B3/1PP2PPP/R2QKB1R b KQkq a3";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p4np1/8/3PP3/1QN2N2/PP3PPP/R1B1KB1R b KQ -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp2pp1p/2p3p1/2p5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"d2d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1n1ppp/4p3/2ppP3/3P4/8/PPP1NPPP/R1BQKBNR w KQkq c6";
            moveLine = @"c2c3{10} f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/4bppp/p1np1B2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"e7f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppppppp/8/8/8/2N5/PPPPPPPP/R1BQKBNR b KQkq -";
            moveLine = @"c7c5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/2n2n2/3p4/2PP4/3B1N2/PP3PPP/RNBQ1RK1 w kq -";
            moveLine = @"h2h3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1p1pp/3p1n2/5p2/3P4/5NP1/PPP1PPBP/RNBQK2R b KQkq -";
            moveLine = @"g7g6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppnbppp/5n2/3p2B1/3P4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/1nn5/4p3/8/2N2NP1/PP1PPPBP/R1BQK2R w KQkq -";
            moveLine = @"e1g1{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbpp1ppp/1p2pn2/8/1bPP4/1P3NP1/P2BPPBP/RN1QK2R b KQkq -";
            moveLine = @"a7a5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1npppp/3p1n2/1Bp5/3PP3/5N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"c5d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/4p3/8/4P3/3P4/PPP2PPP/RNBQKBNR b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/5np1/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R w KQ -";
            moveLine = @"a1c1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/p1pp1ppp/2p2n2/4P3/8/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"d8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3pp1/2p1pn1p/8/2pP3B/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
            moveLine = @"e2e4{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/4P3/3P4/PPPN1PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp2pppp/2np4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppnbppp/5n2/3p2B1/3P4/2NBP3/PP3PPP/R2QK1NR w KQ -";
            moveLine = @"g1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2pppb/2p2n1p/4N3/3P3P/6N1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/8/3np3/8/6P1/PP1PPPBP/RNBQK1NR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/ppp1bppp/4b3/3pN3/1nPPn3/2N5/PP2BPPP/R1BQ1RK1 b - -";
            moveLine = @"f7f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
            moveLine = @"c7c6{5} f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/ppp2ppp/2n5/3p4/3Pn1b1/3B1N2/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/pp2nppp/4p3/b2pP3/1P1p2Q1/P1N5/2P2PPP/R1B1KBNR w KQkq -";
            moveLine = @"b4a5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3p2/2p1pn1p/6p1/2pPP2B/2N2N2/PP3PPP/R2QKB1R w KQkq g6";
            moveLine = @"h4g3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2pp1/4pn1p/3pP1B1/1b1P4/2N5/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"g5d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk1nr/pp2ppbp/2p3p1/2p5/4P3/3P1N2/PPP2PPP/RNBQK2R w KQkq -";
            moveLine = @"h2h3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
            moveLine = @"e3e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pp3ppp/2p1pn2/4Nb2/PbpPP3/2N2P2/1P4PP/R1BQKB1R b KQkq e3";
            moveLine = @"f5e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"f1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/p1pp1ppp/bp2pn2/8/Q1PP4/5NP1/PP2PP1P/RNB1KB1R b KQkq -";
            moveLine = @"f8e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/3B4/PPP2PPP/RNBQ1RK1 w kq -";
            moveLine = @"c2c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppp/2p1p1b1/3pP3/3P2P1/2N5/PPP2P1P/R1BQKBNR w KQkq -";
            moveLine = @"g1e2{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pppp1ppp/2n5/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk1nr/ppp1ppbp/3p2p1/8/2PPP3/8/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/ppp1ppbp/n2p1np1/6B1/2PPP3/2N5/PP2BPPP/R2QK1NR w KQ -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/3n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/R3KB1R w KQkq -";
            moveLine = @"e1c1{16}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 b kq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/pp1n1p2/2p1pqpp/8/2BP4/2N1PN2/PP3PPP/R2Q1RK1 b kq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 b kq f3";
            moveLine = @"e8g8{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1ppppp/5n2/2p5/3P4/2P2N2/PP2PPPP/RNBQKB1R b KQkq -";
            moveLine = @"e7e6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp2ppp/4pb2/8/3PN3/5N2/PPP2PPP/R2QKB1R b KQkq -";
            moveLine = @"b8d7{5} e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/pbppbppp/1p2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq -";
            moveLine = @"f1g2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp1n1ppp/4p3/3pP3/3p4/2P5/PP2NPPP/R1BQKBNR w KQkq -";
            moveLine = @"c3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pp2ppbp/2n2np1/3p4/3NP3/2N1BP2/PPPQ2PP/2KR1B1R w - -";
            moveLine = @"e4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2k1b1r/pppb1ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 w - -";
            moveLine = @"b2b3{5} f1d1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp2pppp/2p5/3p4/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp2ppbp/6p1/8/3pP3/2P2N2/P3BPPP/1RBQK2R w K -";
            moveLine = @"c3d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp1p1ppp/2n1p3/1N6/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
            moveLine = @"d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
            moveLine = @"d4f5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/3n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/2KR1B1R b kq -";
            moveLine = @"c8b7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 w kq -";
            moveLine = @"f2f4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n5/1B2p3/3Pn3/5N2/PPP2PPP/RNBQ1RK1 b kq d3";
            moveLine = @"e4d6{30}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2Bn4/4p3/3P4/5N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"d7c6{25}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1q1rk1/pbpp1pp1/1p2pn1p/8/2PP3B/P1Q2P2/1P2P1PP/R3KBNR b KQ -";
            moveLine = @"d7d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/ppp2ppp/2pn4/4P3/8/5N2/PPP2PPP/RNBQ1RK1 b kq -";
            moveLine = @"d6f5{20}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/1bpp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"d2d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp2ppp/4pn2/3p4/1bPP4/2NBPN2/PP3PPP/R1BQK2R b KQ -";
            moveLine = @"c7c5{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/5NP1/PP1PPPBP/RNBQK2R b KQkq -";
            moveLine = @"c8b7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2NQ4/PPP2PPP/R3KB1R b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pp1p/5np1/3p4/3P4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1Q1RK1 b kq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p2ppppp/5n2/1ppP2B1/8/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
            moveLine = @"f6e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn2k2r/pp3ppp/2p1p3/4N3/Pbp1q3/8/1P1B2PP/R2QKB1R w KQkq -";
            moveLine = @"d1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pppb1ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/5p1p/p1np4/1p1Npp2/4P3/N1P5/PP3PPP/R2QKB1R b KQkq -";
            moveLine = @"f8g7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1pn2/2pp4/2P5/2N2NP1/PP1PPPBP/R1BQK2R w KQkq d6";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2pnbppp/p2p1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
            moveLine = @"b1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp3ppp/2n1pn2/8/2Bp4/4PN2/PP2QPPP/RNB2RK1 w kq -";
            moveLine = @"f1d1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r4rk1/1bpqbppp/p1np1n2/1p2p3/4P3/PB1P1N1P/1PP2PP1/RNBQR1K1 w - -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppn1ppp/4pb2/8/3PN3/5N2/PPPQ1PPP/R3KB1R w KQ -";
            moveLine = @"e1c1{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1bppp/4pn2/3p2B1/3PP3/2N5/PPP2PPP/R2QKBNR w KQkq -";
            moveLine = @"e4e5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/p4p2/2p1pn1p/1p4p1/2pPP3/2N2NB1/PP3PPP/R2QKB1R w KQkq b6";
            moveLine = @"f1e2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/1p1nbppp/p2pbn2/4p3/4P3/1NN1BP2/PPPQ2PP/R3KB1R w KQkq -";
            moveLine = @"g2g4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3ppb/2p1p2p/4N3/3P3P/6N1/PPP2PP1/R1BQKB1R w KQkq -";
            moveLine = @"f1d3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pppp1ppp/2n1pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkbnr/pp3pp1/2p1p2p/4N3/3P3P/3b2N1/PPP2PP1/R1BQK2R w KQkq -";
            moveLine = @"d1d3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP2N1PP/R1BQKB1R b KQ -";
            moveLine = @"c7c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/2q2ppp/p2ppn2/1p6/3NP3/P1N1B3/1PP1BPPP/R2QK2R w KQkq b6";
            moveLine = @"d1d2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/p3pn2/2P5/2B5/4PN2/PP3PPP/RNBq1RK1 w kq -";
            moveLine = @"f1d1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/pppnbppp/4p3/8/3PN3/5N2/PPPQ1PPP/2KR1B1R w - -";
            moveLine = @"f1c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2nppp/2p1p1b1/3pP3/3P2P1/2N5/PPP1NP1P/R1BQKB1R w KQkq -";
            moveLine = @"e2f4{11}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/pp2pppp/2p2n2/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
            moveLine = @"d2d4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/ppp1bppp/8/3p1b2/1nPPn3/P1N2N2/1P2BPPP/R1BQ1RK1 b - -";
            moveLine = @"e4c3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2p2ppp/p1np1n2/1pb1p3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 w kq -";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/ppp1bppp/8/3p1b2/1nPP4/P1n2N2/1P2BPPP/R1BQ1RK1 w - -";
            moveLine = @"b2c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1b2bppp/p2p1n2/npp1p3/3PP3/2P2N1P/PPB2PP1/RNBQR1K1 w - -";
            moveLine = @"d4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/2p2ppp/p1n2n2/1pbpp3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 w kq d6";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2N1B3/PPP1BPPP/R2Q1RK1 b kq -";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/pp2ppbp/6p1/q1p5/3PP3/2P1BN2/P4PPP/R2QKB1R w KQkq -";
            moveLine = @"d1d2{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bQkb1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNB2RK1 b kq -";
            moveLine = @"e8d8{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1P3NP1/P2BPPBP/RN1Q1RK1 b kq -";
            moveLine = @"d7d5{15}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bk1b1r/ppp2ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 b - -";
            moveLine = @"c8d7{5} d8e8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1P3NP1/P2BPPBP/RN1Q1RK1 w kq d6";
            moveLine = @"d1c2{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp1p1ppp/4pn2/8/1bPP4/2N5/PP2NPPP/R1BQKB1R w KQ -";
            moveLine = @"a2a3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1p1ppp/2n1pn2/1N6/4P3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
            moveLine = @"f8b4{10} d7d6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1p1ppp/2n1pn2/1N6/1b2P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"a2a3{10}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
            moveLine = @"a7a6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/ppp1pppp/2n5/3P4/3P4/8/PP2PPPP/RNBQKBNR b KQkq -";
            moveLine = @"d8d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/1p3p1p/p2p1np1/2pP4/8/2N2N1P/PP2PPP1/R1BQKB1R w KQkq -";
            moveLine = @"a2a4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/ppp2ppp/4pn2/3q4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
            moveLine = @"e2e3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1b1k2r/pp2ppbp/2n3p1/q1p5/3PP3/2P1BN2/P2Q1PPP/R3KB1R w KQkq -";
            moveLine = @"a1c1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p3ppp/pq1ppn2/6B1/3NPP2/P1N5/1PP3PP/R2QKB1R b KQkq -";
            moveLine = @"b8c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/5pbp/p1np1p2/1p1Np3/4P3/N2B4/PPP2PPP/R2QK2R b KQkq -";
            moveLine = @"c6e7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3ppp/2pb4/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 w - -";
            moveLine = @"f1e1{5} d1c2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/8/2pPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq e3";
            moveLine = @"f8b4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp1pppp/5n2/3p2B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
            moveLine = @"f6e4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq d6";
            moveLine = @"c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3ppp/4pn2/2pp4/1bPP4/2NBPN2/PP3PPP/R1BQK2R w KQ c6";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bq1rk1/2p1bppp/p7/1p1nR3/8/1BP5/PP1P1PPP/RNBQ2K1 b - -";
            moveLine = @"c7c6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/pp3ppp/2n1p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkbnr/ppp1pppp/2n5/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
            moveLine = @"d5c4{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/3P1N2/PPP2PPP/RNBQK2R b KQkq -";
            moveLine = @"f8c5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/1b1n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/2KR1B1R w kq -";
            moveLine = @"h2h4{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1ppp1ppp/4pn2/p7/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq a6";
            moveLine = @"g2g3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/pppp1ppp/8/4p3/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
            moveLine = @"g8f6{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qkb1r/pp1npppp/2p2n2/5b2/P1NP4/2N5/1P2PPPP/R1BQKB1R b KQkq -";
            moveLine = @"f6d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkbnr/ppp2ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR b KQkq -";
            moveLine = @"b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/pp3ppp/4pn2/2bp4/2P2B2/2N1PN2/PP3PPP/R2QKB1R w KQ -";
            moveLine = @"a2a3{5} c4d5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1P3NP1/P1QBPPBP/RN3RK1 b kq -";
            moveLine = @"b8d7{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/1p2ppb1/pq1p1n1p/6p1/2BNP3/2N3BP/PPP2PP1/R2QK2R w KQkq -";
            moveLine = @"e1g1{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/ppp1bppp/1nn5/4p3/8/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
            moveLine = @"a1b1{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqkb1r/pp1ppp1p/2n2np1/8/2PNP3/8/PP3PPP/RNBQKB1R w KQkq -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqk2r/1p2bppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"d1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2qk2r/p2nbppp/bpp1p3/3p4/2PP4/1PB3P1/P2NPPBP/R2QK2R b KQkq -";
            moveLine = @"e8g8{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN1B3/PPPQ1PPP/R3KB1R w KQkq -";
            moveLine = @"f2f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbqkb1r/ppp2ppp/4pn2/8/2pP4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
            moveLine = @"g1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnbq1rk1/1pp1ppbp/p4np1/4P3/2QP4/2N2N2/PP3PPP/R1B1KB1R b KQ -";
            moveLine = @"b7b5{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1k2r/1p2bppp/pq1ppn2/6B1/4PP2/1NN5/PPP3PP/R2QKB1R w KQkq -";
            moveLine = @"d1f3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rnb1kb1r/1p2pppp/pq1p1n2/8/4P3/1NN2P2/PPP3PP/R1BQKB1R b KQkq -";
            moveLine = @"e7e6{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"rn1qkb1r/pp2nppp/4p1b1/2ppP3/3P1NP1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
            moveLine = @"d4c5{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r1bqk2r/pp1p1ppp/2n1pn2/1N6/4P3/P1b5/1PP2PPP/R1BQKB1R w KQkq -";
            moveLine = @"b5c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bp1bppp/p1np1n2/1p2p3/P3P3/1B1P1N2/1PP2PPP/RNBQR1K1 w - -";
            moveLine = @"b1d2{6}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            openingMove = new OpeningMove();
            openingMove.StartingFEN = @"r2q1rk1/1bppbpp1/p1n2n1p/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 w - -";
            moveLine = @"b1c3{5}";
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);
            moves = moveLine.Split(' ');
            foreach (string m in moves)
            {
                openingMove.Moves.Add(new MoveContent(m));
            }
            openingBook.Add(openingMove);

            return openingBook;
        }

        internal static int ValidateOpeningBook(List<OpeningMove> openingBook)
        {
            int failed = 0;

            foreach (OpeningMove moves in openingBook)
            {
                foreach (MoveContent move in moves.Moves)
                {
                    if (!IsValidMove(move.MovingPiecePrimary.SrcPosition, move.MovingPiecePrimary.DstPosition, moves.StartingFEN))
                    {
                        failed++;
                    }
                }
            }

            return failed;

        }

        private static bool IsValidMove(byte srcPos, byte dstPos, string fen)
        {
            Board chessBoard = new Board(fen);
            PieceValidMoves.GenerateValidMoves(chessBoard);


            if (chessBoard.Squares == null)
            {
                return false;
            }

            if (chessBoard.Squares[srcPos].Piece == null)
            {
                return false;
            }

            foreach (byte bs in chessBoard.Squares[srcPos].Piece.ValidMoves)
            {
                if (bs == dstPos)
                {
                    return true;
                }
            }

            if (dstPos == chessBoard.EnPassantPosition)
            {
                return true;
            }

            return false;
        }
    }

    internal class OpeningMove
    {
        public string EndingFEN;
        public string StartingFEN;
        public List<MoveContent> Moves;

        public OpeningMove()
        {
            StartingFEN = String.Empty;
            EndingFEN = String.Empty;
            Moves = new List<MoveContent>();
        }
    }
}