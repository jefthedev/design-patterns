public class EventPuzzleGUIBuilder: PuzzleGUIBuilder
{
    public override PuzzleUtils.PuzzleGUI CreateGUI()
    {
        return new PuzzleUtils.EventPuzzleGUI();
    }

    public override PuzzleUtils.PuzzleBackground CreateBackground()
    {
        Console.WriteLine("Adding event background...");
        return new PuzzleUtils.EventPuzzleBackground();
    }

    public override PuzzleUtils.PuzzleBackgroundEdges CreateEdges()
    {
        Console.WriteLine("Adding event edges...");
        return new PuzzleUtils.EventPuzzleBackgroundEdges();
    }

    public override PuzzleUtils.PuzzleItems CreateItems()
    {
        Console.WriteLine("Adding event items...");
        return new PuzzleUtils.EventPuzzleItems();
    }

}