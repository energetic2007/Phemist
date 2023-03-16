using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneUI : MonoBehaviour
{
    [SerializeField] 
    private Button[] islands;
    [SerializeField] 
    private GameObject diaryWindow;
    
    
    public void OpenWindow()
    {
        diaryWindow.SetActive(true);
    }
    public void CloseWindow()
    {
        diaryWindow.SetActive(false);
    }
}
