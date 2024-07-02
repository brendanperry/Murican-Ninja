using System.Collections;
using UnityEngine;

public class Ads : MonoBehaviour
{

    public string gameId = "1589460";// 5649301

    void Start()
    {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize(gameId, true);

        //Advertisement.Bann
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("Banner_iOS"))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Show("Banner_iOS");
    }
}