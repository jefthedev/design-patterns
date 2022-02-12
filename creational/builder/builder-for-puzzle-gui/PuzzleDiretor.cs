public class PuzzleGUIDirector
{
    public PuzzleUtils.PuzzleGUI ConstructPuzzleGUI(PuzzleGUIBuilderProtocol builder)
    {
        builder.CreateGUI().CreateBackground().CreateEdges().CreateItems();

        PuzzleUtils.PuzzleGUI puzzle = builder.GetPuzzleGUI();
        Console.WriteLine(puzzle.GetRepresentation());
        Console.WriteLine("\n");
        builder.Reset();

        return builder.GetPuzzleGUI();
    }

}