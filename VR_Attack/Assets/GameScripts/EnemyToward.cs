using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make enemies move and face forward to the player
public class EnemyToward : MonoBehaviour {
    public GameObject target;//the target enemies are going to 
    public float speed;//the speed of enemies
	
	void Start () {
		
	}
	
	
	void Update () {
        Vector3 path =target.transform.position-transform.position;//calculate the path to target
        path = path / path.magnitude;//calculate only the direction of the path
        path.Set(path.x, 0.0f, path.z);//set the path on the ground
        transform.forward = path;//make enemies look forward to the target
        
        transform.position = transform.position + speed * path;//move enemies with speed "speed"
        
	}
}
