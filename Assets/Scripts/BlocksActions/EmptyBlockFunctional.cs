using UnityEngine;

public class EmptyBlockFunctional : MonoBehaviour
{
    public GameObject ConnectedBlock, Shine;
    public int NumberInAlgorithm;

    void Update()
    {
        if (ConnectedBlock == null)
        {
            GameObject block = FindAttachBlock();
            if (block)
                Shine.SetActive(true);
            else
            {
                Shine.SetActive(false);
                ConnectNewBlock();
            }
        }
        else if (ConnectedBlock.tag != "DragBlock")
        {
            ConnectedBlock.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -7);
            ConnectedBlock.GetComponent<DragAndDrop>().NumberInAlgorithm = NumberInAlgorithm;
        }
        else
            ConnectedBlock = null;
    }

    private GameObject FindAttachBlock()
    {
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("DragBlock"))
        {
            float y = gameObject.transform.position.y - block.transform.position.y;
            float x = Mathf.Abs(gameObject.transform.position.x - block.transform.position.x);
            if (gameObject != block)
                if (y <= 0.2 && x <= 2 && y > 0)
                    return block;
        }
        return null;
    }

    private void ConnectNewBlock()
    {
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("Block"))
        {
            float y = gameObject.transform.position.y - block.transform.position.y;
            float x = Mathf.Abs(gameObject.transform.position.x - block.transform.position.x);
            if (gameObject != block)
                if (y <= 0.2 && x <= 2 && y > 0)
                    ConnectedBlock = block;
        }
    }
}
