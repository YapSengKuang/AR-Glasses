using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListManager : MonoBehaviour
{
    private ShoppingListData sld;

    public List<Item> shoppingList;

    public void addItem(Item item)
    {
        sld.items.Add(item);
    }






}
