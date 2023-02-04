using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image image; //reference to the slider

    public float waitTime = 30.0f;

    private void Update()
    {
        image.fillAmount -= 1.0f / waitTime * Time.deltaTime;
    }
}
