using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Simple Inventory using a string to int dictionary and some custom methods to add/remove items
// An item is imply just a string for the name of the item, and how many of it one has
public class InventoryComponent : MonoBehaviour {

    private Dictionary<string, int> inventory;

	// Use this for initialization
	void Start () {
        inventory = new Dictionary<string, int>();
    }

    // If given key already exists, it add's p_quantity to it's value. Otherwise it creates the key/value pair
    public void AddItem (string p_key, int p_quantity)
    {
        // Only add an item if the quantity is bigger than 0. Removal should be handeled seperately
        if (p_quantity > 0)
            inventory[p_key] = inventory.ContainsKey(p_key) ? inventory[p_key] + p_quantity : p_quantity;
    }

    // Remove p_quantity from key. Removes key entirely if key/value pair will = 0
    public void RemoveItem(string p_key, int p_quantity)
    {
        // Only add an item if the quantity is bigger than 0. Removing a negative number = positive, and adding
        // should be handeled seperatley
        if (p_quantity > 0 && inventory.ContainsKey(p_key))
        {
            if (inventory[p_key] - p_quantity <= 0)
                inventory.Remove(p_key);
            else
                inventory[p_key] = inventory[p_key] - p_quantity;
        }
    }

    // Returns count value for a given key. If key does not exists currently, returns 0
    public int GetKey(string p_key)
    {
        if (inventory.ContainsKey(p_key))
            return inventory[p_key];
        else
            return 0;
    }
}
