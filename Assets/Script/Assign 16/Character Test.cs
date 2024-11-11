using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier subhi;
        Officer subhia;
        Character[] character;

        // Start is called before the first frame update
        void Start()
        {
            subhi = new Soldier("Subhi", 100, new Position(1, 5, 3));
            subhia = new Officer("Subhia", 90, new Position(0, 5, 2));
            character = new Character[] { subhi, subhia };
            for (int i = 0; i < character.Length; i++)
            {
                character[i].DisplayInfo();
            }
            Debug.Log(subhi.health);
            subhia.Attack(70, subhi);
            Debug.Log(subhi.health);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}