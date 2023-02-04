using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
public GameObject objectToSpawn;
    public string targetTag = "Target";
    public float height = 1.0f;
    public float holdDuration = 3.0f;
    public float spawnRadius = 1.0f;
    public int objectCounter = 0;
    private GameObject nearestTarget;
    private float distance;
    private float holdStartTime;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
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
                        Debug.Log(distance);
                        float currentDistance = Vector3.Distance(transform.position, target.transform.position);
                        if (currentDistance < distance)
                        {
                            distance = currentDistance;
                            nearestTarget = target;
                            Debug.Log(nearestTarget);
                        }
                    }

                    if (nearestTarget != null && distance <= spawnRadius)
                    {
                        Vector3 spawnPosition = nearestTarget.transform.position + new Vector3(0, height, 0);
                        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                        spawnedObject.transform.parent = nearestTarget.transform;
                        objectCounter++;
                        Debug.Log("Object spawned on nearest target!");
                    }

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
