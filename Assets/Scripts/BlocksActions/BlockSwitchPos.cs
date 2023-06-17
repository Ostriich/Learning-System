using UnityEngine;

public class BlockSwitchPos : MonoBehaviour
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
            int[] newMassive = oldMassive;
            int currentIndex = Field.GetComponent<BubbleSortInfo>().CurrentIndex;
            int first = oldMassive[currentIndex + 1];
            int second = oldMassive[currentIndex];
            newMassive[currentIndex] = first;
            newMassive[currentIndex + 1] = second;
            Field.GetComponent<BubbleSortInfo>().ChangeMassive = newMassive;
            Field.GetComponent<BubbleSortInfo>().InfoUpdate();
        }
    }
}
