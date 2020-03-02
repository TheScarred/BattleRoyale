using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
    [SerializeField]
    private CreateOrJoinRoom createOrJoinRoom;

    public CreateOrJoinRoom CreateOrJoinRoom { get { return createOrJoinRoom; } }

    [SerializeField]
    private CurrentRoom currentRoom;

    public CurrentRoom CurrentRoom { get { return currentRoom; } }

    private void Awake()
    {
        FirstInit();
    }

    private void FirstInit()
    {
        createOrJoinRoom.Init(this);
        currentRoom.Init(this);
    }
}
