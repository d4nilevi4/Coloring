using UnityEngine;

public class Brush : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private ColorSelection _colorSelection;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _colorSelection = FindObjectOfType<ColorSelection>();
        SetColor(_colorSelection.CurrentColor);
    }
    
    public void SetColor(Color color)
    {
        _lineRenderer.material.color = color;
    }
}
