using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightHoly : MonoBehaviour
{
    public GameObject key;

    private void OnTriggerEnter(Collider collider) 
    {
        ParticleSystem ps = GameObject.Find("HolyExplosion").GetComponent<ParticleSystem>();
        
        if (collider.gameObject.CompareTag("Player"))
        {
            ps.Play();
            Destroy(gameObject);
            key.SetActive(true);
        }
    }
}
