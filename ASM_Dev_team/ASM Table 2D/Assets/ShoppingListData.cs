using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class ShoppingListData
{
    // This public field is a List of Item objects.
    public List<Item> items;

    // This is the constructor for the ShoppingListData class.
    // It initializes the 'items' field as a new empty List of Item objects.
    public ShoppingListData()
    {
        items = new List<Item>();
    }
}
