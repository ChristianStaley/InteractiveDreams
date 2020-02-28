using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sleep : MonoBehaviour
{
    public GameObject panelExit;
    private GameObject go_PC;

    private bool confirm = false;

    private void Start()
    {
        go_PC = GameObject.Find("FPSController");
        panelExit.SetActive(false);
    }

    private void Update()
    {

        if (Vector3.Distance(go_PC.transform.position, gameObject.transform.position) > 3)
        {
            panelExit.SetActive(false);
            confirm = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown("e"))
        {
            panelExit.SetActive(true);
            confirm = true;

        }

        if(other.tag == "Player" && confirm && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("StartScreen");
        }

    }
}
