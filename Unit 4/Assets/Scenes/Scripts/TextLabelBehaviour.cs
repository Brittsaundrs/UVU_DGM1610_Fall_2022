using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Text))]
// requires a text label on used object

public class TextLabelBehaviour : MonoBehaviour
{
    public TextMeshProUGUI label;
    public FloatData dataObj;

    private void Start()
    {
        label = GetComponent<TMPro.TextMeshProUGUI>();
        UpdateLabel();
    }
    
    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
