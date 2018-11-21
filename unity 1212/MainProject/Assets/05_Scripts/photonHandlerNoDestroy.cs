using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class photonHandlerNoDestroy : MonoBehaviour {

    public InputField createInput, joinInput;

    private void Awake()
    {
        DontDestroyOnLoad(this.transform);
        SceneManager.sceneLoaded += OnSceneFinishedLoading;

    }

    public void onClickCreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 2 }, null);

    }

    public void onClickJoinRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.maxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom(joinInput.text, roomOptions, TypedLobby.Default);

    }

	private void moveGameScene()
    {
        PhotonNetwork.LoadLevel("Character2");
    }

    private void OnJoinedRoom() {
        moveGameScene();
        Debug.Log("We are connected to the room");

    }

    private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Character2")
        {
            
        }
    }

}
