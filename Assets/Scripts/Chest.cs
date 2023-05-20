using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public AudioClip chestSound; //chest opening sound clip goes here
    public GameObject treasureChest; //treasure chest prefab goes here

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(chestSound, transform.position); //plays our soundclip
            treasureChest.GetComponent<Animation>().Play(); //plays the default animation applied to our treasureChest model
        }
    }
}
