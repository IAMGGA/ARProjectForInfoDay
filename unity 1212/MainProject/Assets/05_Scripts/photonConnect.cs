using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photonConnect : MonoBehaviour {

    public string versionName = "0.1";

    public GameObject StartMenu, LobbyMenu, DisconnectedMenu;


    public void StartConnect()
    {
        PhotonNetwork.ConnectUsingSettings(versionName);

        Debug.Log("Connecting to photon...");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);

        Debug.Log("We are connected to master");
    }

    private void OnJoinedLobby()
    {
        StartMenu.SetActive(false);
        LobbyMenu.SetActive(true);

        Debug.Log("On Joined Lobby");
    }

    private void OnFailedToConnectToPhoton()
    {
        if (StartMenu.active)
            StartMenu.SetActive(false);

        if (LobbyMenu.active)
            LobbyMenu.SetActive(false);

        DisconnectedMenu.SetActive(true);

        Debug.Log("Disconnect from photon services");

    }


   
}
