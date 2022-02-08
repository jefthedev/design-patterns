/*  Here's our Context...  */
AdsRequestProtocol arp = new GoogleAdMobAdapter();

/*  At any point this client code does not know how GoogleAdMob works due to GoogleAdMobAdapter. 
    If GoogleAdMob changes we'll have to modify GoogleAdMobAdapteronly,
    all client code calls remain intact!  */
Console.WriteLine("Testing Ads API Adapter...");
arp.RequestBannerAd();
arp.ShowBannerAd();

arp.RequestIntersticialAd();
arp.ShowIntersticialAd();

arp.RequestRewardedVideoAd();
arp.ShowRewardedVideoAd();
Console.WriteLine("Done!");