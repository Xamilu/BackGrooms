using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
using UnityEngine.SceneManagement;



public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public AudioSource Screamer;


    // Start is called before the first frame update
    private bool Screaming = false;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);

        if(Vector3.Distance(transform.position, Camera.main.transform.position) < 8 && !Screaming){
            Screaming = true;
            enemy.speed *= 2;
            Screamer.Play();
        }

        bool youLoose = Vector3.Distance(transform.position, Camera.main.transform.position) < 2;
        if(youLoose) {
            SceneManager.LoadScene(4);
        }

    }

}

