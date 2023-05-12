using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListManager : MonoBehaviour
{
    // The shopping list data.
    private ShoppingListData sld;
    
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // Retrieve the serialized shopping list data from PlayerPrefs and deserialize it into the sld field.
        var json = PlayerPrefs.GetString("items", "{}");
        sld = JsonUtility.FromJson<ShoppingListData>(json);
    }

    /// <summary>
    /// Adds an item to the shopping list.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void addItem(Item item)
    {
        sld.items.Add(item);
    }

    /// <summary>
    /// OnDestroy is called when the MonoBehaviour will be destroyed.
    /// </summary>
    private void OnDestroy()
    {
        SaveScore();
    }

    /// <summary>
    /// Serializes the shopping list data into a JSON string and saves it to PlayerPrefs.
    /// </summary>
    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sld);
        Debug.Log(json);
        PlayerPrefs.SetString("items", json);
    }

    /// <summary>
    /// Retrieves the shopping list.
    /// </summary>
    /// <returns>The list of items in the shopping list.</returns>
    public List<Item> getShoppingList()
    {
        return sld.items;
    }


}
