using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed = 7;
    private Rigidbody2D rb;
    public float radius;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        float x = 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void FixedUpdate(){
        if(rb.position.x > 7.9){
            StartCoroutine(Coroutine());
            SceneManager.LoadScene(2);
        }
        if(rb.position.x < -7.9){
            StartCoroutine(Coroutine());
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey("escape")){
            Application.Quit();
        }
    }

    IEnumerator Coroutine(){
        // Freeze the ball 
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        // wait one second
        yield return new WaitForSeconds(1);
    }

}
