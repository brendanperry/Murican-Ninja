using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCenterManager : MonoBehaviour
{

    public void Start()
    {
        Social.localUser.Authenticate(ProcessAuthentication);
    }

    void ProcessAuthentication(bool success)
    {
        if (success)
        {
            Debug.Log("Authenticated, checking achievements");
        }
        else
        {
            Debug.Log("Failed to authenticate");
        }
    }

    public void ReportScore(int score, string leaderboardID)
    {
        Debug.Log("Reporting score " + score + " on leaderboard " + leaderboardID);
        Social.ReportScore(score, leaderboardID, success => {
            Debug.Log(success ? "Reported score successfully" : "Failed to report score");
        });
    }

    public void ShowLeaderboards()
    {
        Social.ShowLeaderboardUI();
    }
}
