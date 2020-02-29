using Photon.Realtime;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public RoomInfo RoomInfo { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        text.text = roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }

    public void OnClick()
    {
        PhotonNetwork.JoinRoom(RoomInfo.Name);
    }
}
