using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool right = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        right = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        right = false;
    }
}
