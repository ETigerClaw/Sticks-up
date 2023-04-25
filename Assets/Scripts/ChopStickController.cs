using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopStickController : MonoBehaviour
{
    public GameObject hand;
    public GameObject baseChopstick;
    public GameObject controlChopstick;

    public float movementSpeedFactor = 5f;
    public float rotationSpeedFactor = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movements 3 & 4
        if (Input.GetKey(KeyCode.W))
            hand.transform.Rotate(Vector3.forward * rotationSpeedFactor * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            hand.transform.Rotate(Vector3.back * rotationSpeedFactor * Time.deltaTime);


        // Movements 5 & 6
        if (Input.GetKey(KeyCode.E))
            hand.transform.Rotate(Vector3.up * rotationSpeedFactor * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            hand.transform.Rotate(Vector3.down * rotationSpeedFactor * Time.deltaTime);


        // Movements 7 & 9
        if (Input.GetKey(KeyCode.A))
            hand.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            hand.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);


        // Movements 10 & 11
        if (Input.GetKey(KeyCode.F))
        {
            controlChopstick.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
            baseChopstick.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            controlChopstick.transform.position += Vector3.forward * movementSpeedFactor * Time.deltaTime;
            baseChopstick.transform.position += Vector3.forward * movementSpeedFactor * Time.deltaTime;
        }


        //    chopstick.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;
        //    chopstick.transform.position += Vector3.left * movementSpeedFactor * Time.deltaTime;
        //    chopstick.transform.position += Vector3.right * movementSpeedFactor * Time.deltaTime;

    }
}
