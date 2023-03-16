using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
     
        LevelController.Instance.IsEndGame();
    }
}
