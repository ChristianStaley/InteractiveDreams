using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Change_Time : MonoBehaviour
{
    public DateTime fl_currentTime;
    private Light l_worldLight;
    string _time;
    System.DateTime theTime;

    // Start is called before the first frame update
    void Start()
    {
        l_worldLight = GameObject.Find("Directional Light").GetComponent<Light>();
        theTime = System.DateTime.Now;
        _time = theTime.Hour + ":" + theTime.Minute + ":" + theTime.Second;

        print(_time);

        if (theTime.Hour <= 12)
        {
            l_worldLight.transform.Rotate(100, 100, 100);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
