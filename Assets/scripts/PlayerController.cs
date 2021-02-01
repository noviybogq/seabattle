using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text nameTxt;
    public Text moneyTxt;
    public int money;
    public string name;

    void Start()
    {
        name = "Pasha";
        money = 1500;
        nameTxt.text = name;
        moneyTxt.text = "money: " + money.ToString() + "$";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
