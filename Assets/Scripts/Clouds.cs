using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    
    [SerializeField] 
    private GameObject cloud1;
    [SerializeField] 
    private GameObject cloud2;
    void Update()
    {
        var levelComplete = PlayerPrefs.GetInt("levelComplete");
        if (levelComplete == 0)
        {
            cloud1.SetActive(true);
            cloud2.SetActive(true);
        }
        if (levelComplete >= 1)
        {
           // cloud1.transform.position = Vector3.MoveTowards(transform.position, Vector3.left,  Time.deltaTime);
           cloud1.SetActive(false);
           cloud2.SetActive(true);
        }

        if (levelComplete >= 2)
        {
            cloud2.SetActive(false);
        }
    }
}
