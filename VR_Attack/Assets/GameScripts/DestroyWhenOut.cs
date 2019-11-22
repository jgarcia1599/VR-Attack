using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the invisible cube destroy things that goes out of map
public class DestroyWhenOut : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
