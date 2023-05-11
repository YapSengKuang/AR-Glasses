using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class ShoppingListUI : MonoBehaviour
{
    public TextAsset textAssetData;
    public RowUI rowUi;
    public ShoppingListManager shoppingListManager;

    [System.Serializable]
    public class ShoppingItem
    {
        public string name;
        public string quantity;

    }

    [System.Serializable]
    public class ShoppingList
    {
        public ShoppingItem[] item;
    }

    
    public ShoppingList myShoppingList = new ShoppingList();

    void Start()
    {
        textAssetData = Resources.Load<TextAsset>("data");

        // Split the score data into an array of strings using ',' and '\n' as delimiters.
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

       
        int tablesize = data.Length / 2 - 1;

    
        myShoppingList.item = new ShoppingItem[tablesize];


        for (int i = 0; i < tablesize; i++)
        {
            int arrayIndex = 2 * (i + 1);
            myShoppingList.item[i] = new ShoppingItem();
            myShoppingList.item[i].name = data[arrayIndex];
            myShoppingList.item[i].quantity = data[arrayIndex + 1];

            
  
        }

       
        for (int i = 0; i < tablesize; i++)
        {
            shoppingListManager.addItem(new Item(myShoppingList.item[i].name, myShoppingList.item[i].quantity));

        }


        var shoppingList = shoppingListManager.getShoppingList();
        

        for (int i = 0; i < shoppingList.Count; i++)
        {

            var row = Instantiate(rowUi, transform).GetComponent<RowUI>();
            row.number.text = i.ToString();
            row.name.text = shoppingList[i].name;
            row.quantity.text = shoppingList[i].quantity;
            Debug.Log(i);

        }
    }

}
