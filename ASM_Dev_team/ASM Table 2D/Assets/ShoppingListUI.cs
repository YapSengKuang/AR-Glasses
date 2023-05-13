using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class ShoppingListUI : MonoBehaviour
{
    // The TextAsset that contains the shopping list data.
    public TextAsset textAssetData;
    // Reference to the RowUI prefab for creating rows in the UI.
    public RowUI rowUi;
    // Reference to the ShoppingListManager for managing the shopping list data.
    public ShoppingListManager shoppingListManager;

    [System.Serializable]
    public class ShoppingItem
    {
        // The name of the shopping item.
        public string name;
        // The quantity of the shopping item.
        public string quantity;

    }

    [System.Serializable]
    public class ShoppingList
    {
        // The array of shopping items in the shopping list.
        public ShoppingItem[] item;
    }

    // The shopping list data.
    public ShoppingList myShoppingList = new ShoppingList();

    void Start()
    {
        // Load the shopping list data from a TextAsset.
        textAssetData = Resources.Load<TextAsset>("data");

        // Split the score data into an array of strings using ',' and '\n' as delimiters.
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        // Calculate the number of shopping items in the data.
        int tablesize = data.Length / 2 - 1;

        // Initialize the shopping list item array.
        myShoppingList.item = new ShoppingItem[tablesize];
        for (int i = 0; i < tablesize; i++)
        {
            int arrayIndex = 2 * (i + 1);
            myShoppingList.item[i] = new ShoppingItem();
            myShoppingList.item[i].name = data[arrayIndex];
            myShoppingList.item[i].quantity = data[arrayIndex + 1];
        }

        // Add each shopping item to the shopping list manager.
        for (int i = 0; i < tablesize; i++)
        {
            shoppingListManager.addItem(new Item(myShoppingList.item[i].name, myShoppingList.item[i].quantity));
        }

        // Retrieve the shopping list from the shopping list manager.
        var shoppingList = shoppingListManager.getShoppingList();
        
        // Create UI rows for each shopping item in the shopping list.
        for (int i = 0; i < shoppingList.Count; i++)
        {
            // Instantiate a RowUI prefab as a child of this object.
            var row = Instantiate(rowUi, transform).GetComponent<RowUI>();
            // Set the number text to the index of the shopping item.
            row.number.text = i.ToString();
            // Set the name text to the name of the shopping item.
            row.name.text = shoppingList[i].name;
            // Set the quantity text to the quantity of the shopping item.
            row.quantity.text = shoppingList[i].quantity;
        }
    }

}
