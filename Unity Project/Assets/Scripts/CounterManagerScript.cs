using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using TMPro;

public class CounterManagerScript : MonoBehaviour
{
    public ShoppingItemLogic logicObject;
    public TextMeshProUGUI totalItemsDisplay;
    public TextMeshProUGUI ItemsLeftDisplay;
    public int itemCounter;
    public RowUi rowUi;
    public ShoppingItemUi rowIter;

    void Update()
    {
        itemCounter = logicObject.getLength();

        totalItemsDisplay.text = "Total items: "+ itemCounter;
        
        /*var row = rowUi.GetComponent<RowUi>();
        
        if(row.tog== true)
        {
            logicObject.reduceLength();
            row.tog = false;
        }
        else if(!row.checkbox.isOn)
        {
            logicObject.increaseLength();
        }*/
           
    }
}
