using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOrJoinRoom : MonoBehaviour
{
    [SerializeField]
    private RoomMenu roomMenu;

    private RoomsCanvases roomsCanvases;

    public void Init(RoomsCanvases canvases)
    {
        roomsCanvases = canvases;
        roomMenu.Init(canvases);
    }
}
