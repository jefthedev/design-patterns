public class DefaultPuzzleGUIBuilder: PuzzleGUIBuilderProtocol
{
    /// <summary>The object to be constructed.</summary>
    private PuzzleUtils.PuzzleGUI _GUI = new PuzzleUtils.DefaultPuzzleGUI();
    public PuzzleUtils.PuzzleGUI GUI
    {
        get { return _GUI; }
        set { _GUI = value; }
    }

    public override PuzzleGUIBuilderProtocol CreateGUI()
    {
        Console.WriteLine("New default GUI created...");
        this.GUI = new PuzzleUtils.DefaultPuzzleGUI();
        return this;
    }

    public override PuzzleGUIBuilderProtocol CreateBackground()
    {
        Console.WriteLine("Adding default background...");
        this.GUI.background = new PuzzleUtils.DefaultPuzzleBackground();
        return this;
    }

    public override PuzzleGUIBuilderProtocol CreateEdges()
    {
        Console.WriteLine("Adding default edges...");
        this.GUI.edges = new PuzzleUtils.DefaultPuzzleBackgroundEdges();
        return this;
    }

    public override PuzzleGUIBuilderProtocol CreateItems()
    {
        Console.WriteLine("Adding default items...");
        this.GUI.items = new PuzzleUtils.DefaultPuzzleItems();
        return this;
    }

    public override PuzzleUtils.PuzzleGUI GetPuzzleGUI()
    {
        return this.GUI;
    }

    public override PuzzleUtils.PuzzleGUI Reset()
    {
        Console.WriteLine("Reseting default GUI...");
        this.GUI = new PuzzleUtils.DefaultPuzzleGUI();
        return this.GUI;
    }

}