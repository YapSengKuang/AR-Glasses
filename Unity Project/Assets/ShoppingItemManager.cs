// The 'using' keyword imports the System, System.Collections, System.Collections.Generic, System.Linq, and UnityEngine namespaces.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// This line defines a new public class called ScoreManager that inherits from MonoBehaviour.
public class ShoppingItemManager : MonoBehaviour
{
    // This private field holds an instance of the ScoreData class.
    private ShoppingItemData sid;

    // This method is called when the script instance is being loaded.
    // It retrieves the JSON string representation of the score data from PlayerPrefs and deserializes it into the sd field.
    void Awake()
    {
        // might die
        var json = PlayerPrefs.GetString("shoppingItems", "{}");
        sid = JsonUtility.FromJson<ShoppingItemData>(json);
    }

    // This public method returns a list of Score objects sorted by score in descending order.
    public IEnumerable<ShoppingItem> GetHighScores()
    {
        return sid.shoppingItems.OrderByDescending(x => x.quantity);
    }

    // This public method adds a Score object to the sd field's list of scores.
    public void AddShoppingItem(ShoppingItem shoppingItem)
    {
        sid.shoppingItems.Add(shoppingItem);
    }

    // This method is called when the game object that this script is attached to is destroyed.
    // It calls the SaveScore method to save the score data to PlayerPrefs.
    private void OnDestroy()
    {
        SaveShoppingItem();
    }

    // This public method serializes the sd field into a JSON string and saves it to PlayerPrefs.
    public void SaveShoppingItem()
    {
        var json = JsonUtility.ToJson(sid);
        Debug.Log(json);
        PlayerPrefs.SetString("shoppingitems", json);
    }
}