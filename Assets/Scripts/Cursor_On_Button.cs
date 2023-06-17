using UnityEngine;
using UnityEngine.UI;

public class Cursor_On_Button : MonoBehaviour
{
	public GameObject Text, Inside;

	void OnMouseEnter()
	{
		Inside.SetActive(true);
		Text.GetComponent<Text>().color = new Color32(40, 40, 60, 255);
	}

	void OnMouseExit()
	{
		Inside.SetActive(false);
		Text.GetComponent<Text>().color = new Color32(255, 255, 255, 255);
	}
}
