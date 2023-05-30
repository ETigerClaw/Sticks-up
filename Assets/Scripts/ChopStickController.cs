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

    private static int pinchLimit = 15;
    private int pinchCounter = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Movements for pinching
        if (Input.GetMouseButton(1) && pinchCounter > -pinchLimit)
        {
            pinchCounter -= 1;
            controlChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
        }

        if (Input.GetMouseButton(0) && pinchCounter < pinchLimit)
        {
            pinchCounter += 1;
            controlChopstick.transform.Rotate(Vector3.left * rotationSpeedFactor * Time.deltaTime);
            baseChopstick.transform.Rotate(Vector3.right * rotationSpeedFactor * Time.deltaTime);
        }


        // Movements for rotation
        if (Input.GetKey(KeyCode.E) || Input.GetMouseButton(4))
            hand.transform.Rotate(Vector3.forward * rotationSpeedFactor * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q) || Input.GetMouseButton(3))
            hand.transform.Rotate(Vector3.back * rotationSpeedFactor * Time.deltaTime);

        // Movement for changing direction the chopsticks are facing
        float h = anglingSpeedFactorX * Input.GetAxis("Mouse X");
        float v = anglingSpeedFactorY * Input.GetAxis("Mouse Y");
        if (Input.GetKey(KeyCode.P) || Input.GetMouseButton(2))
            transform.Rotate(v, h, 0);

        // Movements backwards or forwards. NOTE: the scrollwheel option is slower and less smooth than ideal, but this is a low priority
        if (Input.GetKey(KeyCode.F) || Input.GetAxis("Mouse ScrollWheel") < 0f)
            hand.transform.position -= (transform.forward * Time.deltaTime * movementSpeedFactor);

        if (Input.GetKey(KeyCode.R) || Input.GetAxis("Mouse ScrollWheel") > 0f)
            hand.transform.position += transform.forward * Time.deltaTime * movementSpeedFactor;
    }

}
