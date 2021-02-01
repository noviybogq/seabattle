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
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)//���� ���������� ��� �������� �� �������
    {
        info.transform.position = new Vector2(Input.mousePosition.x + 85, Input.mousePosition.y - 35);
        info.SetActive(true);
        text.text = "Ship name : battleship";
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)//��������� �������� ����������, ���� �� �������� �� ������� �����
    {
        info.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
