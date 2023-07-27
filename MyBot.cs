using ChessChallenge.API;
using System;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        Random choice = new Random();
        return moves[choice.Next(0,moves.Length)];
    }
}
