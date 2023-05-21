using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestKey : MonoBehaviour
{
    public AudioClip keySound;

    private void OnTriggerEnter(Collider collider) {
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.CompareTag("Player") && playerInventory != null)
        {
            AudioSource.PlayClipAtPoint(keySound, transform.position);
            playerInventory.ChestKeyCollected();
            gameObject.SetActive(false);
            playerInventory.DialogShow("Great, now that youv'e found the key, run open the chest");
        }
    }
}
