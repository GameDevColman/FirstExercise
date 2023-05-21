using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkHoly : MonoBehaviour
{
    public GameObject hiddenCoins;

    private void OnTriggerEnter(Collider collider) 
    {
        ParticleSystem ps = GameObject.Find("DarkHolyExplosion").GetComponent<ParticleSystem>();
        
        if (collider.gameObject.CompareTag("Player"))
        {
            ps.Play();
            Destroy(gameObject);
            hiddenCoins.SetActive(true);
        }
    }
}
