using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int currentSceneIndex;
    void Start() 
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentLevel();
        }
    }

    public void HandleFinish()
    {
        Debug.Log("Level Manager handling");
        int numScenes = SceneManager.sceneCountInBuildSettings;
        if(currentSceneIndex +1 <= numScenes)
        {
            SceneManager.LoadScene(currentSceneIndex + 1); // load next level
        } 
        else
        {
            LoadLevel(0);
        }
    }

    void ReloadCurrentLevel()
    {
        LoadLevel(currentSceneIndex);
    }

    public void LoadLevel(int i)
    {
        SceneManager.LoadScene(i);
    }
}
