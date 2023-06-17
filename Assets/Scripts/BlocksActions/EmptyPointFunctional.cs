using UnityEngine;

public class EmptyPointFunctional : MonoBehaviour
{
    public GameObject ConnectedBlock;
    public int NumberInAlgorithm;

    void Update()
    {
        if (ConnectedBlock == null)
        {
            GameObject block = FindAttachBlock();
            if (block)
            {
            }
            else
            {
                ConnectNewBlock();
            }
        }
        else if (ConnectedBlock.tag != "DragPoint")
        {
            ConnectedBlock.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -7);
            ConnectedBlock.GetComponent<DragAndDrop>().NumberInAlgorithm = NumberInAlgorithm;
        }
        else
            ConnectedBlock = null;
    }

    private GameObject FindAttachBlock()
    {
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("DragPoint"))
        {
            float y = gameObject.transform.position.y - block.transform.position.y;
            float x = Mathf.Abs(gameObject.transform.position.x - block.transform.position.x);
            if (gameObject != block)
                if (y <= 0.2 && x <= 0.25 && y > 0)
                    return block;
        }
        return null;
    }

    private void ConnectNewBlock()
    {
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Point"))
        {
            float y = gameObject.transform.position.y - block.transform.position.y;
            float x = Mathf.Abs(gameObject.transform.position.x - block.transform.position.x);
            if (gameObject != block)
                if (y <= 0.2 && x <= 0.25 && y > 0)
                    ConnectedBlock = block;
        }
    }
}
