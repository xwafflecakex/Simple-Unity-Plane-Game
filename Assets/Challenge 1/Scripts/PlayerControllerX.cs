using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 1f;
    private float rotationSpeed = 35f;
    public float maxSpeed = 50f;
    private float pitchRate = 12.5f; // This is for rotating the plane about the y-axis

    // Start is called before the first frame update
    void Start()
    {

    }

    /* Update():
     * Called every frame
     * Used for reg updates
     * Moving non-physics objects
     * simple timers
     * Receiving Input
     * !! Update times vary !!
     */
     /* FixedUpdate():
      * Called every physics step
      * !! Intervals b/w calls are always consistent
      * Adjusting Ridgidbody objects (physics)
      */

    // Update is called once per frame
    void FixedUpdate()
    {

        // move the plane forward at a constant rate
        // Can Increase and decrease speed of plane Via W and S key, respectively.
        if (Input.GetKeyDown("w") && speed <= maxSpeed)
        {
           speed += 5.0f;
           transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKeyDown("s") && speed >= 0f)
        {
           speed += -5.0f;
           transform.Translate(Vector3.forward * Time.deltaTime * speed);

        } else if (speed <= 0f)
        {
            speed = 0;
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        // get the user's vertical input

        pitchRate = Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed;
        //yawRate = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        transform.Rotate(Vector3.left * pitchRate);
        //transform.Rotate(Vector3.down * yawRate);
        transform.RotateAround(transform.position, Vector3.back, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);



        /* tilt the plane up/down based on up/down arrow keys
        This was not smooth experience, it would only move a bit per frame rather then the smooth experience with GetAxies.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up key was pressed.");
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * pitchRate);
        } else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down key was pressed.");
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * pitchRate);
        }
        */


    }
}
