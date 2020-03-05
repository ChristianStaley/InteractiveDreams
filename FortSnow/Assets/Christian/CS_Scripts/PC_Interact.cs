using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Interact : MonoBehaviour
{
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print("I'm looking at " + hit.transform.name);
                if (hit.transform.gameObject.CompareTag("Pickupable"))
                {
                    print("Message sent");
                    hit.transform.gameObject.GetComponent<PickupObject>().PlayerInteraction(cam.transform);
                }

                if (hit.transform.gameObject.CompareTag("Animated"))
                {
                    print("Message sent");
                    hit.transform.gameObject.GetComponent<ObjectAnimation>().PlayAnimation();
                }

                if (hit.transform.gameObject.CompareTag("NPC"))
                {
                    print("Message sent");
                    hit.transform.gameObject.GetComponent<NPCTalk>().TalkToPlayer();
                }
            }

            else
                print("I'm looking at nothing!");
        }
    }
}
