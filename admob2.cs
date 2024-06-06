using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class admob2 : MonoBehaviour
{
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
        
        });
    }

#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-9618593531319351/774721";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/4411469";
#else
  private string _adUnitId = "unused";
#endif

    private InterstitialAd _interstitialAd;
    public void LoadLoadInterstitialAd()
    {
        if (_interstitialAd != null)
        {
            _interstitialAd.Destroy();
            _interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");
        var adRequest = new AdRequest();

        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {
                    Debug.LogError("interstitial ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Interstitial ad loaded with response : "
                          + ad.GetResponseInfo());

                _interstitialAd = ad;
            });
    }
    public void ShowInterstitialAd()
    {
        if (_interstitialAd != null && _interstitialAd.CanShowAd())
        {
            Debug.Log("Showing interstitial ad.");
            _interstitialAd.Show();
        }
        else
        {
            Debug.LogError("Interstitial ad is not ready yet.");
        }
    }
}
