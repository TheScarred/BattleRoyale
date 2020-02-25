using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonConnection : MonoBehaviourPunCallbacks
{
    public string gameVersion = "0.1";
    public string myServerName = "MoB";

    void Start()
    {
        Debug.Log("Connecting to server...");
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public void Connect()
    {

    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server!");
        Debug.Log("Welcome " + PhotonNetwork.LocalPlayer.NickName + "!");

        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from server. Reason: " + cause.ToString());
    }
}
