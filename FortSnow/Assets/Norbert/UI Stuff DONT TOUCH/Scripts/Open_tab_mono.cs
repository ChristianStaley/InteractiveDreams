using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Open_tab_mono : MonoBehaviour
{
    GameObject Pause_menu_open;
    GameObject Escape_button_open;

    public bool pause_menu = false;
    public bool escape_button_vanish = false;
    public bool escape_button_spawn = false;

    private void Start()
    {
        Pause_menu_open = GameObject.Find("Pause_menu");
        Escape_button_open = GameObject.Find("Escape_button");

        Close_All();
    }

    public void Close_All()
    {
        Pause_menu_open.transform.localScale = new Vector3(0.001F, 0.001F, 0.001F);
        //Escape_button_open.transform.localScale = new Vector3(0.001F, 0.001F, 0.001F);
    }

    public void Open_tab()
    {
        //Close_All();

        if (pause_menu == true)
        {
            Pause_menu_open.transform.localScale = new Vector3(1, 1, 1);
        }

        if (escape_button_vanish == true)
        {
            Escape_button_open.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
        }

        if (escape_button_spawn == true)
        {
            Escape_button_open.transform.localScale = new Vector3(5, 5, 5);
        }
    }
}