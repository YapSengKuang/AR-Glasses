using UnityEngine;
using UnityEngine.UI;

public class CheckboxCrossOut : MonoBehaviour
{
    public Text wordText;

    private Toggle checkbox;

    private void Awake()
    {
        checkbox = GetComponent<Toggle>();
        checkbox.onValueChanged.AddListener(OnCheckboxValueChanged);
    }

    private void OnCheckboxValueChanged(bool isChecked)
    {
        if (isChecked)
        {
            wordText.text = "<s>" + wordText.text + "</s>";
        }
        else
        {
            wordText.text = wordText.text.Replace("<s>", "").Replace("</s>", "");
        }
    }
}
