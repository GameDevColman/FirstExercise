using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttton : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
     public void doSomething()
    {
        Debug.Log(slider.value.ToString());
    }
}
