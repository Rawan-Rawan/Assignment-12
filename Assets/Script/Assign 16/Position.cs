using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public struct Position
    {
        public float x;
        public float y;
        public float z;
        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void printPosition()
        {
            Debug.Log(x + "," + y + "," + z);
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