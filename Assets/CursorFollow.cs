using UnityEngine;

public class CursorFollow : MonoBehaviour
{
    private void Awake()
    {
        Cursor.visible = false;
    }

    
    private void Update()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}
