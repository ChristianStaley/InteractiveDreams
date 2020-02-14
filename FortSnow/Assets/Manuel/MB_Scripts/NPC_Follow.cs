using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Follow : MonoBehaviour
{
    public string st_target_class = "Player";

    // Movement
    public bool bl_chase = true;
    public float fl_chase_dist_max = 10;
    public float fl_chase_dist_min = 3;
    public float fl_chase_speed = 3;


    
    public GameObject go_target;
    private CharacterController cc_NPC;

    // Start is called before the first frame update
    void Start()
    {
        cc_NPC = GetComponent<CharacterController>();

        if (!go_target)
            go_target = GameObject.FindWithTag(st_target_class);
    }

    // Update is called once per frame
    void Update()
    {
        if (bl_chase)
        {
            NPC_Move();
        }
        
    }
    void NPC_Move()
    {
        
         
            if (Vector3.Distance(transform.position, go_target.transform.position) < fl_chase_dist_max)
            {   // Face the Target
                transform.LookAt(go_target.transform.position);

                if (Vector3.Distance(transform.position, go_target.transform.position) > fl_chase_dist_min)
                {   // Move towards the target
                    cc_NPC.SimpleMove(fl_chase_speed * transform.TransformDirection(Vector3.forward));
                }
            }
        
     
     
    }//-----
}
