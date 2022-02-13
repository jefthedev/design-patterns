public class StageManagerDecoratorOfferOnFailed: StageManagerDecorator
{
    public StageManagerDecoratorOfferOnFailed(StageManagerProtocol smp) : base(smp)
    {
        Console.WriteLine("Creating Offer on Failed...");
    }

    public override void StartStage()
    {
        this.smp.StartStage();
    }

    public override void FinishStage() 
    {
        this.smp.FinishStage();
        Console.WriteLine("StageManagerDecoratorOfferOnFailed offers Lives in exchange for Rewarded Video.");
    }

}