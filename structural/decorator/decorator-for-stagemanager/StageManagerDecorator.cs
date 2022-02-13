public class StageManagerDecorator: StageManagerProtocol
{
    private StageManagerProtocol _smp = new StageManager();
    public StageManagerProtocol smp
    {
        get { return _smp; }
        set { _smp = value; }
    }

    public StageManagerDecorator(StageManagerProtocol smp)
    {
        this.smp = smp;
    }

    public virtual void StartStage()
    {
        Console.WriteLine("StageManagerDecorator has started stage.");
        this.smp.StartStage();
    }

    public virtual void FinishStage() 
    {
        Console.WriteLine("StageManagerDecorator has finished stage.");
        this.smp.FinishStage();
    }

}