public class StageManagerDecoratorOfferOnStart: StageManagerDecorator
{
    public StageManagerDecoratorOfferOnStart(StageManagerProtocol smp) : base(smp)
    {
        Console.WriteLine("Creating Offer on Start...");
    }

    public override void StartStage()
    {
        this.smp.StartStage();
        Console.WriteLine("StageManagerDecoratorOfferOnStart offers Boost in exchange for Rewarded Video.");
    }

    public override void FinishStage() 
    {
        this.smp.FinishStage();
    }

}