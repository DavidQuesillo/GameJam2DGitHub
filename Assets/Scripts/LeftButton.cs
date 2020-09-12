using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{
    public bool left = false;


    //Estas dos funciones acompañadas de los handlers arriba permiten que el botón
    //detecte cuando está siendo sostenido en lugar de solo soltado.
    public void OnPointerDown(PointerEventData eventData)
    {
        left = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        left = false;
    }
}
