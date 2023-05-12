using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using ShoppingListManager;

public class CheckboxController : MonoBehaviour
{

    public TMP_InputField total_item, item; 
    private Item item, left_product;

    public void checkError()
    {
        ShoppingListManager.delete(item);
    }
}
