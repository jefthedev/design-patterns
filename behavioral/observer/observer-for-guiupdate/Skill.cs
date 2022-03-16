class Skill
{
    private string _name = "";
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    private bool _cooldown = false;
    public bool cooldown
    {
        get { return _cooldown; }
        set { _cooldown = value; }
    }

    public Skill(string name)
    {
        this.name = name;
        this.cooldown = false;
    }
}