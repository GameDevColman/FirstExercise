using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public GameObject key;
    private const int COINS = 10;

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerInventory.NumberOfCoins < COINS)
                GiveHint();
            else
                GiveKey();
        }
    }

    private void GiveHint()
    {
        playerInventory.dialogShow("You want the key out? pay me " + COINS + " coins");

    }

    private void GiveKey()
    {
        playerInventory.dialogShow("You really thought it would be that easy? get the key for the chest, it might be helpful");
        key.SetActive(true);
        gameObject.SetActive(false);
    }
}
