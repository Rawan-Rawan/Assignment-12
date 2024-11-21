using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> savedItem = new GameContainer<string>();
        savedItem.SetItem("Healing Potion");
        string item = savedItem.GetItem();
        Debug.Log("Stored item: " + item);
        GameUtils.DescribeItem(item);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
