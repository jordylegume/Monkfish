using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    public string playerSpeciesString;
    public GameObject inputField;

    // Start is called before the first frame update
    public void startGame()
    {
        SceneManager.LoadScene("CharacterSelectScreen");
    }

    // Called upon player entering character selection input field, assigns appropriate species to character and changes scenes (Char Sel -> GBR)
    public void selectCharacter()
    {
        playerSpeciesString = inputField.GetComponent<Text>().text;
        switch (playerSpeciesString)
        {
            case "1":
                PlayerPrefs.SetString("PlayerSpecies", "Lionfish");
                break;
            case "2":
                PlayerPrefs.SetString("PlayerSpecies", "Tigerfish");
                break;
            case "3":
                PlayerPrefs.SetString("PlayerSpecies", "Catfish");
                break;
            default:
                print("butts");
                PlayerPrefs.SetString("PlayerSpecies", "Assfish");
                break;
        }
        PlayerPrefs.SetInt("PlayerLevel", 1);
        SceneManager.LoadScene("GBRScene");
    }

    public void leaveTown()
    {
        SceneManager.LoadScene("SwimScene");
    }

    public void resetGame()
    {
        SceneManager.LoadScene("SplashScene");
    }

    public void endGame()
    {
        SceneManager.LoadScene("EndScreen");
    }

}
