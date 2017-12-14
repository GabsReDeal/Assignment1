using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    public Transform obstacle;
    public Transform obstacleMove;

    Vector3 pointA;
    Vector3 pointB;

    Vector3 nextPoint;

    int speed = 1;
    // Use this for initialization
    void Start () {
        pointA = obstacle.position;
        pointB = obstacleMove.position;
        nextPoint = pointB;
    }
	
	// Update is called once per frame
	void Update () {
         Move();

    }

    void Move()
    {
        obstacle.position = Vector3.MoveTowards(obstacle.position, nextPoint, (speed * Time.deltaTime));
        
        if(Vector3.Distance(obstacle.position, nextPoint) <=0.1)
        {
            ChangePoint();
        }
    }

    void ChangePoint()
    {
        if(nextPoint != pointA)
        {
            nextPoint = pointA;
        }
        else
        {
            nextPoint = pointB;
        }
    }
}
