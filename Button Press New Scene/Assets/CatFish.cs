using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatFish : MonoBehaviour
{
    public void CatFishClick()
    {
        PlayerPrefs.GetInt("Elusion", 80);
        PlayerPrefs.GetInt("Combat", 37);
        PlayerPrefs.GetInt("Immunity", 69);
        PlayerPrefs.GetString("FishType", "Cat Fish");
        SceneManager.LoadScene("Scene2");
    }

}
