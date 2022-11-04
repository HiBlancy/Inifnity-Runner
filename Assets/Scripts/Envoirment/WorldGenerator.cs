using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject[] sections;
    int zPosition = 50;
    bool creatingNewSection = false;
    int sectionNum; 
    
    void Update()
    {
        if (creatingNewSection == false)
        {
            creatingNewSection = true;
            StartCoroutine(GeneratingNewSection());
        }
    }

    IEnumerator GeneratingNewSection()
    {
        sectionNum = Random.Range(0, 3);
        Instantiate(sections[sectionNum], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(2);
        creatingNewSection = false;
    }
}
