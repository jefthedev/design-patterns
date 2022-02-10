public class DefaultPuzzleGUIBuilder: PuzzleGUIBuilder
{
    public override PuzzleUtils.PuzzleGUI CreateGUI()
    {
        return new PuzzleUtils.DefaultPuzzleGUI();
    }

    public override PuzzleUtils.PuzzleBackground CreateBackground()
    {
        Console.WriteLine("Adding default background...");
        return new PuzzleUtils.DefaultPuzzleBackground();
    }

    public override PuzzleUtils.PuzzleBackgroundEdges CreateEdges()
    {
        Console.WriteLine("Adding default edges...");
        return new PuzzleUtils.DefaultPuzzleBackgroundEdges();
    }

    public override PuzzleUtils.PuzzleItems CreateItems()
    {
        Console.WriteLine("Adding default items...");
        return new PuzzleUtils.DefaultPuzzleItems();
    }

}