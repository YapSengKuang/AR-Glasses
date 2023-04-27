using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListManager : MonoBehaviour
{
    public List<Item> shoppingList;

    public void addItem(Item item)
    {
        shoppingList.Add(item);
    }


}
