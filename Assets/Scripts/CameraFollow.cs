using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject _player1;
    [SerializeField]
    private GameObject _player2;
    [SerializeField]
    private GameObject _player3;
    [SerializeField]
    private GameObject _player4;
    [SerializeField]
    private GameObject _switchManager;

    private int playerIndex;

    // Update is called once per frame
    void Update()
    {
        playerIndex = _switchManager.GetComponent<SwitchPlayer>()._playerIndex;
        
        switch (playerIndex){
            case 1:
                this.transform.position = _player1.transform.position;
                break;
            case 2:
                this.transform.position = _player2.transform.position;
                break;
            case 3:
                this.transform.position = _player3.transform.position;
                break;
            case 4:
                this.transform.position = _player4.transform.position;
                break;
        }
    }
}
