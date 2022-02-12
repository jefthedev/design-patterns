public abstract class PuzzleGUIBuilderProtocol
{
    public abstract PuzzleGUIBuilderProtocol CreateGUI();
    public abstract PuzzleGUIBuilderProtocol CreateBackground();
    public abstract PuzzleGUIBuilderProtocol CreateEdges();
    public abstract PuzzleGUIBuilderProtocol CreateItems();
    public abstract PuzzleUtils.PuzzleGUI GetPuzzleGUI();
    public abstract PuzzleUtils.PuzzleGUI Reset();

}