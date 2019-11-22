using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

// the health of player
public class PlayerHealth : MonoBehaviour {
    public float fullHealth = 500;//maximum health
    public float currentHealth;//current health
    public Slider healthslider;//the health bar in UI
    public AudioSource music;//the sound when being attacked
    public string name;//the name of the next scene
    

   
    private bool isDead=false;//test if Ali (the character) is dead
   

    void Awake()
    {
        currentHealth = fullHealth;
        
    }
	
	void Start () {
       
	}
	
	
	void Update () {
 
        if (isDead)
        {
            SceneManager.LoadScene(name);//load the next scene if Ali is dead
            gameObject.SetActive(false);
            


        }
	}

    public void takeDamage(float amount)
    {
        music.Play();//play the sound of huting when Ali is being attacked
        currentHealth -= amount;//reduce health
        
        healthslider.value = currentHealth;//show the health on UI
        
        //actions when Ali is dead
        if (currentHealth <= 0)
        {
            music.Play();
            isDead = true;
        }
    }
}
