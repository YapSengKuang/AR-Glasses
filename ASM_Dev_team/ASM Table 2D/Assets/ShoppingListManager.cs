using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListManager : MonoBehaviour
{
    private ShoppingListData sld;


    void Awake()
    {
        var json = PlayerPrefs.GetString("items", "{}");
        sld = JsonUtility.FromJson<ShoppingListData>(json);
    }

    public void addItem(Item item)
    {
        sld.items.Add(item);
    }


    private void OnDestroy()
    {
        SaveScore();
    }

    // This public method serializes the sd field into a JSON string and saves it to PlayerPrefs.
    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sld);
        Debug.Log(json);
        PlayerPrefs.SetString("items", json);
    }

    public List<Item> getShoppingList()
    {
        return sld.items;
    }


}
