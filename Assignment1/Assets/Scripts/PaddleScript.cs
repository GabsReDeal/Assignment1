using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

    public float blueSpeed;
    public Rigidbody2D bluePaddleRb;
    public GameObject bluePaddle;
    public GameObject redPaddle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Red paddle controls
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 14) - 8;

        Vector3 newPaddlePos = new Vector3(redPaddle.transform.position.x, mousePosInUnits, redPaddle.transform.position.z);
        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -7.5f, 7.5f);

        redPaddle.transform.position = newPaddlePos;


        //Blue paddle controls
        if (Input.GetKey("up"))
        {
            //print("up");
            bluePaddleRb.AddForce(bluePaddle.transform.right * blueSpeed);
        }

        else if (Input.GetKey("down"))
        {
            //print("down");
            bluePaddleRb.AddForce(bluePaddle.transform.right * (blueSpeed * -1));
        }
    }
}
