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
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool youLoose = Vector3.Distance(transform.position, Camera.main.transform.position) < 2;
        enemy.SetDestination(player.position);
        if(youLoose) {
            SceneManager.LoadScene(3);
        }
    }
}

