using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopstickBehaviour : MonoBehaviour
{
    
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //other.transform.parent = hand.gameObject.transform;

        if (other.gameObject.CompareTag("Interactable"))
        {
            other.transform.parent = hand.gameObject.transform;
        }

        else
        {
            GameObject triggersParent = other.gameObject.transform.parent.gameObject;
            if (triggersParent.gameObject.CompareTag("Interactable"))
            {
                triggersParent.transform.parent = hand.gameObject.transform;
            }
        }
        //triggersParent.transform.parent = hand.gameObject.transform;

        

        //else if (triggersParent.gameObject.CompareTag("Interactable"))
       // {
            
       // }

        //if (triggersParent.gameObject.CompareTag("inHand"))
        //{
        //  Debug.Log("I am held already");
        //}
        //else
        //{
        //triggersParent.gameObject.tag = "inHand";

            //}
    }
}
