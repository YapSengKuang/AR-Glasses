using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using TMPro;
using Debug = UnityEngine.Debug;

public class ShoppingListScrollView : MonoBehaviour
{
    private Dictionary<string, GameObject> itemRows = new Dictionary<string, GameObject>();
    public GameObject itemPrefab;
    public Transform contentParent;
    //public Text textComponent;
    private int itemsLeft = 0;
    public Button shoppingListButton;
    public Text shoppingListButtonText;
    public Button backButton;
    public GameObject headerPanel;
    public ScrollRect scrollView;
    private bool scrollViewEnabled = false;
    private bool headerPanelEnabled = false;

    private List<ShoppingItem> shoppingItems = new List<ShoppingItem>();

    private void Start()
    {
        LoadShoppingItemsFromCSV();
        PopulateScrollView();
        shoppingListButton.onClick.AddListener(ToggleScrollView);
        backButton.onClick.AddListener(ToggleBackButton);
    }

    
    private void ToggleScrollView()
    {   
        backButton.gameObject.SetActive(true);
        scrollViewEnabled = true;
        headerPanelEnabled = true;
        scrollView.gameObject.SetActive(scrollViewEnabled);
        headerPanel.gameObject.SetActive(headerPanelEnabled);
        DisplayItemsLeft();
        shoppingListButton.interactable = false;
    }

    private void ToggleBackButton()
    {
        scrollViewEnabled = false;
        headerPanelEnabled = false;
        scrollView.gameObject.SetActive(scrollViewEnabled);
        headerPanel.gameObject.SetActive(headerPanelEnabled);
        backButton.gameObject.SetActive(false);
        DisplayItemsLeft();
        shoppingListButton.interactable = true;
    }

    private void DisplayItemsLeft()
    {   
        
        if(!scrollViewEnabled)
        {
            shoppingListButtonText.text = "My Shopping List";
        }
        else
        {
            shoppingListButtonText.text = "Items left:" + itemsLeft;
        }
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

            toggle.onValueChanged.AddListener(newValue => OnToggleValueChanged(newItem, newValue));
            itemsLeft += 1;
            itemRows[item.name] = newItem;
        }
        DisplayItemsLeft();
    }

    private void OnToggleValueChanged(GameObject itemObject, bool newValue)
    {
        if (newValue)
        {
            itemsLeft -= 1;
            itemObject.transform.GetComponentInChildren<Toggle>().isOn = true;
            itemObject.transform.SetAsLastSibling(); // Move the item to the bottom of the list
        }
        else
        {
            itemsLeft += 1;
            itemObject.transform.GetComponentInChildren<Toggle>().isOn = false;
            itemObject.transform.SetAsFirstSibling();   // Move the item to the top of the list
        }

        DisplayItemsLeft();
    }

    public void itemMatching(string identifiedItemName)
    {
        // Get the row prefab corresponding to the detected item.
        GameObject rowToUpdate = itemRows[identifiedItemName];
        OnToggleValueChanged(rowToUpdate, true);
    }
    
    public bool checkItemList(string identifiedItemName)
    {
        if (itemRows.ContainsKey(identifiedItemName))
        {
            return true;
        }
        return false;
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
