using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    
    public PlayerController playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trap")
        {
            gameObject.GetComponent<stopMovement>().enabled = true;

        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
