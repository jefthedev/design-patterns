public class Player
{
    private string _name  = "";
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _experience = 0;
    public int experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    public int level
    {
        get { return (int)(experience * 0.001); }
    }

    public Player(string name)
    {
        this.name = name;
        this.experience = 0;
    }

}