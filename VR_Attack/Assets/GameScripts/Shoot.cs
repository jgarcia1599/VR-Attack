using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    //Beam is the bullet, music is the sound of shooting
    public GameObject Beam;
    public AudioSource music;
	//detect if user tries to shoot five times a second
	void Start () {
        InvokeRepeating("SH", 0, 0.2f);
    }
	
	
	void Update () {
    
	}

    //play the shooting sound and generate a new bullet in front of the gun
    void SH()
    {
        if (Input.GetButton("B")||Input.GetMouseButtonDown(0))
        {
            music.Play();
            Instantiate(Beam, transform.position, Quaternion.identity);
        }
    }
}
