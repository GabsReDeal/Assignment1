using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

    ScoreScript score = new ScoreScript();
    public GameObject scoreScript;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.name == "Blue_Score_Border")
        {
            scoreScript.SendMessage("BlueScores", null, SendMessageOptions.RequireReceiver);
        }
        else if (transform.name == "Red_Score_Border")
        {
            scoreScript.SendMessage("RedScores", null, SendMessageOptions.RequireReceiver);
        }
    }
}
