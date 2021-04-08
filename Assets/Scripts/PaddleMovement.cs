using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputType
{
    Keyboard, Mouse
}

public class PaddleMovement : MonoBehaviour
{
    public float speed;
    public InputType inputType;

    private float movement = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputType == InputType.Keyboard)
        {
            movement = Input.GetAxis("Vertical");
        }else  if (inputType == InputType.Mouse)
        {
            movement = Input.GetAxis("Mouse Y");
            Debug.Log(movement);
        }

        transform.position = new Vector3(
            transform.position.x, 
            Mathf.Clamp(transform.position.y + (speed * movement * Time.deltaTime), -4.0f, 4.0f) , 
            .0f);
    }

    public float GetMovement()
    {
        return movement;
    }
}
