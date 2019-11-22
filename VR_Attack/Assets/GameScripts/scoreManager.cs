using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//this is the score panel in UI
public class scoreManager : MonoBehaviour {
  
    public static int score;//the score
    Text txt;
	
	void Start () {
        
        score = 0;
        txt = GetComponent<Text>();
        
}
	
	
	void Update () {
        //show the score on the screen
        txt.text = "Score: " + score;
	}

    public void addScore()
    {
        //add one score
        score += 1;
    }
}
