using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwimBehavior : MonoBehaviour
{
    public GameObject distLeftText;
    public int TIMEREMAINING = 10;

    // !!We probably start with importing the party stats to this scene
    void Start()
    {
        switch (PlayerPrefs.GetInt("PlayerLevel"))
        {
            case 1:
                TIMEREMAINING = 15;
                break;
            case 2:
                TIMEREMAINING = 20;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if((TIMEREMAINING - Time.time) > 0)
        {
            distLeftText.GetComponent<Text>().text = ("Distance Remaining: " + (TIMEREMAINING - Time.time));
        }
        else
        {
            switch (PlayerPrefs.GetInt("PlayerLevel"))
            {
                case 1:
                    SceneManager.LoadScene("PNGScene");
                    PlayerPrefs.SetInt("PlayerLevel", 2);
                    break;
                case 2:
                    SceneManager.LoadScene("MTScene");
                    PlayerPrefs.SetInt("PlayerLevel", 2);
                    break;
            }
            
        }
    }
}
