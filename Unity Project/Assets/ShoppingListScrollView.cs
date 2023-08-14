using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using TMPro;

public class ShoppingListScrollView : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform contentParent;

    private List<ShoppingItem> shoppingItems = new List<ShoppingItem>();

    private void Start()
    {
        LoadShoppingItemsFromCSV();
        PopulateScrollView();
    }

    private void LoadShoppingItemsFromCSV()
    {
        TextAsset csvFile = Resources.Load<TextAsset>("MyShoppingList");

        if (csvFile != null)
        {
            string[] lines = csvFile.text.Split('\n');

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields.Length >= 3)
                {
                    int itemNumber;
                    string itemName = fields[1]; // Item name is at index 1
                    string itemQuantity = fields[2]; // Quantity is at index 2

                    if (int.TryParse(fields[0], out itemNumber))
                    {
                        shoppingItems.Add(new ShoppingItem(itemNumber, itemName, itemQuantity));
                    }
                    else
                    {
                        Debug.LogWarning($"Invalid number value in CSV: {line}");
                    }
                }
            }
        }
        else
        {
            Debug.LogError("CSV file not found in Resources folder.");
        }
    }

    private void PopulateScrollView()
    {
        foreach (ShoppingItem item in shoppingItems)
        {
            GameObject newItem = Instantiate(itemPrefab, contentParent);
            Text nameText = newItem.transform.Find("Item").GetComponent<Text>();
            Text quantityText = newItem.transform.Find("Quantity").GetComponent<Text>();
            Toggle toggle = newItem.transform.Find("Toggle").GetComponent<Toggle>();

            nameText.text = item.name;
            quantityText.text = item.quantity;

            toggle.onValueChanged.AddListener(newValue => OnToggleValueChanged(item, newItem, newValue));
        }
    }

    private void OnToggleValueChanged(ShoppingItem item, GameObject itemObject, bool newValue)
    {
        Text nameText = itemObject.transform.Find("Item").GetComponent<Text>();
        Text quantityText = itemObject.transform.Find("Quantity").GetComponent<Text>();

        if (newValue)
        {
            //item.name = "Checked: " + item.name;
            //item.quantity = "0";
        }
        else
        {
            //item.name = item.name.Replace("Checked: ", "");
            //item.quantity = "1"; 
        }

        // Update the UI text
        nameText.text = item.name;
        quantityText.text = item.quantity;

        // Move the item to the bottom of the list
        itemObject.transform.SetAsLastSibling();
    }
}

[System.Serializable]
public class ShoppingItem
{   
    public int number;
    public string name;
    public string quantity;

    public ShoppingItem(int _number ,string _name, string _quantity)
    {
        name = _name;
        quantity = _quantity;
        number = _number;
    }
}
