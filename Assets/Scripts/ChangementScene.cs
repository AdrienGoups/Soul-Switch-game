using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    private int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void SceneSuivante()
    {

        if (sceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(sceneIndex + 1);
        }
    }

    public void ScenePrecedante()
    {
        if (sceneIndex > 0)
        {
            SceneManager.LoadScene(sceneIndex - 1);
        }
    }


    public void Recommence()
    {
        SceneManager.LoadScene(0);
    }
    
}
