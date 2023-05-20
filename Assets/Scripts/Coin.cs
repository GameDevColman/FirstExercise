using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound; //chest opening sound clip goes here

    private void OnTriggerEnter(Collider collider) {
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.tag == "Player" && playerInventory != null)
        {
            playerInventory.CoinCollected();
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }
    }
}
