using System;

namespace ChessCore
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // UCI engines must not print anything before the GUI sends `uci`.
            // Force line buffering off so responses reach the GUI immediately.
            Console.Out.NewLine = "\n";
            new UciProtocol().Run();
        }
    }
}
