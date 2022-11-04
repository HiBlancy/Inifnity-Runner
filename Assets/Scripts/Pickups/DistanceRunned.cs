using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DistanceRunned : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject distanceEndDisplay;
    public GameObject highscoreDistance;
    public int distanceRun;
    bool addingDistance = false;
    public float distanceDelay = 0.35f;
    int highscore = 0;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }
    void Update()
    {
        if (addingDistance == false)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
    }
    IEnumerator AddingDistance ()
    {
        distanceRun++;
        distanceDisplay.GetComponent<Text>().text = "" + distanceRun;
        distanceEndDisplay.GetComponent<Text>().text = "" + distanceRun;
        highscoreDistance.GetComponent<Text>().text = "" + highscore;
        yield return new WaitForSeconds(distanceDelay);
        addingDistance = false;

        if (highscore < distanceRun)
        {
            PlayerPrefs.SetInt("highscore", distanceRun);
        }
    }
}
