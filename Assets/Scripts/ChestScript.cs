using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) 
    {
        Debug.Log(collision);
        if (collision.tag == "Player" && collision.transform.tag == "Chest") {
            Destroy(collision.gameObject);
        }
    }
}
