using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//used to load scenes in UI
public class ButtonManage : MonoBehaviour {
 public void NewGameBtn(string name)
    {
        SceneManager.LoadScene(name);
    }

  public void exit()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetButton("A"))
        {
            SceneManager.LoadScene(name);
           
        }
        else if(Input.GetButton("X"))
            Application.Quit();
    }
}
