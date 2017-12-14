using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text blueGoalText;
    public Text redGoalText;
    public Text blueScoreText;
    public Text redScoreText;
    public int maxGoal;
    private int blueGoal;
    private int redGoal;
    int blueScore;
    int redScore;
    public GameObject ball;
  
    LevelManager levelManager = new LevelManager();

    //BallScript ballScript = new BallScript();
    void Awake()
    {
        DontDestroyOnLoad(this);
        print("Did not destroy " + this);
        print("Blue Total Score: " + blueScore);
        print("Red Total Score: " + redScore);
    }

    // Use this for initialization
    void Start () {
        blueGoal = 0;
        redGoal = 0;
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void BlueScores()
    {
        blueGoal++;
        blueScore += addScore();
        //print("Blue: " + blueGoal + "/" + maxGoal);
        //print("Blue Score: " + blueScore);
        blueGoalText.text = ("Goals : " + blueGoal);
        blueScoreText.text = ("Score : " + blueScore);

        if (blueGoal >= maxGoal)
        {
            levelManager.LoadNextScene();
        }
        else
        {
            ball.SendMessage("BallReset", null, SendMessageOptions.RequireReceiver);
        }

        //ballScript.BallReset();
    }

    public void RedScores()
    {
        redGoal++;
        redScore += addScore();
        //print("Red Goal: " + redGoal + "/" + maxGoal);
        //print("Red Score: " + redScore);
        redGoalText.text = ("Goals : " + redGoal);
        redScoreText.text = ("Score : " + redScore);

        if (redGoal >= maxGoal)
        {
            levelManager.LoadNextScene();
        }
        else
        {
            ball.SendMessage("BallReset", null, SendMessageOptions.RequireReceiver);
        }

        //ballScript.BallReset();
    }


    int addScore()
    {

        int score = 0;

        if (levelManager.GetSceneName() == "Level1")
        {
            score = 10;
        }
        else if (levelManager.GetSceneName() == "Level2")
        {
            score = 15;
        }
        else if (levelManager.GetSceneName() == "Level3")
        {
            score = 20;
        }

        return score;
    }
}
