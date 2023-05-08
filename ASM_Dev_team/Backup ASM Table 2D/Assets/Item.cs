using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
    public string name;
    public string quantity;

    public Item(string name, string quantity)
    {
        this.name = name;
        this.quantity = quantity;
    }

}
