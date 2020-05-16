using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : Photon.MonoBehaviour
{
    // Start is called before the first frame update
    public string Version;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(Version);
    }

    // Update is called once per frame
    void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Global", new RoomOptions() { maxPlayers = 5 }, null);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player", transform.position, transform.rotation, 0);

    }
}
