using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneWin : MonoBehaviour
{
    [SerializeField]
    private ChangementScene _gestionScenes;
    void OnTriggerEnter(){
        _gestionScenes.SceneSuivante();
    }
}
