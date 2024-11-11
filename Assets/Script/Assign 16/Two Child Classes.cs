using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{

    public class TwoChildClasses : Character
    {
        public class Soldier : Character
        {
            public Soldier(string name, int health, Position position) : base(name, health, position) { }
            public override void DisplayInfo()
            {
                Debug.Log("Soldier");
                base.DisplayInfo();
            }

        }
        public class Officer : Character
        {
            public Officer(string name, int health, Position position) : base(name, health, position) { }
            public override void DisplayInfo()
            {
                Debug.Log("Officer");
                base.DisplayInfo();
            }
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
}
