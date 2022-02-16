PlayerManagerFacade pmf = new PlayerManagerFacade();

Player p1 = new Player("Gandalf");
pmf.AddExperience(p1, 5000);
Console.WriteLine("Player 1 - Level:" + p1.level);