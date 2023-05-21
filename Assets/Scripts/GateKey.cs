using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider) {
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.CompareTag("Player") && playerInventory != null)
        {
            playerInventory.GateKeyCollected();
            gameObject.SetActive(false);
            playerInventory.dialogShow("Run to the gate!");
        }
    }
}
