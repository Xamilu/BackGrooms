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
    private bool Loose = false;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
       if (Loose)
        {
            return;
        }
        bool youLoose = Vector3.Distance(transform.position, Camera.main.transform.position) < 3;
        enemy.SetDestination(player.position);
        if(youLoose) {
            Loose = true;
            Invoke(nameof(GameOver),2);
            Screamer.Play();
        }

    }
    void GameOver()
    {
        SceneManager.LoadScene(4);
    }
}

