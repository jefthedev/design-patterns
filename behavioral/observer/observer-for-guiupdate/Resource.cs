class Resource
{
    private string _name = "";
    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _amount = 0;
    public int amount
    {
        get { return _amount; }
        set { _amount = value; }
    }

    public Resource(string name, int amount)
    {
        this.name = name;
        this.amount = amount;
    }
}