using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
  public string name;
  private int health;
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
  public int Health
  {
    get { return health; }
    set { health = value; }
  }
  public Character(string name, int health)
  {
    this.name = name;
    this.health = health;
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
