using Photon.Pun;
using Photon.Pun.Demo.Cockpit;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI RoomName;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public void CreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom("room");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(RoomName.text);
    }

    public void JoinLobby()
    {
        PhotonNetwork.JoinLobby();
    }
    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
        Debug.Log("creat room");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }
    
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log(PhotonNetwork.CurrentLobby.Name);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        Debug.Log("Failed to join room");
    }
        
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        Debug.Log("you left the room");
    }
}
