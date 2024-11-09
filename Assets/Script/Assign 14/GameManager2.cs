using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character subhi = new Character("Subhi", 100);
        Character Zarifeh = new Character("Zarifeh", 70);
        Debug.Log(subhi.Name + " " + subhi.Health);
        Debug.Log(Zarifeh.Name + " " + Zarifeh.Health);

        Player2 subhiHeal = new Player2("subhi", 100);
        Player2 ZarifehHeal = new Player2("Zarifeh", 70);
        ZarifehHeal.Heal(10);

        Enemy subhiHealthAfterTheAttach = new Enemy("subhi", 100);
        Enemy ZarifehHealthAfterTheAttack = new Enemy("subhi", 80);
        subhiHealthAfterTheAttach.Attack(40);

    }
    // Update is called once per frame
    void Update()
    {

    }

}
