using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 30;
    private Rigidbody2D rb;
    public string axis = "Vertical";

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate(){
        float y = Input.GetAxisRaw(axis);
        rb.velocity = new Vector2(0, y) * speed;
    }
}
