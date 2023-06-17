using UnityEngine;

public class BubbleSortInfo : MonoBehaviour
{
    public GameObject[] TextMainMassive = new GameObject[6], TextChangeMassive = new GameObject[6];
    public int[] MainMassive = new int[6], ChangeMassive = new int[6];
    public int CurrentIndex;

    void Start()
    {
        MainMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        ChangeMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        CurrentIndex = 0;
    }

    public void InfoUpdate()
    {
        if (!GetComponent<StartAlgorithm>().Stopped)
            for (int i = 0; i < 6; i++)
            {
                TextMainMassive[i].GetComponent<TextMesh>().text = MainMassive[i].ToString();
                TextChangeMassive[i].GetComponent<TextMesh>().text = ChangeMassive[i].ToString();
            }
        else
            for (int i = 0; i < 6; i++)
            {
                if (TextChangeMassive[i].GetComponent<TextMesh>().text!="")
                    TextMainMassive[i].GetComponent<TextMesh>().text = TextChangeMassive[i].GetComponent<TextMesh>().text;
                TextChangeMassive[i].GetComponent<TextMesh>().text = ChangeMassive[i].ToString();
            }
    }

    public void AlgorithmStart()
    {
        MainMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        ChangeMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        CurrentIndex = 0;
    }

    public void AllClean()
    {
        MainMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        ChangeMassive = new int[6] { 9, 7, 3, 8, 5, 0 };
        CurrentIndex = 0;
        for (int i = 0; i < 6; i++)
        {
            TextMainMassive[i].GetComponent<TextMesh>().text = MainMassive[i].ToString();
            TextChangeMassive[i].GetComponent<TextMesh>().text = "";
        }
    }
}
