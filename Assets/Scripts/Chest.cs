using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public AudioClip chestSound; //chest opening sound clip goes here
    public GameObject treasureChest; //treasure chest prefab goes here

    private void OnCollisionEnter(Collision collision) 
    {
        bool doesHaveChestKey = collision.gameObject.GetComponent<PlayerInventory>().DoesHaveChestKey;

        if (collision.gameObject.CompareTag("Player"))
        {
            if (doesHaveChestKey)
            {
                AudioSource.PlayClipAtPoint(chestSound, transform.position); //plays our soundclip
                treasureChest.GetComponent<Animation>().Play(); //plays the default animation applied to our treasureChest model
                Debug.Log("There is not better treasure than a clue! The key for the gate is at the holy place, where the light is bright like the sun");
            }
            else
            {
                Debug.Log("Treasure isn’t found so easily, Get the key to earn it");
            }
        }
    }
}
