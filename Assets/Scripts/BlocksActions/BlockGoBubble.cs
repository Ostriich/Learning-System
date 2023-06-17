using UnityEngine;

public class BlockGoBubble : MonoBehaviour
{
    public GameObject Field;

    void Start()
    {
        Field = GameObject.FindGameObjectWithTag("Field");
    }

    void Update()
    {
        if (GetComponent<GoAction>().StartAction)
        {
            GetComponent<GoAction>().StartAction = false;
            Field.GetComponent<BubbleSortInfo>().CurrentIndex++;
            Field.GetComponent<BubbleSortInfo>().InfoUpdate();
        }
    }
}
