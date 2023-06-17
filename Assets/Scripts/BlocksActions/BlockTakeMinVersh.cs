using UnityEngine;

public class BlockTakeMinVersh : MonoBehaviour
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
            Field.GetComponent<DeikstraInfo>().counter++;
        }
    }
}
