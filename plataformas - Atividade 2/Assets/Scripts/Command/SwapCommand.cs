using UnityEngine;

public class SwapCommand : ICommand
{
    private PuzzlePiece pieceA, pieceB;

    public SwapCommand(PuzzlePiece a, PuzzlePiece b)
    {
        pieceA = a;
        pieceB = b;
    }

    public void Execute()
    {
        PuzzleManager.Instance.SwapPieces(pieceA, pieceB);
    }

    public void Undo()
    {
        PuzzleManager.Instance.SwapPieces(pieceB, pieceA);
    }
}

