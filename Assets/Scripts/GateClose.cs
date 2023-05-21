using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GateClose : MonoBehaviour
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
                SceneManager.LoadScene(2);
            } 
            else 
            {
                AudioSource.PlayClipAtPoint(gateSound, transform.position);
                GateControl("Close");
                playerInventory.DialogShow("Now you can't escape");
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            // gateAnimation.SetBool("closeGate", false);
        }
    }

    private void GateControl(string state)
    {
       animator.SetTrigger(state);
    }
}
