public abstract class PuzzleGUIBuilder
{
    protected PuzzleUtils.PuzzleGUI pGUI;
    protected PuzzleUtils.PuzzleBackground pBackground;
    protected PuzzleUtils.PuzzleBackgroundEdges pEdges;
    protected PuzzleUtils.PuzzleItems pItems;

    public abstract PuzzleUtils.PuzzleGUI CreateGUI();
    public abstract PuzzleUtils.PuzzleBackground CreateBackground();
    public abstract PuzzleUtils.PuzzleBackgroundEdges CreateEdges();
    public abstract PuzzleUtils.PuzzleItems CreateItems();

}