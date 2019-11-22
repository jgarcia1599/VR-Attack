using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this was not used in the game
public class RollTheBall : MonoBehaviour {
    public float speed;

    private Rigidbody ball;

    void Start()
    {
        ball = GetComponent<Rigidbody>();

    }
    void Update()
    {
    
        float hori = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(hori, 0.0f, ver);
        ball.AddForce(direction * speed);
    }
}
