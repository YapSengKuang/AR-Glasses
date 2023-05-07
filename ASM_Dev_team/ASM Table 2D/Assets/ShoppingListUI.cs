using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListUI : MonoBehaviour
{
    public RowUI rowUi;
    public ShoppingListManager shoppingListManager;

    void start()
    {
        shoppingListManager.addItem(new Item("Bread", "1 loaf"));
        shoppingListManager.addItem(new Item("Bread", "2 loaf"));
        shoppingListManager.addItem(new Item("Bread", "3 loaf"));
        shoppingListManager.addItem(new Item("Bread", "4 loaf"));
        shoppingListManager.addItem(new Item("Bread", "5 loaf"));
        shoppingListManager.addItem(new Item("Bread", "6 loaf"));
        
        var shoppingList = shoppingListManager.shoppingList;
        for (int i = 0; i < shoppingList.Count; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUI>();
            row.number.text = i.ToString();
            row.name.text = shoppingList[i].name;
            row.quantity.text = shoppingList[i].quantity;

        }
    }

}
