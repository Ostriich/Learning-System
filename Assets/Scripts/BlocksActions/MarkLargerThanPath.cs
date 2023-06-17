using UnityEngine;

public class MarkLargerThanPath : MonoBehaviour
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
            for (int i = 0; i < 4; i++)
                if (Field.GetComponent<DeikstraInfo>().Distances[Field.GetComponent<DeikstraInfo>().counter, i] != 0)
                    if (Field.GetComponent<DeikstraInfo>().Metki[Field.GetComponent<DeikstraInfo>().counter] + Field.GetComponent<DeikstraInfo>().Distances[Field.GetComponent<DeikstraInfo>().counter, i] < Field.GetComponent<DeikstraInfo>().Metki[i])
                        Field.GetComponent<DeikstraInfo>().Metki[i] = Field.GetComponent<DeikstraInfo>().Metki[Field.GetComponent<DeikstraInfo>().counter] + Field.GetComponent<DeikstraInfo>().Distances[Field.GetComponent<DeikstraInfo>().counter, i];
        }
    }
}
