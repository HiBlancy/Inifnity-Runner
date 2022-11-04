using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{
    public GameObject highscoreDistanceMenu;

    void Start()
    {
        highscoreDistanceMenu.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("highscore", 0);
    }
}