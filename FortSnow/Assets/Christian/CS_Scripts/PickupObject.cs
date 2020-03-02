using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    bool interacted = false;
    Transform moveLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (interacted)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveLocation.transform.position, 5f * Time.deltaTime);
        }
    }

    public void PlayerInteraction(Transform playerLocation)
    {
        print("Recieved");
        interacted = true;
        moveLocation = playerLocation;
        gameObject.GetComponent<Collider>().enabled = false;
        Destroy(gameObject, 0.5f);
    }






}
