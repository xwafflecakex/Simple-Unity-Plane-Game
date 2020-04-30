using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    public float speed = 25.45f; // 15m/s
    private float turnSpeed = 20.45f;

    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Implementing Vehicle Movment
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Forward deltaTime is the time b/w game frames - so this is moving every second, not every frame
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate left & right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}