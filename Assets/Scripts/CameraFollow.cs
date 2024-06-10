using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _player2;

    // Update is called once per frame
    void Update()
    {
        if(_player.GetComponent<PlayerInput>().enabled){
            this.transform.position = _player.transform.position;
        }
        else if(_player2.GetComponent<PlayerInput>().enabled){
            this.transform.position = _player2.transform.position;
        }
    }
}
