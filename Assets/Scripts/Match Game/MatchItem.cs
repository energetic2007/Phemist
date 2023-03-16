using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchItem : MonoBehaviour
{
    [SerializeField] 
    private int number;
    [SerializeField]  
    private Image bg;
    public int ItemNumber => number;
    
   
   /*
    private void OnTriggerEnter2D(Collider2D col)
    {
        MatchFound();
        // LevelController.Instance.IsEndGame();
    }
    private protected void MatchFound()
    {
        _bg.color = new Color32(0,255,0,255);
    }
    private protected void MatchNotFound()
    {
       _bg.color = new Color32(255,0,0,255);
    }
    */
    

   
   

    
}
