using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GateClose : MonoBehaviour
{
  public PlayerInventory playerInventory;
  public Animator gateAnimation;
  public AudioClip gateSound;

  private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if (playerInventory.DoesHaveGateKey) {
                SceneManager.LoadScene(2);
            } else {
                        AudioSource.PlayClipAtPoint(gateSound, transform.position);
                        gateAnimation.SetBool("closeGate", true);
                        playerInventory.LookBehind();
                        //transform.Rotate(new Vector3(0,180,0));
                        playerInventory.DialogShow("Now you can't escape");
            }

        }
    }

    private void OnTriggerExit(Collider collider)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                gateAnimation.SetBool("closeGate", false);
            }
        }
}
