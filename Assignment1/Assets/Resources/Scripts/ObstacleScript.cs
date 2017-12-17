using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    public Transform obstacle; //Obstacle from the Hierarchy
    public Transform obstacleMove; //PointB from the Hierarchy

    Vector3 pointA; //Initial position of Obstacle gob
    Vector3 pointB; //Position of pointB gob

    Vector3 nextPoint;  //to check which point is next for the obstacle gob to move.

    int speed = 1;  //Speed of which the Obstacle gob will move towards it's destination (pointA or pointB).

    // Use this for initialization
    void Start () {
        pointA = obstacle.position; // Intializing pointA to have the position of Obstacle gob
        pointB = obstacleMove.position;  // Intializing pointB to have the position of pointB gob
        nextPoint = pointB; // At the start, the nextPoint is always pointB.
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
