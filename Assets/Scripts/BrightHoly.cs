using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightHoly : MonoBehaviour
{
    public GameObject key;
    public AudioClip explosionSound;

    private void OnTriggerEnter(Collider collider) 
    {
        ParticleSystem ps = GameObject.Find("BrightHolyExplosion").GetComponent<ParticleSystem>();
        
        if (collider.gameObject.CompareTag("Player"))
        {
            ps.Play();
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            Destroy(gameObject);
            key.SetActive(true);
        }
    }
}
