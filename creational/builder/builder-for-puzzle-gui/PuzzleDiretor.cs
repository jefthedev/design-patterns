public class PuzzleGUIDirector
{
    public PuzzleUtils.PuzzleGUI ConstructPuzzleGUI(PuzzleGUIBuilder builder)
    {
        PuzzleUtils.PuzzleGUI puzzleGUI = builder.CreateGUI();
        Console.WriteLine(puzzleGUI.GetRepresentation());

        puzzleGUI.background = builder.CreateBackground();
        Console.WriteLine(puzzleGUI.background.GetRepresentation());

        puzzleGUI.edges = builder.CreateEdges();
        Console.WriteLine(puzzleGUI.edges.GetRepresentation());

        puzzleGUI.items = builder.CreateItems();
        Console.WriteLine(puzzleGUI.items.GetRepresentation());

        return puzzleGUI;
    }

}