using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{   
    BallMovement collisionHandler;
    

    // Start is called before the first frame update
    void Start()
    {
        collisionHandler = GetComponent<BallMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        { 
            float movement = collision.gameObject.GetComponent<PaddleMovement>().GetMovement();
            collisionHandler.ChangeDirection(movement);
        }else if (collision.gameObject.tag == "Wall")
        {
            collisionHandler.WallHitted();
        }

    }
}
