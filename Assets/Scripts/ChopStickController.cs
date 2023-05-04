using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChopStickController : MonoBehaviour
{
    public GameObject hand;
    public GameObject baseChopstick;
    public GameObject controlChopstick;

    public float movementSpeedFactor = 5f;
    public float rotationSpeedFactor = 50f;
    public float anglingSpeedFactorX = 10f;
    public float anglingSpeedFactorY = -10f;

    private static int pinchLimit = 80;
    private int pinchCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movements 1 & 2 (Pinching)
        if (Input.GetMouseButton(0) && pinchCounter > -pinchLimit)
        {
            pinchCounter -= 1;
            controlChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
        }

        if (Input.GetMouseButton(1) && pinchCounter < pinchLimit)
        {
            pinchCounter += 1;
            controlChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
        }


        // Movements 3 & 4 (Rotation)
        if (Input.GetKey(KeyCode.E))
            hand.transform.Rotate(Vector3.forward * rotationSpeedFactor * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            hand.transform.Rotate(Vector3.back * rotationSpeedFactor * Time.deltaTime);


        // Movements 5 & 6 (Turn Right or Left)
       // if (Input.GetKey(KeyCode.D))
           // hand.transform.Rotate(Vector3.up * rotationSpeedFactor * Time.deltaTime);

        // if (Input.GetKey(KeyCode.A))
           // hand.transform.Rotate(Vector3.down * rotationSpeedFactor * Time.deltaTime);


        // Movements 7 & 9 (Turn down or up)
       // if (Input.GetKey(KeyCode.S))
          //  hand.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);

       // if (Input.GetKey(KeyCode.W))
           // hand.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);

        // This should simplify the currently ignored movements above (will remove in future version)

        float h = anglingSpeedFactorX * Input.GetAxis("Mouse X");
        float v = anglingSpeedFactorY * Input.GetAxis("Mouse Y");
        if (Input.GetKey(KeyCode.P))
            transform.Rotate(v, h, 0);

        // Movements 10 & 11 (Move backwards or forwards)
        if (Input.GetKey(KeyCode.F))
            hand.transform.position -= transform.forward * Time.deltaTime * movementSpeedFactor;

        if (Input.GetKey(KeyCode.R))
            hand.transform.position += transform.forward * Time.deltaTime * movementSpeedFactor;

    }
}
