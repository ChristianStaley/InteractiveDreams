using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float fl_cooldown = 1F;
    public float fl_accuracy = 100;
    public int in_ammo = 1000;

    // GameObjects 
    public GameObject GO_snowball;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Attack()
    {
        if (Input.GetButton("Fire1") && Time.time > fl_next_attack_time && in_ammo > 0)
        {   // Reset the cooldown delay
            fl_next_attack_time = Time.time + fl_cooldown;
            // Reduce Ammo;
            in_ammo--;
            // Create Projectile slightly to the right and in front of the PC using the camera Rotation
            GameObject _GO_snoowball_clone = Instantiate(GO_snowball, transform.position + transform.TransformDirection(new Vector3(0.25f, 0f, 1.5F)), transform.rotation);
           
        }
    }//-----
}
