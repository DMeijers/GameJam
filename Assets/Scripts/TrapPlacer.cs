using System.Collections;
using System.Collections.Generic;
using Coherence.Prefs;
using UnityEngine;

public class TrapPlacer : MonoBehaviour
{
    /*public GameObject Trap;
    private GameObject myposition;

    private void Start()
    {
        myposition = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F)) 
        {
            Instantiate(Trap, transform.position, myposition.transform.rotation);
        }
    }*/

    public GameObject objectArray; // array of prefab objects
    public string targetTag = "trap";
    public float height = 1.0f;
    public float holdDuration = 5.0f;
    public float spawnRadius = 1.0f;
    public GameObject[] specificObjects;

    private GameObject nearestTarget;
    private float distance;
    private float holdStartTime;

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (holdStartTime == 0)
            {
                holdStartTime = Time.time;
            }
            else
            {
                float timeHeld = Time.time - holdStartTime;
                if (timeHeld >= holdDuration)
                {
                    GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);
                    nearestTarget = null;
                    distance = Mathf.Infinity;
                    foreach (GameObject target in targets)
                    {
                        float currentDistance = Vector3.Distance(transform.position, target.transform.position);
                        if (currentDistance < distance)
                        {
                            distance = currentDistance;
                            nearestTarget = target;
                        }
                    }

                    /*if (nearestTarget != null && distance <= spawnRadius)
                    {
                        foreach (GameObject specificObject in specificObjects)
                        {
                            if (nearestTarget == specificObject)
                            {
                                Destroy(nearestTarget);
                                break;
                            }
                        }

                        int randomIndex = Random.Range(0, objectArray.Length); // choose a random index from the array*/
                        GameObject objectToSpawn = objectArray;
                        Vector3 spawnPosition = nearestTarget.transform.position + new Vector3(0, height, 0);
                        Quaternion spawnRotation = transform.rotation;

                       GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, spawnRotation);
                       spawnedObject.transform.parent = nearestTarget.transform;


                    holdStartTime = 0;
                }
            }
        }
        else
        {
            holdStartTime = 0;
        }
    }

}
