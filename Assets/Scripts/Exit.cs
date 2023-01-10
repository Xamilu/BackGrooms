using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
private bool isOpen = false;

public void openDoor() {
    door.DOKill();
    door.DOLocalRotate(openRotation, 1);
}

public void closeDoor() {
    door.DOKill();
    door.DOLocalRotate(closedRotation, 1);
}
// detecter si le joueur est a coté de la porte
// detecter si le joueur touche la sortie

// camera.main.transform.position = position de ma caméra

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isNear = Vector3.Distance(transform.position, Camera.main.transform.position) < OpenDistance;
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
