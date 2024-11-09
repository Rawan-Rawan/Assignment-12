using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{
    public Player2(string name, int health) : base(name, health) { }
    public void Heal(int increaseHealth)
    {

        Health += increaseHealth;
        if (Health > 100) Health = 100;
        Debug.Log(Health);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
