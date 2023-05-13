using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision Entered");
        //foreach (ContactPoint contact in collision.contacts)
        //{
           // Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
    }
}
