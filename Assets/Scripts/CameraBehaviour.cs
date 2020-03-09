using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //Posicion offset de la camara
    public Transform player;
    public Transform playerCentrado;
    public Vector3 offset;

    //0.04 o 0.07f mientras mas alto sea el smootsh speed mas brusco es el deslizamiento de la camera
    public float smoothSpeed = 0.04f;

    //se usa para saber si esta en movimiento o no
    [SerializeField]
    PlayerController Character;
    float tiempo = 4.0f;
    //
    IEnumerator ResetCam()
    {
        yield return new WaitForSeconds(1.0f);
        CenterPlayer();

    }
    void CenterPlayer()
    {
        Vector3 desiredPosition2 = playerCentrado.position + offset;
        Vector3 smoothedPosition2 = Vector3.Lerp(transform.position, desiredPosition2, smoothSpeed);
        transform.position = smoothedPosition2;
    }


    private void FixedUpdate()
    {
        if(Character.movimiento!=false)
        {
            tiempo = 2;
            
            movementCamera();
            
        }
        else if(Character.movimiento!=true)
        {
            tiempo -= Time.deltaTime;
            movementCamera();
            if (tiempo <= 0)
            {
                CenterPlayer();
            }
        }
        //transform.LookAt(player);

    }

    public void movementCamera()
    {
       
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
