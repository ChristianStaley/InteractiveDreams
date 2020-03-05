using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    #region Singleton
    static GM mSingleton = null;

    public GM Singleton
    {
        get
        {
            return mSingleton;
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        ResetVariables();
    }

    private void Awake()
    {
        if (mSingleton == null)
        {
            mSingleton = this;
            
        }
        else if (mSingleton != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion


    public GameObject controlsUI;
    private void Start()
    {
        controlsUI.SetActive(true);
        Destroy(controlsUI, 10.0f);
    }

    private void Update()
    {

        //Cursor.lockState = CursorLockMode.None;
        //SceneManager.LoadScene("Menu");

    }
    
    public static void ResetVariables()
    {


    }

}