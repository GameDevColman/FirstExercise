using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas quitMenu;
    public Button startText;
    public Button exitText; 
    // Start is called before the first frame update
    void Start()
    {
        quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void PlayLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void Exit_No_Apllication()
    {
        Application.Quit();
    }
}
