using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TigerFish : MonoBehaviour
{
    public void TigerFishClick()
    {
        PlayerPrefs.GetInt("Elusion", 45);
        PlayerPrefs.GetInt("Combat", 75);
        PlayerPrefs.GetInt("Immunity", 69);
        PlayerPrefs.GetString("FishType", "Tiger Fish");
        SceneManager.LoadScene("Scene2");
    }
}
