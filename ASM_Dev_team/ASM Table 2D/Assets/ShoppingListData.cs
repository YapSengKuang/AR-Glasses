using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListData
{
    // This public field is a List of Score objects.
    public List<Item> items;

    // This is the constructor for the ScoreData class.
    // It initializes the 'scores' field as a new empty List of Score objects.
    public ShoppingListData()
    {
        items = new List<Item>();
    }
}
