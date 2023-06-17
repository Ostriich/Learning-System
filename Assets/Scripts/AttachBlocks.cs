using UnityEngine;

public class AttachBlocks : MonoBehaviour
{
    public GameObject Glow, ConnectedBlock, ParentBlock;
    public float OffsetUp, OffsetDown;

    void Update()
    {
        if (ConnectedBlock==null)
        {
            GameObject block = FindAttachBlock();
            if (block)
                Glow.SetActive(true);
            else
                Glow.SetActive(false);
            if (GetComponent<DragAndDrop>().InMoving == false)
                ConnectNewBlock();
        }
        else
        {
            ConnectedBlock.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - OffsetDown + 
            ConnectedBlock.GetComponent<AttachBlocks>().OffsetUp, transform.position.z);
            ConnectedBlock.GetComponent<AttachBlocks>().ParentBlock = gameObject;
        }
    }

    private GameObject FindAttachBlock()
    {
        foreach (GameObject block in GameObject.FindGameObjectsWithTag("DragBlock"))
        {
            float y = gameObject.transform.position.y - block.transform.position.y;
            float x = Mathf.Abs(gameObject.transform.position.x - block.transform.position.x);
            if (gameObject!=block)
                if (y <= OffsetDown && x <=1 && y > 0)
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
                if (y <= OffsetDown && x <= 1 && y > 0)
                    ConnectedBlock = block;
        }
    }
}
