using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB_Animated : MonoBehaviour
{
    public string st_parameter = "bl_moving";
    private Animator an_attached;
    private CharacterController cc_attached;

    // Start is called before the first frame update
    void Start()
    {
        an_attached = GetComponentInChildren<Animator>();

        cc_attached = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc_attached)
        {
            if (cc_attached.velocity.z != 0)
            {
                an_attached.SetBool(st_parameter, true);
            }
            else
            {
                an_attached.SetBool(st_parameter, false);
            }
        }

     

    }
}
