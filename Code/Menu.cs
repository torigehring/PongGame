using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Update is called once per frame
    public void FixedUpdate(){
        if (Input.GetKey("escape")){
            Application.Quit();
        }
    }
}
