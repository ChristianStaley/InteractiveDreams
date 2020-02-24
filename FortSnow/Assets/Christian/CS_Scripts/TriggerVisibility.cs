using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVisibility : MonoBehaviour
{
    public bool isVisible = false;

    void Update()
    {
        if (isVisible)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
            gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
