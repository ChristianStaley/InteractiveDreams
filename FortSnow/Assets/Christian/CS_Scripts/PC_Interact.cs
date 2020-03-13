using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PC_Interact : MonoBehaviour
{
    Camera cam;

    public GameObject HandIcon;
    public GameObject AnimationIcon;
    public GameObject TalkIcon;

    public GameObject snowman;

    private int snowmanCount = 0;

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

                if (hit.transform.gameObject.CompareTag("Terrain") && snowmanCount < 2)
                {
                    Instantiate(snowman, hit.point, Quaternion.identity);
                    snowmanCount++;
                }
            }

            else
                print("I'm looking at nothing!");

        }

        HandIcon.SetActive(false);
        AnimationIcon.SetActive(false);
        TalkIcon.SetActive(false);

        Ray updateRay = cam.ViewportPointToRay(new Vector3(0.4F, 0.4F, 0));
        RaycastHit updateHit;
        if (Physics.Raycast(updateRay, out updateHit))
        {
            if (updateHit.transform.gameObject.CompareTag("Pickupable"))
            {
                HandIcon.SetActive(true);
            }
            if (updateHit.transform.gameObject.CompareTag("Door"))
            {
                HandIcon.SetActive(true);
            }
            if (updateHit.transform.gameObject.CompareTag("Animated"))
            {
                AnimationIcon.SetActive(true);
            }
            if (updateHit.transform.gameObject.CompareTag("NPC"))
            {
                TalkIcon.SetActive(true);
            }
        }


    }
}
