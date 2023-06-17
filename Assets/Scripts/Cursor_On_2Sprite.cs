using UnityEngine;
using UnityEngine.UI;

public class Cursor_On_2Sprite : MonoBehaviour
{
	public Sprite Sprite1, Sprite2;

    void OnMouseEnter()
	{
		GetComponent<Image>().sprite = Sprite2;
	}

	void OnMouseExit()
	{
		GetComponent<Image>().sprite = Sprite1;
	}
}
