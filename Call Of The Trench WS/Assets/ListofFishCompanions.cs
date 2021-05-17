using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ListofFishCompanions : MonoBehaviour
{

    public string[] FishNames = new string[] { "Hank", "Pam", "Snilbo", "PoppaPooey", "Skoogs", "Janice", "iCarly", "Gabagool", "Hammer", "Ducats", "Papa Johns", "Aunt Jemima", "Uncle Ben", "Grimace", "ButtFace Mcgee", "Flipper", "Flips", "Janet", "Priscilla", "Blubs" };
    public int StartingNumberofCompanions;
    public GameObject CompanionName1;
    public GameObject CompanionName2;
    public GameObject CompanionName3;
    public GameObject CompanionName4;
    

    // Start is called before the first frame update
    public void FishCompanions()
    {
        //The companions array will be appended with the names from the FishNames array       
        string companionadd;


        //Initializes the number of elements to be in the companions array, probably need to change this to a list to be able to add and remove elements
        int StartingCompanions = 4;
        var companions = new List<string>();
        System.Random rnd = new System.Random();
        
        //Loop through starting 4 companions
        for (int i = 0; i < StartingCompanions; i++)
        { 
            int ArrayNum = rnd.Next(0, 19);
            companionadd = FishNames[ArrayNum];
            companions.Add(companionadd);
        }

        //Testing to see if I can get names of the companions displayed in game scene
        PlayerPrefs.SetString("companion 1", companions[0]);
        PlayerPrefs.SetString("companion 2", companions[1]);
        PlayerPrefs.SetString("companion 3", companions[2]);
        PlayerPrefs.SetString("companion 4", companions[3]);
        
        CompanionName1.GetComponent<Text>().text = PlayerPrefs.GetString("companion 1").ToString();
        CompanionName2.GetComponent<Text>().text = PlayerPrefs.GetString("companion 2").ToString();
        CompanionName3.GetComponent<Text>().text = PlayerPrefs.GetString("companion 3").ToString();
        CompanionName4.GetComponent<Text>().text = PlayerPrefs.GetString("companion 4").ToString();
    }
    /*
    void DisplayCompanions()
    {
        CompanionName.GetComponent<Text>().text = PlayerPrefs.GetString("companion 1").ToString();
    }
    */
}

