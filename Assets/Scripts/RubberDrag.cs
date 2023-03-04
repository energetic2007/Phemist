using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RubberDrag : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler

{
    [SerializeField] 
    private Image imageDrag;
    private RectTransform _rectTransformDrag;
    private Vector3 _startPos;
    
    void Start()
    {
        _startPos = transform.position;
        _rectTransformDrag = GetComponent<RectTransform>();
        //imageDrag = GetComponent<Image>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        imageDrag.color = new Color32(255,255,255,170);
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        //_rectTransformDrag.anchoredPosition += eventData.delta;
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        imageDrag.color = new Color32(255,255,255,255);
        transform.position = _startPos;
    }
}
