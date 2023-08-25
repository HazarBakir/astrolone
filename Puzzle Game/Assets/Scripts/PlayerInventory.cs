using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // create a list of items in the inventory
    public List<Item> inventory = new List<Item>();
    void Update()
    {
        // when the player presses 1 he gets the first item in his inventory and the player presses 2 he gets the second item in his inventory
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Pressed 1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Pressed 2");
        }
    }
}

public class Item
{
    public string name;
    public string description;
    public Sprite sprite;
    public int value;
    public bool isEquipped;
}