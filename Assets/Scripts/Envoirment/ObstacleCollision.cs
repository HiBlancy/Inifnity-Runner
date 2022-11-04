using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject distanceRunned;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        distanceRunned.GetComponent<DistanceRunned>().enabled = false;
        distanceRunned.GetComponent<EndOfTheRun>().enabled = true;
    }
}