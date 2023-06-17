using UnityEngine;

public class IfLeftMoreRight : MonoBehaviour
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
            int[] oldMassive = Field.GetComponent<BubbleSortInfo>().ChangeMassive;
            int currentIndex = Field.GetComponent<BubbleSortInfo>().CurrentIndex;
            int first = oldMassive[currentIndex + 1];
            int second = oldMassive[currentIndex];
            if (first > second)
            {
                Field.GetComponent<StartAlgorithm>().FieldIndex++;
            }
            Field.GetComponent<BubbleSortInfo>().InfoUpdate();
        }
    }
}
