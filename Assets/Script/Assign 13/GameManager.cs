using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    Player instance1 = new Player();
    Player instance2 = new Player();
    instance1.InitializePlayer("Player 1",100);
    instance2.InitializePlayer("Player 2",100);
    instance1.Heal(10);
    instance2.Heal(20);
    instance1.Heal(false);
    instance2.Heal(true);
    Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
