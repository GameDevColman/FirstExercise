using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public AudioClip chestSound; //chest opening sound clip goes here
    public GameObject treasureChest; //treasure chest prefab goes here
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
    Debug.Log(col.gameObject.tag);

    if (col.gameObject.tag == "Player") {
        AudioSource.PlayClipAtPoint(chestSound, transform.position); //plays our soundclip
        treasureChest.GetComponent<Animation>().Play(); //plays the default animation applied to our treasureChest model
        //treasureChest.animation.Play("other animation");
        // Destroy(gameObject);// destroys the gameobject
        }
    }
}
