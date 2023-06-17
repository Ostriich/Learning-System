using UnityEngine;

public class PointOfCycle : MonoBehaviour
{
    public GameObject ParentCycle;

    public bool PointCheck()
    {
        return ParentCycle.GetComponent<RepeatNTimes>().CheckCycleCondition();
    }
}
