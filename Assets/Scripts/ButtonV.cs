using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonV : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void MakeButtonVisible()
    {
        gameObject.SetActive(true);
        // AudioManager.Instance.play("end_1");
    }
}
