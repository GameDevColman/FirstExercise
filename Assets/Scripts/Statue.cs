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
            if (GetCoinsAmount() < COINS)
                GiveHint();
            else
                GiveKey();
        }
    }

    public int GetCoinsAmount()
    {
        return playerInventory.NumberOfCoins;
    }

    private void GiveHint()
    {
        Debug.Log("You want the key out? pay me " + COINS + " coins");
    }

    private void GiveKey()
    {
        key.SetActive(true);
        gameObject.SetActive(false);
    }
}
