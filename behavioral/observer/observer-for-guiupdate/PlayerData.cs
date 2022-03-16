class PlayerData: ObserverPattern.IObservable
{
    private string _playerName = "";
    public string playerName
    {
        get { return _playerName; }
        set { _playerName = value; }
    }

    private List<Resource> _resources = new List<Resource>();
    public List<Resource> resources
    {
        get { return _resources; }
        set { _resources = value; }
    }

    private List<Skill> _skills = new List<Skill>();
    public List<Skill> skills
    {
        get { return _skills; }
        set { _skills = value; }
    }

    private List<ObserverPattern.IObserver> _GUIobservers = new List<ObserverPattern.IObserver>();
    public List<ObserverPattern.IObserver> GUIobservers
    {
        get { return _GUIobservers; }
        set { _GUIobservers = value; }
    }


    public PlayerData(string playerName, List<Resource> resources, List<Skill> skills)
    {
        this.playerName = playerName;
        this.resources = resources;
        this.skills = skills;
    }

    public void Subscribe(ObserverPattern.IObserver observer) 
    {
        if(!this.GUIobservers.Contains(observer))
        {
            this.GUIobservers.Add(observer);
            Console.WriteLine("Observer has been subscribed.");
        }
    }

    public void Unsubscribe(ObserverPattern.IObserver observer)
    {
        this.GUIobservers.Remove(observer);
        Console.WriteLine("Observer has been unsubscribed.");
    }

    public void Notify()
    {
        Console.WriteLine("A change has been made. Notifying all the observers...");
        foreach(var observer in this.GUIobservers)
            observer.Update(this);
        Console.WriteLine("GUI updated.\n");
    }

    public void AddResource(int index, int amount)
    {
        this.resources[index].amount += amount;
        Notify();
    }

    public void UseSkill(int index)
    {
        this.skills[index].cooldown = true;
        Notify();
    }
}