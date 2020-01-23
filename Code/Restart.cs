using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Wait one second and restart the game
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        // Wait one second
        yield return new WaitForSeconds(1);
        // Go to restart screen after waiting
        SceneManager.LoadScene(0);
    }
}
