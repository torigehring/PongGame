using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButtonController : MonoBehaviour
{       
    public void GoToHelp(){
        Debug.Log("Going to help screen");
        SceneManager.LoadScene(1);
    }

    public void GoToGame(){
        Debug.Log("Going to main scene");
        SceneManager.LoadScene(0);
    }
}
