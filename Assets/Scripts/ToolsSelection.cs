using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsSelection : MonoBehaviour
{
    [SerializeField] private Tool _startTool;

    private void Awake()
    {
        Instantiate(_startTool);
    }
}
