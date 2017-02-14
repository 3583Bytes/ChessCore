using System;
using System.Collections.Generic;

namespace ChessEngine.Engine
{
    public class PGN
    {
        public enum Result
        {
            White,
            Black,
            Tie,
            Ongoing
        }


        public static string GeneratePGN(Stack<MoveContent> moveHistory, int round, string whitePlayer, string blackPlayer, Result result)
        {
            int count = 0;

            string pgn = "";

            /*
                [Event "F/S Return Match"]
                [Site "Belgrade, Serbia Yugoslavia|JUG"]
                [Date "1992.11.04"]
                [Round "29"]
                [White "Fischer, Robert J."]
                [Black "Spassky, Boris V."]
                [Result "1/2-1/2"]
            */

            string pgnHeader = "";

            pgnHeader += "[Date \"" + DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day + "\"]\r\n";
            pgnHeader += "[White \"" + whitePlayer + "\"]\r\n";
            pgnHeader += "[Black \"" + blackPlayer + "\"]\r\n";

            if (result == Result.Ongoing)
            {
                pgnHeader += "[Result \"" + "*" + "\"]\r\n";
            }
            else if (result == Result.White)
            {
                pgnHeader += "[Result \"" + "1-0" + "\"]\r\n";
            }
            else if (result == Result.Black)
            {
                pgnHeader += "[Result \"" + "0-1" + "\"]\r\n";
            }
            else if (result == Result.Tie)
            {
                pgnHeader += "[Result \"" + "1/2-1/2" + "\"]\r\n";
            }

            foreach (MoveContent move in moveHistory)
            {
                string tmp = "";

                if (move.MovingPiecePrimary.PieceColor == ChessPieceColor.White)
                {
                    tmp += ((moveHistory.Count / 2) - count + 1) + ". ";
                }

                tmp += move.ToString();
                tmp += " ";

                tmp += pgn;
                pgn = tmp;

                if (move.MovingPiecePrimary.PieceColor == ChessPieceColor.Black)
                {
                    count++;
                }
            }

            if (result == Result.White)
            {
                pgn += " 1-0";
            }
            else if (result == Result.Black)
            {
                pgn += " 0-1";
            }
            else if (result == Result.Tie)
            {
                pgn += " 1/2-1/2";
            }

            return pgnHeader + pgn;
        }


    }
}
