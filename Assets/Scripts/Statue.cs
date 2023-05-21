using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public GameObject key;
    public AudioClip paySound;
    public AudioClip hintSound;


    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerInventory.NumberOfCoins < PlayerInventory.COINS)
                GiveHint();
            else
                GiveKey();
        }
    }

    private void GiveHint()
    {
        AudioSource.PlayClipAtPoint(hintSound, transform.position);
        playerInventory.DialogShow("You want the key out? pay me " + PlayerInventory.COINS + " coins");

    }

    private void GiveKey()
    {
        playerInventory.CoinsPaid();
        AudioSource.PlayClipAtPoint(paySound, transform.position);
        playerInventory.DialogShow("You really thought it would be that easy? get the key for the chest, it might be helpful");
        key.SetActive(true);
        gameObject.SetActive(false);
    }
}
