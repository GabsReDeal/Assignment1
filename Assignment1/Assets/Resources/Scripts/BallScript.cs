using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private Rigidbody2D rb;
    private Vector2 vel;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        Invoke("BallStart", 2); //This will wait 2 seconds before executing the BallStart method.
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BallStart()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector2(35, -5));
        }
        else
        {
            rb.AddForce(new Vector2(-35, -5));
        }
        
    }

    public void BallReset()
    {

        rb.velocity = Vector2.zero; // Setting the ball's velocity back to 0
        transform.position = new Vector3(0, 0, transform.position.z); // Sets the ball to position x=0 y=0 and z=currentZ

        Invoke("BallStart", 1); // Waits 1 second before starting the BallStart method
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2.0f) + (collision.collider.attachedRigidbody.velocity.y / 3.0f);
            rb.velocity = vel;
        }
        
    }   
}
