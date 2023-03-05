using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelector : MonoBehaviour
{
    public Button[] levels;
    
    private void Start()
    {
        int levelComplete = PlayerPrefs.GetInt("levelComplete", 0);

        for (int i = 0; i < levels.Length; i++)
        {
            if (i  > levelComplete) levels[i].interactable = false;
        }
    }

    public void Select(int numberInBuild)
    {
        int currentLevel = numberInBuild - 1;

        int levelComplete = PlayerPrefs.GetInt("levelComplete", 1);
        if (levelComplete < currentLevel) PlayerPrefs.SetInt("levelComplete", currentLevel);
        SceneManager.LoadScene(numberInBuild);
    }

    public void Reset()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            if (i  > 0) levels[i].interactable = false;
        }
        PlayerPrefs.DeleteAll();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}