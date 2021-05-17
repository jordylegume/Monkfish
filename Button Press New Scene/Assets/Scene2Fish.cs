using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene2Fish : MonoBehaviour
{
    public TextMeshPro FishName;
    void FishType()
    {
        
        FishName.text = "You Chose " + PlayerPrefs.GetString("FishType");
        Debug.Log(FishName);
    }

}
