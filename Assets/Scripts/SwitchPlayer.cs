using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _player1;
    [SerializeField]
    private GameObject _player2;
    [SerializeField]
    private GameObject _player3;
    [SerializeField]
    private GameObject _player4;

    private int playerCount;

    public int _playerIndex = 1;

    void Start(){
        if(_player4.activeSelf){
            playerCount = 4;
        }
        else if(_player3.activeSelf){
            playerCount = 3;
        }
        else if(_player2.activeSelf){
            playerCount = 2;
        }
        else{
            playerCount = 1;
        }
        Debug.Log(playerCount);
    }
    void OnFire(){
        _playerIndex+=1;

        if(_playerIndex>playerCount){
            _playerIndex = 1;
        }

        Debug.Log(_playerIndex);

        switch (playerCount){
            case 1:  
                _player1.GetComponent<PlayerInput>().enabled = false;
                
                break;
            case 2:
                _player1.GetComponent<PlayerInput>().enabled = false;
                _player2.GetComponent<PlayerInput>().enabled = false;
                
                break;
            case 3:
                _player1.GetComponent<PlayerInput>().enabled = false;
                _player2.GetComponent<PlayerInput>().enabled = false;
                _player3.GetComponent<PlayerInput>().enabled = false;
                
                break;
            case 4:
                _player1.GetComponent<PlayerInput>().enabled = false;
                _player2.GetComponent<PlayerInput>().enabled = false;
                _player3.GetComponent<PlayerInput>().enabled = false;
                _player4.GetComponent<PlayerInput>().enabled = false;
                
                break;
        }
        
        switch (_playerIndex){
            case 1:  
                _player1.GetComponent<PlayerInput>().enabled = true;
                
                break;
            case 2:
                _player2.GetComponent<PlayerInput>().enabled = true;
                
                break;
            case 3:
                _player3.GetComponent<PlayerInput>().enabled = true;
                
                break;
            case 4:
                _player4.GetComponent<PlayerInput>().enabled = true;
                
                break;
        }
    }
}
