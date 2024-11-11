using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        TwoChildClasses.Soldier subhi;
        TwoChildClasses.Officer subhia;
        Character[] character;

        // Start is called before the first frame update
        void Start()
        {
            subhi = new TwoChildClasses.Soldier("Subhi", 100, new Position(1, 5, 3));
            subhia = new TwoChildClasses.Officer("Subhia", 90, new Position(0, 5, 2));
            character = new Character[] { subhi, subhia };
            for (int i = 0; i < character.Length; i++)
            {
                character[i].DisplayInfo();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}