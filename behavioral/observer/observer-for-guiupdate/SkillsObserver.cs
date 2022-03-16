class SkillsObserver: ObserverPattern.IObserver
{
    public void Update(ObserverPattern.IObservable observable)
    {
        PlayerData playerData = (PlayerData) observable;

        string feedback = "";
        feedback += "Update skills information on GUI:\n";
        feedback += String.Format("   Skill {0} -> Cooldown = {1}", playerData.skills[0].name, playerData.skills[0].cooldown);
        feedback += String.Format("   Skill {0} -> Cooldown = {1}", playerData.skills[1].name, playerData.skills[1].cooldown);
        feedback += String.Format("   Skill {0} -> Cooldown = {1}", playerData.skills[2].name, playerData.skills[2].cooldown);
        
        Console.WriteLine(feedback);
    }
}