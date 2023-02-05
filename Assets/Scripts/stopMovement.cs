using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMovement : MonoBehaviour
{
    public PlayerController playerMovementRef;

    void Start()
    {
        StartCoroutine("DisableScript");
    }

    IEnumerator DisableScript()
    {
        playerMovementRef.enabled = false;

        yield return new WaitForSeconds(3f);

        playerMovementRef.enabled = true;
    }
}
