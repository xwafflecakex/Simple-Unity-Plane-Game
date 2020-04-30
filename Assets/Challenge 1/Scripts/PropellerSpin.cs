using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 80.5f;
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.forward, speed * Time.deltaTime);

    }
}
