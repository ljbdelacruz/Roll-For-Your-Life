using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour {

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}


