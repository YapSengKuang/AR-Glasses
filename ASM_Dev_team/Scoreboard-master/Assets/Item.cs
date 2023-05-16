using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
    // The name of the item.
    public int number;
    // The name of the item.
    public string name;
    // The quantity of the item.
    public string quantity;

    /// <summary>
    /// Initializes a new instance of the <see cref="Item"/> class.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <param name="quantity">The quantity of the item.</param>
    public Item(int number, string name, string quantity)
    {
        this.number = number;
        this.name = name;
        this.quantity = quantity;
    }

}

