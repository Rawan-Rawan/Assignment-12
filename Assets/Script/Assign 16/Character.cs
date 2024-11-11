using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
namespace Assignment18
{

    public class Character
    {
        public string name;
        public int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }

        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public Character()
        {
            name = "NoName";
            health = 100;
            position = new Position(0, 0, 0);
        }
        public virtual void DisplayInfo()
        {
            Debug.Log(name);
            Debug.Log(health);
            position.printPosition();
        }
        public void Attack(int damage, Character target)
        {

            Attack(damage, target, "kicking");

        }
        public void Attack(int damage, Character target, string attackType)
        {
            target.health -= damage;
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