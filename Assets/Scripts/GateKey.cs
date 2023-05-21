using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKey : MonoBehaviour
{
    public AudioClip keySound;

    private void OnTriggerEnter(Collider collider) {
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.CompareTag("Player") && playerInventory != null)
        {
            AudioSource.PlayClipAtPoint(keySound, transform.position);
            playerInventory.GateKeyCollected();
            gameObject.SetActive(false);

            playerInventory.DialogShow("Run to the gate!");
        }
    }
}
