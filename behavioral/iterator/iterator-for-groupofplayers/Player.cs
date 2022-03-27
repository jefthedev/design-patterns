class Player
{
    private string _name = "";
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    private Vector2 _position = new Vector2(0, 0);
    public Vector2 position
    {
        get { return _position; }
        set { _position = value; }
    }

    public Player(string name, Vector2 position)
    {
        this.name = name;
        this.position = position;
    }

    public override string ToString()
    {
        return String.Format("You see {0}, he is {1:0.00} meters away from the leader of his clan.", name, Vector2.Distance(new Vector2(0, 0), this.position));
    }

}