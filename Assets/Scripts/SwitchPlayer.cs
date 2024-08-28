using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _otherPlayer;
    void OnFire(){
        Debug.Log("Change control");
        this.GetComponent<PlayerInput>().enabled = false;
        _otherPlayer.GetComponent<PlayerInput>().enabled = true;
        // for loop, toInt toString vas dans tableau augmente player index pour changer de joueur
    }
}
