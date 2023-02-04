using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceBar : MonoBehaviour
{
    public float resources;
    public float maxResources;

    public Slider resourceBar;
    public float dValue;

    // Start is called before the first frame update
    void Start()
    {
        maxResources = resources;
        resourceBar.maxValue = maxResources;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            DecreaseResources();
        else if (resources != maxResources)
            IncreaseResources();

        resourceBar.value = resources;
    }

    private void DecreaseResources()
    {
        if (resources != 0)
            resources -= dValue * Time.deltaTime;
    }

    private void IncreaseResources()
    {
      resources += dValue * Time.deltaTime;
    }
}
