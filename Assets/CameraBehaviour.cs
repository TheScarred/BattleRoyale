using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    Vector3 dirOffset;

    private void LateUpdate() => transform.position = player.position + offset + dirOffset;
}
