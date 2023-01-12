using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private int TargetSceneid;

    public void ButtonSelected()
    {
        SceneManager.LoadScene(TargetSceneid);
    }

}