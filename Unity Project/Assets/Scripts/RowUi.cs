﻿// The 'using' keyword imports the UnityEngine and UnityEngine.UI namespaces
// so that their classes can be used without the fully-qualified namespace.
using UnityEngine;
using UnityEngine.UI;

// This line defines a new public class called RowUi, which inherits from MonoBehaviour.
public class RowUi : MonoBehaviour
{
    // These three public fields are Text objects that will be used to display
    // the rank, name, and score of a row in a UI table.
    public Text number;
    public Text name;
    public Text quantity;
    public Toggle checkbox;
    public bool tog;
    

    public void checkBoxFunction()
    {   

        if(checkbox.isOn)
        {
            tog = true;
        }
        else if(!checkbox.isOn)
        {
            tog= false;
        }
    }
}

