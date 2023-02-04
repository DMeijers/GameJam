using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravitybody : MonoBehaviour
{

    public FauxGravityAttractor attractor;
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
        attractor = GameObject.FindObjectOfType<FauxGravityAttractor>();
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);
    }
}
