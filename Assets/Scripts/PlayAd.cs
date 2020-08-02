using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class PlayAd : MonoBehaviour
{


    /*
        static int loadCount = 0;

        void Start()
        {
            if (loadCount % 3 == 0)  // only show ad every third time
            {
                ShowAd();
            }
            loadCount++;
        }*/

    public void ShowAd()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }
}

