using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Ba : MonoBehaviour
{


    [SerializeField] BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;

    [SerializeField] string _androidAdUnitId = "Banner_Android";
    [SerializeField] string _iOSAdUnitId = "Banner_iOS";
    string _adUnitId = null; 
    GameObject player;

    void Start()
    {
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif


        Advertisement.Banner.SetPosition(_bannerPosition);
        player = GameObject.FindWithTag("Player");
        LoadBanner();


    }

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        Advertisement.Banner.Load(_adUnitId, options);
    }

    void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");
        ShowBannerAd();


    }

    void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
    }

    void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };

        Advertisement.Banner.Show(_adUnitId, options);
    }

    void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }

    void OnBannerClicked() {
        HideBannerAd();
    }
    void OnBannerShown() { }
    void OnBannerHidden() { }

    void OnDestroy()
    {
        // Clean up the listeners:
        //_loadBannerButton.onClick.RemoveAllListeners();
        //_showBannerButton.onClick.RemoveAllListeners();
        //_hideBannerButton.onClick.RemoveAllListeners();
    }
}

