using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopStickController : MonoBehaviour
{
    public GameObject baseChopstick;
    public GameObject controlChopstick;

    public float movementSpeedFactor = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Control Cube1 using WASD keys
        if (Input.GetKey(KeyCode.R))
        {
            controlChopstick.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
            baseChopstick.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.F))
        {
            controlChopstick.transform.position += Vector3.forward * movementSpeedFactor * Time.deltaTime;
            baseChopstick.transform.position += Vector3.forward * movementSpeedFactor * Time.deltaTime;
        }


        //if (Input.GetKey(KeyCode.S))
        //    cube1.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
        //if (Input.GetKey(KeyCode.A))
        //    cube1.transform.position += Vector3.left * movementSpeedFactor * Time.deltaTime;
        //if (Input.GetKey(KeyCode.D))
        //    cube1.transform.position += Vector3.right * movementSpeedFactor * Time.deltaTime;

    }
}
