using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class ShoppingItemLogic : MonoBehaviour
{
    public TextAsset textAssetData;
    public ShoppingItemManager shoppingItemManager;
    public int itemsLength;

    // These [Serializable] classes are used to deserialize the score data from the TextAsset object.
    [System.Serializable]
    public class Item
    {
        public int number;
        public string name;
        public string quantity;
    }
    [System.Serializable]
    public class ShoppingList
    {
        public Item[] item; 
    }

    // This public field holds an instance of the CountryList class, which is used to store the score data.
    public ShoppingList myShoppingList = new ShoppingList();

    public IEnumerable<ShoppingItem> parsedData()
    {
            // Load the score data from the TextAsset object.
        textAssetData = Resources.Load<TextAsset>("MyShoppingList");

        // Split the score data into an array of strings using ',' and '\n' as delimiters.
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        // Calculate the size of the score data table.
        int tablesize = data.Length / 3 - 1;

        // Initialize the Country array in the CountryList with the calculated table size.
        myShoppingList.item = new Item[tablesize];

        // Populate the Country array in the CountryList with the score data.
        for (int i = 0; i < tablesize; i++)
        {
            int arrayIndex = 3 * (i + 1);
            myShoppingList.item[i] = new Item();
            myShoppingList.item[i].number = int.Parse(data[arrayIndex]);
            myShoppingList.item[i].name = data[arrayIndex + 1];
            myShoppingList.item[i].quantity = data[arrayIndex + 2];
        }

        // Add the score data to the ScoreManager.
        for (int i = 0; i < tablesize; i++)
        {
            shoppingItemManager.AddShoppingItem(new ShoppingItem(myShoppingList.item[i].name, myShoppingList.item[i].quantity));
        }
        
        this.itemsLength = tablesize;
        // Retrieve the high scores from the ScoreManager and display them in the UI.
        return (shoppingItemManager.GetHighScores());

    }

    public int getLength()
    {
        return this.itemsLength;
    }
    public void reduceLength()
    {
        this.itemsLength= this.itemsLength-1;
    }
    public void increaseLength()
    {
        this.itemsLength= this.itemsLength+1;
    }
}
