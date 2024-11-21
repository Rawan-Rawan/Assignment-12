using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory potionInventory = new Inventory();
        Inventory elixirInventory = new Inventory();
        potionInventory.AddItem("Healing Potion");
        potionInventory.AddItem("Strength Potion");
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");
        Inventory combinedInventory = potionInventory + elixirInventory;
        combinedInventory.ShowItems();



    }
}