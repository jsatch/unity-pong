using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float initialSpeed;

    public Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = new Vector3(-initialSpeed, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  speed * Time.deltaTime;
        //transform.position = new Vector3(
        //    transform.position.x + (speed * Time.deltaTime),
        //    transform.position.y,
        //    0.0f
        //);
    }

    public void ChangeDirection(float paddleMovement)
    {
        float speedY = speed.y + Random.Range(1.0f, 4f);
        speed = new Vector3(-speed.x, paddleMovement * speedY, 0.0f);
    }

    public void WallHitted()
    {
        speed = new Vector3(speed.x, -speed.y, 0.0f);
    }
}
