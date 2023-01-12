using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

[SerializeField]
private Transform door;
[SerializeField]
private Vector3 closedRotation;
[SerializeField]
private Vector3 openRotation;
[SerializeField]
private float OpenDistance;
[SerializeField]
private float WinDistance;
private bool isOpen = false;

public void openDoor() {
    // door.DOKill();
    door.DOLocalRotate(openRotation, 1);
}

public void closeDoor() {
    // door.DOKill();
    door.DOLocalRotate(closedRotation, 1);
}

// camera.main.transform.position = position de ma caméra

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isNear = Vector3.Distance(transform.position, Camera.main.transform.position) < OpenDistance;
        bool youWin = Vector3.Distance(transform.position + Vector3.up * 1.8f, Camera.main.transform.position) < WinDistance;
        if(youWin) {
            SceneManager.LoadScene(3);
        }
        if(isOpen) {
            if(!isNear) {
                isOpen = false;
                closeDoor();
            }
        } else {
            if(isNear) {
                isOpen = true;
                openDoor();
            }
        }
    }
}


