// AliyerEdon@mail.com Christmas 2022
// Trophies system (load and display in the menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trophies : MonoBehaviour
{
    // Trophies list
    public Image kills_1000, kills_5000, kills_10000, kills_100000;
    public Image scores_100000, scores_1000000;
    public Image wave_100, wave_1000;
    public Image unlock_Level4;

    public Sprite NotUnlocked; // Trophy not unlocked sprite

    // Start is called before the first frame update
    void Start()
    {
        Update_Trophies();
    }

    // Update is called once per frame
    public void Update_Trophies()
    {
        // Kills 1000
        if (PlayerPrefs.GetInt("Total Kills") >= 1000)
            kills_1000.color = Color.green;
        else
        {
            kills_1000.color = Color.white;
            kills_1000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Kills 5000
        if (PlayerPrefs.GetInt("Total Kills") >= 5000)
            kills_5000.color = Color.green;
        else
        {
            kills_5000.color = Color.white;
            kills_5000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Kills 10000
        if (PlayerPrefs.GetInt("Total Kills") >= 10000)
            kills_10000.color = Color.green;
        else
        {
            kills_10000.color = Color.white;
            kills_10000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Kills 100000
        if (PlayerPrefs.GetInt("Total Kills") >= 100000)
            kills_100000.color = Color.green;
        else
        {
            kills_100000.color = Color.white;
            kills_100000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Scores 100000
        if (PlayerPrefs.GetInt("Total Scores") >= 100000)
            scores_100000.color = Color.green;
        else
        {
            scores_100000.color = Color.white;
            scores_100000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Scores 1000000
        if (PlayerPrefs.GetInt("Total Scores") >= 1000000)
            scores_1000000.color = Color.green;
        else
        {
            scores_1000000.color = Color.white;
            scores_1000000.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Unlock Level 4
        if (PlayerPrefs.GetInt("Level Unlocked3") == 1)
            unlock_Level4.color = Color.green;
        else
        {
            unlock_Level4.color = Color.white;
            unlock_Level4.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Wave 100
        if (PlayerPrefs.GetInt("Total Waves Passed") >= 100)
            wave_100.color = Color.green;
        else
        {
            wave_100.color = Color.white;
            wave_100.sprite = NotUnlocked;
        }
        //------------------------------------------------
        // Wave 1000
        if (PlayerPrefs.GetInt("Total Waves Passed") >= 1000)
            wave_1000.color = Color.green;
        else
        {
            wave_1000.color = Color.white;
            wave_1000.sprite = NotUnlocked;
        }
        //------------------------------------------------
    }
}
