using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public string st_doorNumber = "door_1";
    public GameObject go_PC;
    private Animator a_door;

    
    // Start is called before the first frame update
    void Start()
    {
        go_PC = GameObject.Find("FPSController");
        a_door = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && Vector3.Distance(go_PC.transform.position, a_door.gameObject.transform.position) <= 4)
            OpenDoor();
    }

    private void OpenDoor()
    {
        a_door.Play(st_doorNumber + "_open");
    }

}
