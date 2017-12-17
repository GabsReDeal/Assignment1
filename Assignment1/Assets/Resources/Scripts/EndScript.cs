using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour {

    ScoreScript score = new ScoreScript();
    public Text scoreText;

    // Use this for initialization
    void Start () {
        if (ScoreScript.blueScore > ScoreScript.redScore)
        {
            scoreText.text = ("Blue wins!\n" +
                              "Blue score : " + ScoreScript.blueScore +
                              "Red score : " + ScoreScript.redScore);
        }
        else if(ScoreScript.blueScore < ScoreScript.redScore)
        {
            scoreText.text = ("Red wins!" +
                              "\nBlue score : " + ScoreScript.blueScore +
                              "\nRed score : " + ScoreScript.redScore);
        }
        else
        {
            scoreText.text = ("It's a tie!" +
                              "\nBlue score : " + ScoreScript.blueScore +
                              "\nRed score : " + ScoreScript.redScore);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
