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
    public ShoppingItemLogic temp; 
    public RowUi rowUi;

    // This method is called when the script instance is being loaded.
    void Start()
    {
        // Retrieve the high scores from the ScoreManager and display them in the UI.
        var items = temp.parsedData().ToArray();

        for (int i = 0; i < items.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.number.text = (i + 1).ToString();
            row.name.text = items[i].name;
            row.quantity.text = items[i].quantity;
        }
    }
}


