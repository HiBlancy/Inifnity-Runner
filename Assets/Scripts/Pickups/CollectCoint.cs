using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoint : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    public AudioSource cointFX;
    private void OnTriggerEnter(Collider other)
    {
        cointFX.Play();
        CollectScreen.cointCount ++;
        this.gameObject.SetActive(false);
        playerMovement.AddingSpeedToPlayer();
    }
}
