using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //TODO: Hook up main menu, make more levels, load next level on completion

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentLevel();
        }
    }
    public void LoadLevelSelect()
    {
        Debug.Log("Loading level select");
        SceneManager.LoadScene(0);
    }

    public void HandleFinish()
    {
        Debug.Log("Level Manager handling");
    }

    void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
