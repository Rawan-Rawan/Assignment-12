using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string Name, int Health) : base(Name, Health) { }
    public void Attack(int decreaseHealth)
    {
        Health -= decreaseHealth;
        if (Health < 0) Health = 0;
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
