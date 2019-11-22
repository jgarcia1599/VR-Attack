using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//behavior of the bullets after been shot
public class ShootAway : MonoBehaviour {

        public GameObject gun;//the gun
        public int num=0;
        public float speed;//speed of the bullets
        private Vector3 direction;//direction of the bullets
        
        void Start()
        {
           num += 1;
           direction = gun.transform.forward;//set direction as the direction the gun points to 
        
        
        }

    

 

    
    void Update()
        {
        if (num >1)
        {
            transform.position = transform.position + speed * direction;//the bullets fly with speed "speed" and direction "direction"
            transform.Rotate(new Vector3( 0.0f, Time.time, Time.time) * 50.0f);//self rotation of bullets
        }
       
        }
    

}
