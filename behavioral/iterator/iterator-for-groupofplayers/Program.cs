class Program
{
    static void Main()
    {
        /*  This is our client. */
        List<Player> members = new List<Player> 
        {
            new Player("Gandalf", new Vector2(0, 0)),
            new Player("Aragorn", new Vector2(1, 0)),
            new Player("Legolas", new Vector2(0, 1)),
            new Player("Gimli", new Vector2(-1, 0)),
            new Player("Frodo", new Vector2(0, -1)),
            new Player("Sam", new Vector2(0, 5)),
            new Player("Merry", new Vector2(2, 2)),
            new Player("Pippin", new Vector2(-2, 2)) 
        };

        Players.Clan clan = new Players.Clan("The Fellowship of the Ring", members);

        /*  Print clan members information using C# native foreach.  */
        foreach(Player player in clan)
            Console.WriteLine(player.ToString());
    }
}