using UnityEngine;

public class BlockRepeatNimesDeikstra : MonoBehaviour
{
    public GameObject Counter, Point, Line, Square, Field;
    public int NTimes;
    public int CounterNTimes;

    void Start()
    {
        CounterNTimes = 0;
        Counter.GetComponent<TextMesh>().text = NTimes.ToString();
        Field = GameObject.FindGameObjectWithTag("Field");
    }

    void Update()
    {
        Line.transform.position = new Vector3(Point.transform.position.x, (transform.position.y + Point.transform.position.y) / 2, Line.transform.position.z);
        Line.GetComponent<Transform>().localScale = new Vector3(1, (Point.GetComponent<DragAndDrop>().NumberInAlgorithm - GetComponent<DragAndDrop>().NumberInAlgorithm) * 0.525f + 1, 1);
        Square.GetComponent<Transform>().localScale = new Vector3(Square.transform.localScale.x, (Point.GetComponent<DragAndDrop>().NumberInAlgorithm - GetComponent<DragAndDrop>().NumberInAlgorithm) * 0.34f + 0.5f, 1);
        Square.transform.position = new Vector3(transform.position.x, (transform.position.y + Point.transform.position.y) / 2, Line.transform.position.z + 1);
    }

    public bool CheckCycleCondition()
    {
        CounterNTimes++;
        if (CounterNTimes >= NTimes)
        {
            CounterNTimes = 0;
            return false;
        }
        else
        {
            Field.GetComponent<StartAlgorithm>().FieldIndex = GetComponent<DragAndDrop>().NumberInAlgorithm;
            return true;
        }
    }
}
