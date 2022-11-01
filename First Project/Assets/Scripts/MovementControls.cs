using UnityEngine;
using System.Collections;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    
    
    void Update ()
    {
        Movement();
    }
    
    
    void Movement ()
    {
        float forwardBackwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float leftRightMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardBackwardMovement);
        transform.Rotate(Vector3.up * leftRightMovement);
    }
}