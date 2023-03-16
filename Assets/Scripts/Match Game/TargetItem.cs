using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetItem : MonoBehaviour
{
    [SerializeField] 
    private int number;
    [SerializeField]
    private Image bg;
    public bool isTargetTrue = false;
    
   //public int TargetNumber => number;
   
    private void OnTriggerEnter2D(Collider2D col)
    {
        var matchItem = col.gameObject.GetComponent<MatchItem>();
        if (matchItem == null)
            return;
        
        if (number == matchItem.ItemNumber)
        {
            bg.color = new Color32(0,255,0,255);
            isTargetTrue = true;
        }
        else
        {
            StartCoroutine(FalseTargetColor());
        }
    }
    
    private IEnumerator FalseTargetColor()
    {
        bg.color = new Color32(255,0,0,255);
        yield return new WaitForSeconds(1f);
        bg.color = new Color32(255,255,255,255);
        StopCoroutine(FalseTargetColor());
    }
}
