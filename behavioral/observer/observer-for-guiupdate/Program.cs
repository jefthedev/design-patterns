class Program
{
    static void Main(string[] args)
    {
        List<Resource> resources = new List<Resource>() { new Resource("Gold", 100), new Resource("Lives", 10) };
        List<Skill> skills = new List<Skill>() { new Skill("A"), new Skill("B"), new Skill("C") };
        var playerData = new PlayerData("Nephalem", resources, skills);

        var resourcesOnGUI = new ResourcesObserver();
        var skillsOnGUI = new SkillsObserver();
        playerData.Subscribe(resourcesOnGUI);
        playerData.Subscribe(skillsOnGUI);

        playerData.AddResource(0, 100);
        playerData.AddResource(1, 900);
        playerData.UseSkill(0);
    }
}