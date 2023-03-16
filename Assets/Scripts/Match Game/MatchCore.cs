using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCore : MonoBehaviour
{
    [SerializeField] 
    private Transform panel;
    [SerializeField] 
    private List<TargetItem> targetItems;

    private int _allItems = 0;
    
    public void Start()
    {
        //опасно тк в родителя можно положить иной элемент, надо подумать будет
        for (int i = 0; i < panel.childCount; i++)
        {
            targetItems.Add(panel.GetChild(i).GetComponent<TargetItem>());
            _allItems++;
            Debug.Log(_allItems);
        }
    }

    private void Update()
    {
        CheckAnswer();
    }

    public void CheckAnswer()
    {
        var trueAnswer = 0;
        foreach (TargetItem item in targetItems)
        {
            if (item.isTargetTrue)
            {
                trueAnswer++;
                if (trueAnswer == _allItems)
                {
                    Win();
                }
            }
        }
    }

    private void Win()
    {
        LevelController.Instance.IsEndGame();
    }
}
    



    
