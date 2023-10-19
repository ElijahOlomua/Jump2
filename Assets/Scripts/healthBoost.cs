using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoost : MonoBehaviour
{
    public GameObject pickUpEffect;
    public AudioSource pickUpSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        pickUpSound.Play();
        pickup(other);
        
    }
    void pickup(Collider2D other)
    {
        //Instantiate(pickUpEffect, transform.position, transform.rotation);

        movementScript playerHealth = other.GetComponent<movementScript>();

        playerHealth.health = 1;
        Destroy(gameObject);
    }

}
