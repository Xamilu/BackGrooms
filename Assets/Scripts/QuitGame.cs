using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    ///bouton quitter ///
    public void Quit ()
    {
        Debug.Log("quit");
        Application.Quit();
                
    }
}
