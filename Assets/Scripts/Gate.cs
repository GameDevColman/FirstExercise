using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Gate : MonoBehaviour
{
  public PlayerInventory playerInventory;
  Animator animator;
  public AudioClip gateSound;

    void Start()
    {
        animator = GetComponent<Animator>();  
    }

  private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if (playerInventory.DoesHaveGateKey)
            {
                AudioSource.PlayClipAtPoint(gateSound, transform.position);
                GateControl("Open");
                StartCoroutine(DelaySceneLoad());
                // new WaitForSeconds(3f);
                // SceneManager.LoadScene(2);
            } 
            else 
            {
                AudioSource.PlayClipAtPoint(gateSound, transform.position);
                GateControl("Close");
                playerInventory.DialogShow("You can't escape without a key");
            }
        }
    }
 
    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }

    private void GateControl(string state)
    {
       animator.SetTrigger(state);
    }
}
