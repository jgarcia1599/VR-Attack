using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//to test if an enemt is been killed
public class Killed : MonoBehaviour {
    public int num;//number of bullet an enemy can handle
    
    public AudioSource mu;//the sound effect of an enemy's death
    
    private Rigidbody rb;
	
   
	void Start () {
        rb = GetComponent<Rigidbody>();
        
	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //destroy the enemy if it has no life anymore, minus onoe life if it still has after collide with a bullet
        if (other.gameObject.CompareTag("bullet"))
        {
           
            if (num <= 1)
            {
                
                
                Destroy(gameObject);
                scoreManager.score += 1;//add one score
                mu.Play();

            }
            else
            {
                num -= 1;
               
                
            }
         
        }
    }

}
