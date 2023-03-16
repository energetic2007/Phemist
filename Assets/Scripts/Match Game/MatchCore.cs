using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCore : MonoBehaviour
{
    [SerializeField] private Transform panel;

    [SerializeField] private List<TargetItem> targetItems;
    
    public void Start()
    {
        for (int i = 0; i < panel.childCount; i++)
        {
            targetItems.Add(panel.GetChild(i).GetComponent<TargetItem>());
        }
    }

    public void Win()
    {
        foreach (TargetItem item in targetItems)
        {
            
        }
    } 
}
    



    
