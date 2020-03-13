using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB_Patrol : MonoBehaviour
{
    // Movement
    //public bool bl_chase = true;
    public float fl_chase_dist_max = 10;
    public float fl_chase_dist_min = 3;
    public float fl_chase_speed = 3;
    public float fl_range = 15;
    // Movement
    //public GameObject go_target;
    public GameObject[] GOS_waypoints;
    public float fl_speed = 3;
    private int in_next_wp = 0;

    public GameObject GO_target;
    private CharacterController cc_NPC;
    // Start is called before the first frame update
    void Start()
    {
        // Find the Game Objects we need to interact with
        cc_NPC = GetComponent<CharacterController>();
        // if no target is set find the first tagged as the enemy
        if (!GO_target)
            GO_target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, GO_target.transform.position) < fl_range)
        {
            NPC_Move();
        }
        else
        {
            Patrol();
        }
        
    }
    void Patrol()
    {
        //Are there any waypoints defined?
        if (GOS_waypoints.Length > 0)
        {   // Look at the next WP
            transform.LookAt(GOS_waypoints[in_next_wp].transform.position);

            // Move towards the WP
            cc_NPC.SimpleMove(fl_speed * transform.TransformDirection(Vector3.forward));

            // if we get close move to WP target the next
            if (Vector3.Distance(GOS_waypoints[in_next_wp].transform.position, transform.position) < 1)
            {
                if (in_next_wp < GOS_waypoints.Length - 1)
                    in_next_wp++;
                else
                    in_next_wp = 0;
            }
        }
    }//-----
    void NPC_Move()
    {


        if (Vector3.Distance(transform.position, GO_target.transform.position) < fl_chase_dist_max)
        {   // Face the Target
            transform.LookAt(GO_target.transform.position);

            if (Vector3.Distance(transform.position, GO_target.transform.position) > fl_chase_dist_min)
            {   // Move towards the target
                cc_NPC.SimpleMove(fl_chase_speed * transform.TransformDirection(Vector3.forward));
            }
        }



    }//-----
}
