using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //Posicion offset de la camara
    public Transform player;
    public Vector3 offset;
    Vector3 dirOffset;

    //0.04 o 0.07f mientras mas alto sea el smootsh speed mas brusco es el deslizamiento de la camera
    public float smoothSpeed = 0.07f;

    //private void LateUpdate() => transform.position = player.position + offset;//+ dirOffset;
    private void Start()
    {
        dirOffset = new Vector3(player.position.x + 10, player.position.y, player.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset ;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(player);
       
        
    }
}
