using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwimBehavior : MonoBehaviour
{
    public GameObject distLeftText;
    public GameObject TotalDistanceText;
    public GameObject SpeedText;
    public Button IncreaseSpeedButton;
    public int DistanceRemaining = 1000;
    public int PartySize = 4;
    public int OverallTime = 30;
    public int TotalDistance;

    // !!We probably start with importing the party stats to this scene
    public void Start()
    {

        switch (PlayerPrefs.GetInt("PlayerLevel"))
        {
            case 1:
                DistanceRemaining = 1000000;
                break;
            case 2:
                DistanceRemaining = 2000000;
                break;
        }

        TotalDistanceText.GetComponent<Text>().text = ("Total Distance (m): " + DistanceRemaining);
        int TotalDistance = DistanceRemaining;
        //multiplied by 50 since fixed update runs at 50fps on default
        PlayerPrefs.SetInt("Speed", TotalDistance / (50*OverallTime));
        IncreaseSpeedButton.onClick.AddListener(IncreaseSpeed);
    }

    public void IncreaseSpeed()
    {
        PlayerPrefs.SetInt("Speed", (PlayerPrefs.GetInt("Speed") * (105 / 100)));
    }
    /*
    void RepeatingScene()
    {
        SpeedText.GetComponent<Text>().text = ("Speed (km/h):" + PlayerPrefs.GetInt("Speed"));
        if (DistanceRemaining > 0)
        {
            distLeftText.GetComponent<Text>().text = ("Distance Remaining (km): " + (DistanceRemaining - PlayerPrefs.GetInt("Speed")));
            DistanceRemaining -= PlayerPrefs.GetInt("Speed");

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
    */

    //Fixed update refreshes every 0.02 seconds by default 
    void FixedUpdate()
    {
        SpeedText.GetComponent<Text>().text = ("Speed (m/s):" + PlayerPrefs.GetInt("Speed"));
        if (DistanceRemaining > 0)
        {
            distLeftText.GetComponent<Text>().text = ("Distance Remaining (m): " + (DistanceRemaining - PlayerPrefs.GetInt("Speed")));
            DistanceRemaining -= (PlayerPrefs.GetInt("Speed"));

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
    // Update is called once per frame
    /*
    void Update()
    {
    InvokeRepeating("RepeatingScene", OverallTime, 1);
    
    SpeedText.GetComponent<Text>().text = ("Speed (km/h):" + PlayerPrefs.GetInt("Speed"));
        if((DistanceRemaining - Time.time) > 0)
        {
            distLeftText.GetComponent<Text>().text = ("Distance Remaining (km): " + (DistanceRemaining - (Time.time)));
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
    */
}
    