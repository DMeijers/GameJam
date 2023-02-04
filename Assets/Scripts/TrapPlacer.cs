using System.Collections;
using System.Collections.Generic;
using Coherence.Prefs;
using UnityEngine;

public class TrapPlacer : MonoBehaviour
{
    public GameObject Trap;
    private GameObject myposition;

    private void Start()
    {
        myposition = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("F"))
        {
            Instantiate(Trap, myposition.transform.position, myposition.transform.rotation);
        }
    }
}
