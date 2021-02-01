using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ShowTextOnShip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text text;
    public GameObject info;
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)//Вивід інформації при наведенні на предмет
    {
        info.transform.position = new Vector2(Input.mousePosition.x + 85, Input.mousePosition.y - 35);
        info.SetActive(true);
        text.text = "Ship name : battleship";
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)//Перестаємо виводити інформацію, коли не наводимо на предмет мишою
    {
        info.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
