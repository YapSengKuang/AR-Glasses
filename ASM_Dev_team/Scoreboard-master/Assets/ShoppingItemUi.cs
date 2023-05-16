// The 'using' keyword imports the System.Collections, System.Collections.Generic, System.Linq, UnityEngine, and System namespaces.
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

// This line defines a new public class called ScoreUi that inherits from MonoBehaviour.
public class ShoppingItemUi : MonoBehaviour
{
    // These public fields are used to reference a TextAsset object that contains the score data, a ScoreManager object, and a RowUi object.
    public TextAsset textAssetData;
    public ShoppingItemManager shoppingItemManager;   
    public RowUi rowUi;
    
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

    // This method is called when the script instance is being loaded.
    void Start()
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
        
        // Retrieve the high scores from the ScoreManager and display them in the UI.
        var items = shoppingItemManager.GetHighScores().ToArray();
        for (int i = 0; i < items.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.number.text = (i + 1).ToString();
            row.name.text = items[i].name;
            row.quantity.text = items[i].quantity;
        }
    }
}


