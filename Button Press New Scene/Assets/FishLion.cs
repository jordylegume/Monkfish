using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishLion : MonoBehaviour
{
    public void lionfishclick()
    {
        PlayerPrefs.GetInt("Elusion", 35);
        PlayerPrefs.GetInt("Combat", 95);
        PlayerPrefs.GetInt("Immunity", 69);
        PlayerPrefs.GetString("FishType", "Lion Fish");
        SceneManager.LoadScene("Scene2");
    }

}
