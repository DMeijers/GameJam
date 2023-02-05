using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider; //reference to the slider

    public void SetMaxEnergy(int energy) //mehtod to set the slider to max (will be called from other script when game starts)
    {
        slider.maxValue = energy; //set the max value to 'energy'
        slider.value = energy; //set the current value to 'energy'
    }
    public void SetEnergy(int energy) //method to set the slider (will be called when losing energy)
    {
        slider.value = energy; //set the slider to the new value
    }
}
