namespace ChessEngine.Engine 
{

/// <summary>
/// Defines the public contract for a chess engine.
/// This interface allows for different engine implementations to be used interchangeably
/// by the user interface or other client applications.
/// </summary>
public interface IChessEngine
{
    /// <summary>
    /// Sets the current board position using a FEN (Forsyth-Edwards Notation) string.
    /// </summary>
    /// <param name="fenString">The FEN string representing the board state.</param>
    void SetPosition(string fenString);

    /// <summary>
    /// Calculates and returns the best move for the current position.
    /// </summary>
    /// <returns>The best move in algebraic notation (e.g., "e2e4").</returns>
    string GetBestMove();

    /// <summary>
    /// Applies a move to the current board state.
    /// </summary>
    /// <param name="move">The move to make in algebraic notation.</param>
    void MakeMove(string move);

    /// <summary>
    /// Gets the FEN string for the current board position.
    /// </summary>
    /// <returns>The FEN string of the current position.</returns>
    string GetFen();

    /// <summary>
    /// Evaluates the current board position from the perspective of the current player.
    /// </summary>
    /// <returns>A score representing the evaluation. Positive is good for the current player, negative is bad.</returns>
    double GetEvaluation();

    /// <summary>
    /// Checks if the current game is over.
    /// </summary>
    /// <returns>True if the game is over (checkmate, stalemate, etc.), otherwise false.</returns>
    bool IsGameOver();
}
}
