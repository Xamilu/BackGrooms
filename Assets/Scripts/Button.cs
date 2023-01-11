using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public string sceneNametoLoad;

    

   
    //  //Start is called before the first frame update
    //  void Start()
    //  {
        
    //  }
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName); //passe sur la scene que l'on veux grace au nom
    }
    
 }