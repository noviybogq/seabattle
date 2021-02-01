using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        CreateShip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Ship
    {
        public string name;
        public int price;
        public string ability;

    }

    public void CreateShip()
    {
        Ship Batlleship = new Ship();
        Batlleship.name = "Battleship";
        Batlleship.price = 500;
        Batlleship.ability = "attack1";
    }
}
