using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCTalk : MonoBehaviour
{
    public GameObject textDialogue;
    public GameObject go_PC;
    void Start()
    {
        textDialogue.SetActive(false);
        go_PC = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        if(textDialogue!=null)
        {
            if (textDialogue)
            {
                if (Vector3.Distance(go_PC.transform.position, gameObject.transform.position) > 5)
                {
                    textDialogue.SetActive(false);
                }
            }
        }
    }

    public void TalkToPlayer()
    {
        textDialogue.SetActive(true);
    }
}
