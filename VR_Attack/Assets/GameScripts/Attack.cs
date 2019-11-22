using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attacks of enemies
public class Attack : MonoBehaviour {
    public float attackSpeed ;//how many seconds the enemies are going to attack once
    public float damage ;//amount of damage enemies do to Ali
    public GameObject user;//Ali(the player)
    PlayerHealth playerhealth;//health

    float CountTime;//timer
	
	void Start () {
        user = GameObject.FindGameObjectWithTag("Player");//find Ali
        playerhealth = user.GetComponent<PlayerHealth>();
	}
	
	//attack the player every "attackspeed" time and do damage with amoung of "damage"
	void Update () {
        CountTime += Time.deltaTime;
		if((CountTime > attackSpeed )&& (user.transform.position-transform.position).magnitude<5)
        {
            CountTime = 0;
            playerhealth.takeDamage(damage);
        }
	}
   
}
