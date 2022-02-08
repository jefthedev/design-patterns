public class GoogleAdMobAdapter: AdsRequestProtocol
{
    public void RequestBannerAd()
    {
        Console.WriteLine("Requesting Banner...");
    }

    public void RequestIntersticialAd()
    {
        Console.WriteLine("Requesting Intersticial...");
    }

    public void RequestRewardedVideoAd()
    {
        Console.WriteLine("Requesting Rewarded Video...");
    }

    public void ShowBannerAd()
    {
        Console.WriteLine("Showing Banner...\n");
    }

    public void ShowIntersticialAd()
    {
        Console.WriteLine("Showing Intersticial...\n");
    }

    public void ShowRewardedVideoAd()
    {
        Console.WriteLine("Showing Rewarded Video...\n");
    }

}
