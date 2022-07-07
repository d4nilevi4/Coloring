using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    [SerializeField] private Color[] _Colors;
    [SerializeField] private List<ColorButton> _Buttons = new List<ColorButton>();

    [SerializeField] private Color _currentColor;

    public Color CurrentColor => _currentColor;

    private void Start()
    {
        _currentColor = _Colors[0];
        for (int i = 0; i < transform.childCount; i++)
        {
            _Buttons.Add(transform.GetChild(i).GetComponent<ColorButton>());
            _Buttons[i].GetComponent<Image>().color = _Colors[i];
        }
    }

    public void SetCurrentColor(int colorID)
    {
        _currentColor = _Colors[colorID];
    }
}
