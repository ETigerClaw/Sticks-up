using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mug : MonoBehaviour
{
    public float fill;
    public AnimationCurve spill_threshold_curve;

    public GameObject liquid;
    private Material liquidMat;

    public ParticleSystem coffeeSpillingParticles;
    private ParticleSystem.EmissionModule emission;

    // Start is called before the first frame update
    void Start()
    {
        liquidMat = liquid.GetComponent<Renderer>().material;

        emission = coffeeSpillingParticles.emission;
    }

    void FixedUpdate()
    {
        liquidMat.SetFloat("_Fill", fill);

        Vector3 mugVector = transform.up;

        //Vector product gives us a value between 1 and -1 for "vector simillarity"
        //1 would be 100% upright
        //0 would be horizontal
        //-1 would be 100% upsidedown
        float tilt = Vector3.Dot(mugVector, Vector3.up);
        //Debug.Log(tilt);

        bool shouldPour = tilt <= tiltToPour(fill);
        Debug.Log(shouldPour);

        emission.enabled = shouldPour;

    }

    float tiltToPour(float fill)
    {
        return spill_threshold_curve.Evaluate(fill);
    }
}
