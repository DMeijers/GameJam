using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawnerHuman : MonoBehaviour
{
   public GameObject[] objectArray; // array of prefab objects
public string targetTag = "target";
public float height = 1.0f;
public float holdDuration = 3.0f;
public float spawnRadius = 1.0f;

private GameObject nearestTarget;
private float distance;
private float holdStartTime;

public Image image;

public int objectCounter = 0;

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
                    float currentDistance = Vector3.Distance(transform.position, target.transform.position);
                    if (currentDistance < distance)
                    {
                        distance = currentDistance;
                        nearestTarget = target;
                    }
                }

                if (nearestTarget != null && distance <= spawnRadius)
                {
                    int randomIndex = Random.Range(0, objectArray.Length); // choose a random index from the array
                    GameObject objectToSpawn = objectArray[randomIndex];
                    Vector3 spawnPosition = nearestTarget.transform.position + new Vector3(0, height, 0);
                    Quaternion spawnRotation = transform.rotation;

                    GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, spawnRotation);
                    spawnedObject.transform.parent = nearestTarget.transform;
                        image.fillAmount -= 0.2f;
                        objectCounter++;
                        nearestTarget.GetComponent<Renderer>().material.color = HexToColor("E71B39");
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
private Color HexToColor(string hex)
{
    byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
    byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
    byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
    return new Color32(r, g, b, 255);
}
}
