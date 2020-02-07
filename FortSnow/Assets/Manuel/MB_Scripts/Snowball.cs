using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{

    public GameObject Decal;
    // ----------------------------------------------------------------------
    // Variables
    public float fl_range = 20;
    public float fl_speed = 10;
    public ParticleSystem snowball;
    

    // ----------------------------------------------------------------------
    // Use this for initialization
    void Start()
    {
        snowball.Play();
        Destroy(gameObject, fl_range / fl_speed);
        GetComponent<Rigidbody>().velocity = fl_speed * transform.TransformDirection(Vector3.forward);
    } //-----	

    // ----------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer != 8)
        {
            GameObject newDecal = Instantiate(Decal, transform.position - new Vector3(0,0.14f,0), transform.rotation * Quaternion.Euler(-75, 0, 0));
            Destroy(newDecal, 5.0f);
            Destroy(gameObject);
        }
        
    }
}
