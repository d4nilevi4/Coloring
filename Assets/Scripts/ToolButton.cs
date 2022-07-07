using UnityEngine;
using UnityEngine.UI;

public class ToolButton : MonoBehaviour
{
    [SerializeField] private Tool _tool;

    public void SelectTool()
    {
        Destroy(FindObjectOfType<Tool>().gameObject);
        Instantiate(_tool);
    }

}
