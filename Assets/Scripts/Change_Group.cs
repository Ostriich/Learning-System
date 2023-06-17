using UnityEngine;

public class Change_Group : MonoBehaviour
{
    public void Change(GameObject Open)
    {
        Open.SetActive(true);
        gameObject.SetActive(false);
    }
}
