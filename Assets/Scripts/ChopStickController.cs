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

    private static int pinchLimit = 80;
    private int pinchCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movements 1 & 2
        if (Input.GetKey(KeyCode.UpArrow) && pinchCounter > -pinchLimit)
        {
            pinchCounter -= 1;
            controlChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && pinchCounter < pinchLimit)
        {
            pinchCounter += 1;
            controlChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
        }


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
            hand.transform.position += Vector3.back * movementSpeedFactor * Time.deltaTime;

        if (Input.GetKey(KeyCode.R))
            hand.transform.position += Vector3.forward * movementSpeedFactor * Time.deltaTime;

    }
}
