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
        l_worldLight = gameObject.GetComponent<Light>();
        if(l_worldLight == null)
        {
            GameObject.Find("Sun").GetComponent<Light>();
        }
            
        theTime = System.DateTime.Now;
        _time = theTime.Hour + ":" + theTime.Minute + ":" + theTime.Second;

        print(_time);

        if(theTime.Hour == 24 && theTime.Hour > 6)
        {
            l_worldLight.transform.Rotate(-150, 0, 0);
        }
        if (theTime.Hour <= 6 && theTime.Hour > 12)
        {
            l_worldLight.transform.Rotate(-100, 0, 0);
        }
        if (theTime.Hour <= 12 && theTime.Hour > 18)
        {
            l_worldLight.transform.Rotate(0, 0, 0);
        }
        else if(theTime.Hour <= 18 && theTime.Hour > 24)
        {
            l_worldLight.transform.Rotate(100, 0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            l_worldLight.transform.Rotate(-50, 0, 0);
        }
        if (Input.GetKeyDown("t"))
        {
            l_worldLight.transform.Rotate(50, 0, 0);
        }

    }
}
