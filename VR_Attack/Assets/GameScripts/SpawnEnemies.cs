using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//generating more and more enemies with faster rate by the map
public class SpawnEnemies : MonoBehaviour {
    
    public GameObject A1;//enemy type one
    public GameObject A2;//enemy type two
    public float spawnSpeed;//time of generating one enemies
    public AudioSource music;//the background music of the game
    private float timer;
	
    void Awake()
    {
        //play the background music repeatedly
        music.playOnAwake=true;
        music.loop = true;
    }
	void Start () {
        
        
	}
	
	
	void Update () {
        //call "spawn" function every "spawnSpeed" time, which is becoming smaller until to 1
        timer += Time.deltaTime;
        if (timer > spawnSpeed)
        {
            timer = 0;
            Invoke("spawn",0);
            if (spawnSpeed > 1)
            {
                spawnSpeed -= 0.01f;
            }

        }
        
	}
     void spawn()
    {
        
        Vector3 spawnPoint = new Vector3(Random.value * 200 - 50, -1.0f, Random.value * 200 - 100);//randomly select the place an enemy spawns
        float type = Random.value;//randomly select which enemy to spawn
        if (type>0.5)
        {
            Instantiate(A1, spawnPoint, Quaternion.identity);//put a new enemy type one at "spawnPoint"
        }
        else
        {
            Instantiate(A2, spawnPoint, Quaternion.identity);//put a new enemy type two at "spawnPoint"
        }
    }
}
