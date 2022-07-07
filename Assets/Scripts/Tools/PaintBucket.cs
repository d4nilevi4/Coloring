using UnityEngine;

public class PaintBucket : Tool
{
    private ColorSelection _colorSelecton;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        _colorSelecton = FindObjectOfType<ColorSelection>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = _camera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

            if (hit.collider != null)
            {
                SpriteRenderer spriteRenderer = hit.collider.gameObject.GetComponent<SpriteRenderer>();

                spriteRenderer.color = _colorSelecton.CurrentColor;
            }
        }
    }

}
