/*  Legacy StageManager.  */
StageManager stageManager = new StageManager();
stageManager.StartStage();
stageManager.FinishStage();
Console.WriteLine("\n");

/*  New feature needed.  */
StageManagerDecoratorOfferOnFailed offerOnFailedManager = new StageManagerDecoratorOfferOnFailed(stageManager);
offerOnFailedManager.StartStage();
offerOnFailedManager.FinishStage();
Console.WriteLine("\n");

/*  Another new feature needed.  */
StageManagerDecoratorOfferOnStart offerOnStartManager = new StageManagerDecoratorOfferOnStart(stageManager);
offerOnStartManager.StartStage();
offerOnStartManager.FinishStage();
Console.WriteLine("\n");