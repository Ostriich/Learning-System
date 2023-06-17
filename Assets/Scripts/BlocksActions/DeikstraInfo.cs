using UnityEngine;

public class DeikstraInfo : MonoBehaviour
{
    public int[,] Distances = new int[4, 4] { { 0, 6, 9, 0 }, { 6, 0, 2, 7 }, { 9, 2, 0, 3 }, { 0, 7, 3, 0 } };
    public GameObject[] TextMetki = new GameObject[4];
    public int[] Metki = new int[4] { 0, 100, 100 ,100 };
    public int counter = -1;

    public void AllClean()
    {
        for (int i=0; i < 3; i++)
        {
            Metki[i + 1] = 100;
        }
        counter = -1;
    }

    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (Metki[i] == 100)
                TextMetki[i].GetComponent<TextMesh>().text = "ꝏ";
            else
                TextMetki[i].GetComponent<TextMesh>().text = Metki[i].ToString();
        }
    }
}
