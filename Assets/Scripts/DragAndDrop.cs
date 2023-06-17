using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public bool InMoving, Moutionless;
    public int NumberInAlgorithm;

    private void OnMouseDown()
    {
        if (!Moutionless)
        {
            if (gameObject.tag == "Block")
                gameObject.tag = "DragBlock";    
            if (gameObject.tag == "Point")
                gameObject.tag = "DragPoint";
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 175);
            InMoving = true;
        }
    }

    private void OnMouseDrag()
    {
        if (!Moutionless)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(pos.x, pos.y, -7);
        }
    }

    private void OnMouseUp()
    {
        if (!Moutionless)
        {
            if (gameObject.tag == "DragBlock")
                gameObject.tag = "Block";
            if (gameObject.tag == "DragPoint")
                gameObject.tag = "Point";
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            InMoving = false;
        }
    }
}
