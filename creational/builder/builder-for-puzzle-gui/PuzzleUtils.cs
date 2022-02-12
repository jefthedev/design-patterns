namespace PuzzleUtils
{
    #region abstract
    public abstract class PuzzleGUI
    {
        public abstract string GetRepresentation();

        private PuzzleUtils.PuzzleBackground? _background = null;
        public PuzzleUtils.PuzzleBackground? background
        {
            get { return _background; }
            set { _background = value; }
        }

        private PuzzleUtils.PuzzleBackgroundEdges? _edges = null;
        public PuzzleUtils.PuzzleBackgroundEdges? edges
        {
            get { return _edges; }
            set { _edges = value; }
        }

        private PuzzleUtils.PuzzleItems? _items = null;
        public PuzzleUtils.PuzzleItems? items
        {
            get { return _items; }
            set { _items = value; }
        }

    }
    #endregion abstract

    #region interfaces
    public interface PuzzleBackground
    {
        public string GetRepresentation();
    }

    public interface PuzzleBackgroundEdges
    {
        public string GetRepresentation();
    }

    public interface PuzzleItems
    {
        public string GetRepresentation();
    }
    #endregion interfaces

    #region default_puzzle
    public class DefaultPuzzleGUI: PuzzleGUI
    {
        public override string GetRepresentation()
        {
            return "Here's a default Puzzle GUI.";
        }
    }

    public class DefaultPuzzleBackground: PuzzleBackground
    {
        public string GetRepresentation()
        {
            return "This is a default puzzle background.";
        }
    }

    public class DefaultPuzzleBackgroundEdges: PuzzleBackgroundEdges
    {
        public string GetRepresentation()
        {
            return "These are default puzzle edges.";
        }
    }

    public class DefaultPuzzleItems: PuzzleItems
    {
        public string GetRepresentation()
        {
            return "These are default puzzle items.";
        }
    }
    #endregion default_puzzle

    #region event_puzzle
    public class EventPuzzleGUI: PuzzleGUI
    {
        public override string GetRepresentation()
        {
            return "Here's an event Puzzle GUI.";
        }
    }
    
    public class EventPuzzleBackground: PuzzleBackground
    {
        public EventPuzzleBackground() {}
        public string GetRepresentation()
        {
            return "This is a event puzzle background.";
        }
    }

    public class EventPuzzleBackgroundEdges: PuzzleBackgroundEdges
    {
        public EventPuzzleBackgroundEdges() {}
        public string GetRepresentation()
        {
            return "These are event puzzle edges.";
        }
    }

    public class EventPuzzleItems: PuzzleItems
    {
        public EventPuzzleItems() {}
        public string GetRepresentation()
        {
            return "These are event puzzle items.";
        }
    }
    #endregion event_puzzle
}