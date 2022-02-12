/*  This is our client.
    It does now know "how" to build the objects or even what parameters are needed.  */
PuzzleGUIDirector director = new PuzzleGUIDirector();

/*  Build default interface.  */
DefaultPuzzleGUIBuilder defaultBuilder = new DefaultPuzzleGUIBuilder();
PuzzleUtils.PuzzleGUI defaultInterface = director.ConstructPuzzleGUI(defaultBuilder);

/*  Build event interface.  */
EventPuzzleGUIBuilder eventBuilder = new EventPuzzleGUIBuilder();
PuzzleUtils.PuzzleGUI eventInterface = director.ConstructPuzzleGUI(eventBuilder);