using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDT_Script : MonoBehaviour
{
    #region Some extra code
    public GameObject pressPlayWindow;

    public Transform button1;
    public Transform button2;
    private void Start()
    {
        //DEACTIVATE THE WINDOW ON START

        pressPlayWindow.SetActive(false);

        /*TO SEE MORE INFO ABOUT THIS CHECK THESE VIDEOS
        
        ACTIVATE AND DEACTIVATE GAMEOBJECTS IN UNITY:
        https://www.youtube.com/watch?v=ddSHCwnksW0

        HOW TO KNOW IF A GAMEOBJECT IS ACTIVE IN HIERARCHY:
        https://www.youtube.com/watch?v=jsl-0Z5dT_w

        */
    }

    void Update()
    {
        button1.localScale = Vector3.one * (1 + 0.025f * Mathf.Sin(Time.timeSinceLevelLoad));
        button2.localScale = Vector3.one * (1 + 0.025f * Mathf.Sin(Time.timeSinceLevelLoad));

    }

    public void MysteriousFunction(string s)
    {
        #region don't
        //Subscribe :)
        Application.OpenURL(s);
        #endregion
    }

    #endregion
}
