using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForPlayer : MonoBehaviour
{
    public void UItoDisable()
    {
        gameObject.SetActive(false);

    }
    public void UItoEnable()
    {
        gameObject.SetActive(true);

    }

}
