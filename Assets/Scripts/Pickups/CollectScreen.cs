using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScreen : MonoBehaviour
{
    public static int cointCount;
    public GameObject cointCountDisplay;
    public GameObject cointEndDisplay;

    private void Start()
    {
        cointCount = 0;
    }
    private void Update()
    {
        cointCountDisplay.GetComponent<Text>().text = "" + cointCount;
        cointEndDisplay.GetComponent<Text>().text = "" + cointCount;
    }
}
