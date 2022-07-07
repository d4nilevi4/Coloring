using UnityEngine;

public class Draw : Tool
{
    [SerializeField] private GameObject _brush;

    private Camera _mainCamera;
    private LineRenderer _currentLineRenderer;
    private Vector2 _lastPostition;
    private float zPoz = 0;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        Drawing();
    }

    private void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos != _lastPostition)
            {
                AddPoint(new Vector3(mousePos.x, mousePos.y, zPoz));
                _lastPostition = mousePos;
            }
        }
        else
        {
            _currentLineRenderer = null;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            zPoz -= 0.01f;
        }
    }

    private void CreateBrush()
    {
        GameObject brush = Instantiate(_brush);
        _currentLineRenderer = brush.GetComponent<LineRenderer>();

        Vector2 mousePos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);

        _currentLineRenderer.SetPosition(0, new Vector3(mousePos.x, mousePos.y, zPoz));
        _currentLineRenderer.SetPosition(1, new Vector3(mousePos.x, mousePos.y, zPoz));
    }

    private void AddPoint(Vector3 pointPos)
    {
        _currentLineRenderer.positionCount++;
        int positionIndex = _currentLineRenderer.positionCount - 1;
        _currentLineRenderer.SetPosition(positionIndex, pointPos);
    }
}
