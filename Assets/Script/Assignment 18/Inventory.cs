using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory
{
    private List<string> itemNames = new List<string>();
    public void AddItem(string item)
    {
        itemNames.Add(item);
    }
    public void ShowItems()
    {
        foreach (string item in itemNames)
        {
            Debug.Log(item);
        }

    }
    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory combinedInventory = new Inventory();
        foreach (string item in a.itemNames)
        {
            combinedInventory.AddItem(item);
        }
        foreach (string item in b.itemNames)
        {
            combinedInventory.AddItem(item);
        }
        return combinedInventory;
    }
}