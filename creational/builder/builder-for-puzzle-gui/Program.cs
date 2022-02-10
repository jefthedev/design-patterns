/*  This is our client.
    It does now know "how" to build the objects or even what parameters are needed.  */
PuzzleGUIDirector director = new PuzzleGUIDirector();
DefaultPuzzleGUIBuilder defaultBuilder = new DefaultPuzzleGUIBuilder();
EventPuzzleGUIBuilder eventBuilder = new EventPuzzleGUIBuilder();

/*  Build default interface.  */
PuzzleUtils.PuzzleGUI defaultInterface = director.ConstructPuzzleGUI(defaultBuilder);
Console.WriteLine(defaultInterface.GetRepresentation() + '\n');

/*  Build event interface.  */
PuzzleUtils.PuzzleGUI eventInterface = director.ConstructPuzzleGUI(eventBuilder);
Console.WriteLine(eventInterface.GetRepresentation() + '\n');