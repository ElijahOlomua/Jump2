using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBoost : MonoBehaviour
{
    public GameObject pickUpEffect;
    public GameObject player;
    public AudioSource pickUpSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        pickUpSound.Play();
        pickup(other);
    }
    void pickup(Collider2D other)
    {
        //Instantiate(pickUpEffect, transform.position, transform.rotation);
        movementScript playerJump = other.GetComponent<movementScript>();
        playerJump.forceAmount = 1750;
        

        Destroy(gameObject);
    }
}
