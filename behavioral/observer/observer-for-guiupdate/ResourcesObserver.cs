class ResourcesObserver: ObserverPattern.IObserver
{
   public void Update(ObserverPattern.IObservable observable)
    {
        PlayerData playerData = (PlayerData) observable;

        string feedback = "";
        feedback += "Update resources information on GUI:\n";
        feedback += String.Format("   {0}: {1}", playerData.resources[0].name, playerData.resources[0].amount);
        feedback += String.Format("   {0}: {1}", playerData.resources[1].name, playerData.resources[1].amount);
        
        Console.WriteLine(feedback);
    }
}