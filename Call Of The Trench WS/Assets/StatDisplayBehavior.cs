using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDisplayBehavior : MonoBehaviour
{

    public GameObject speciesText;

    void Start()
    {
        speciesText.GetComponent<Text>().text = PlayerPrefs.GetString("PlayerSpecies").ToString();
    }
}