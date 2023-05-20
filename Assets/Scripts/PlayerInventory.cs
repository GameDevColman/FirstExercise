using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins {get; private set;}
    public bool DoesHaveChestKey {get; private set;}
    public bool DoesHaveGateKey {get; private set;}

    public UnityEvent<PlayerInventory> OnCoinCollected;

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
}
