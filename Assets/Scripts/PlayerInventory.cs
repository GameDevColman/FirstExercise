using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins {get; private set;}
    public bool DoesHaveChestKey {get; private set;}
    public bool DoesHaveGateKey {get; private set;}
    public string dialogText {get; private set;}
    public const int COINS = 20;


    public UnityEvent<PlayerInventory> OnCoinCollected;
    public UnityEvent<PlayerInventory> OnDialogShow;

    private void Awake() 
    {
        DoesHaveChestKey = false;
        DoesHaveGateKey = false;
    }

    public void CoinCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }

    public void ChestKeyCollected()
    {
        DoesHaveChestKey = true;
    }

    public void GateKeyCollected()
    {
        DoesHaveGateKey = true;
    }

    public void CoinsPaid()
    {
        NumberOfCoins -= COINS;
        OnCoinCollected.Invoke(this);
    }

    public void DialogShow(string newText)
    {
         dialogText = newText;
         OnDialogShow.Invoke(this);
    }

    public void LookBehind()
    {
        Transform playerTransform = transform; // Assuming this script is attached to the player object

        // Get the current rotation
        Vector3 currentRotation = playerTransform.eulerAngles;

               // Calculate the new rotation by adding 180 degrees to the y-axis rotation
               Vector3 targetRotation = new Vector3(currentRotation.x, currentRotation.y + 10f, currentRotation.z);

               // Set the new rotation
               playerTransform.eulerAngles = targetRotation;
    }


}
