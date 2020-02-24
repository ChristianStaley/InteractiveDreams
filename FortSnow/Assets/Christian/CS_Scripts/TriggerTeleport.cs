using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleport : MonoBehaviour
{
    public GameObject teleportExit;
    public GameObject target;

    private Transform teleportLocation;
    private CharacterController targetController;

    private void Start()
    {
        if(teleportExit != null)
            teleportLocation = teleportExit.GetComponent<Transform>();

        if(target != null)
        targetController = target.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == target.name)
        {
            targetController.enabled = false;
            target.transform.position = teleportLocation.position;
            targetController.enabled = true;
        }
    }

}
