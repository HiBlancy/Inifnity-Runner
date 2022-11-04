using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTheRun : MonoBehaviour
{
    public GameObject endScreen;
    
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(1f);
        endScreen.SetActive(true);
    }
}
