using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int maxScore;
    private int blueScore;
    private int redScore;
    GameObject ball;

    LevelManager levelManager = new LevelManager();
    //BallScript ballScript = new BallScript();

    // Use this for initialization
    void Start () {
        ball = GameObject.FindGameObjectWithTag("Ball");
        blueScore = 0;
        redScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.name == "Blue_Score_Border")
        {
            blueScore++;
            print("Blue: " + blueScore);
            if(blueScore >= maxScore)
            {
                levelManager.LoadNextScene();
            }
            else
            {
                ball.SendMessage("BallReset", null, SendMessageOptions.RequireReceiver);
            }
            
            //ballScript.BallReset();

        }
        else if(transform.name == "Red_Score_Border")
        {
            redScore++;
            print("Red: " + redScore);
            if (redScore >= maxScore)
            {
                levelManager.LoadNextScene();
            }
            else
            {
                ball.SendMessage("BallReset", null, SendMessageOptions.RequireReceiver);
            }

            //ballScript.BallReset();

        }
    }
}
