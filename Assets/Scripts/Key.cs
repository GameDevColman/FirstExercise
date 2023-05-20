using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider) {
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.CompareTag("Player") && playerInventory != null)
        {
            playerInventory.ChestKeyCollected();
            gameObject.SetActive(false);
            Debug.Log("Great, now that youv'e found the key, run open the chest");
        }
    }
}
