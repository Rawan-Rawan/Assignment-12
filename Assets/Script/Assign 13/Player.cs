using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public static int playerCount;
    public void InitializePlayer(string name,int initialHealth)
    {
    playerName=name;
    health = initialHealth;
    playerCount++;
    }
    public void Heal(int amount)
    {
    health+=amount;
    if(health>100) health=100;
    Debug.Log(health);
    }
    public void Heal(bool fullRestore)
    {
    if (fullRestore==true) health=100;
    }
    public static void ShowPlayerCount()
    {
    Debug.Log(playerCount);
    }

}
