using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{ 
    public static LevelController Instance { get; set; }
   
    private int _sceneIndex;
    private int _levelComplete;
    

    private void Awake()
    {
        Instance = this;
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
        _levelComplete = PlayerPrefs.GetInt("levelComplete");
        
        
    }

    public void IsEndGame()
    {
        if (_levelComplete < _sceneIndex)
        {
            PlayerPrefs.SetInt("levelComplete", _sceneIndex);
            //Invoke("LoadMainMenu", 1f);
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}