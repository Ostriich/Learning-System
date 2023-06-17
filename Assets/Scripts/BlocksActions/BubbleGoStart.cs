using UnityEngine;

public class BubbleGoStart : MonoBehaviour
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
            Field.GetComponent<BubbleSortInfo>().CurrentIndex = 0;
            Field.GetComponent<BubbleSortInfo>().InfoUpdate();
        }
    }
}
