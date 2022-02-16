public class PlayerManagerFacade
{
    public void AddExperience(Player player, int amount)
    {
        player.experience += amount;

        UpdateGUI();
        UpdateLocalData();
        UpdateCloudData();
    }

    private void UpdateGUI()
    {
        /* Do something... */
        Console.WriteLine("Player GUI updated.");
    }

    private void UpdateLocalData()
    {
        /* Do something... */
        Console.WriteLine("Local data updated.");
    }

    private void UpdateCloudData()
    {
        /* Do something... */
        Console.WriteLine("Cloud data updated.");
    }
    
}