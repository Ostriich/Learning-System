using UnityEngine;
using UnityEngine.UI;

public class BubbleSort : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/6";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "��������";
                CommonText.GetComponent<Text>().text = "������ ���������� ���������� �� �������� ����, �� ����� ����� ��������� �� ������ �� ��������������. ���� �� �������� ����� � ��������� ����������. ��� ������ ��� ����, ����� ����������� ��������� ����� ���������. ��������, ���������� ������ ����� �� ����������� ��� ��������. \n \n���������� ��������� �� ���������� ������ � ������ � <color=lime>���������� ���������.</color>\n \n���������� �������� ��������, ���������� ��������� (����. bubble sort) � ������� �������� ����������. ��� ��������� � ���������� ���� �������� � ����������, �� ���������� �� ���� ��� ��������� ��������. ��������� ���������: O (n^2). \n \n�������� ��������� ������� � ����������� �� ����������� ��� ������� ����������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate10");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "����� � ��� ���� ������������������ ����, ������� ����� ������������� � ������� �����������:\n \n���������� ������� �������� ������� �� ������������� �������� �� ������������ �������. �� ������ ������ �������� ��������������� ������������ ������� �, ���� ������� � ���� ��������, ����������� ������������ ���������.\n \n���������� ��������, ��� ���������� ��� ���������� ���������:\n \n<color=lime>1 ���.</color> \n \n��������� ������ ��� ����� � ������������ ������ � ���������� �� (������ �������� ������).";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate11");
                break;
            case 3:
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "��� ��� ����� ������������� ������������������ � ������� �����������, ���� ����� ����� ������ ��� ������, ������ �� �������, ���� ������, ������ ��� ��� ����� ��� � ���� � ������� ����������� � ������ ������ �� �����.\n \n����� 9 ������ ��� 7, ������� ������ �������. \n \n� ������, ���� ������������������ ����������� ������������� �� ��������, ����� ����������� ��������. � ������, ������ �����, ���� ����� ������ �������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate12");
                break;
            case 4:
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>2 ���.</color>\n \n���������� ������ �� ���� ������� ������ � �������� ��������� ��� � ������ ����.\n \n<color=lime>3 ���.�</color>\n \n�������� ���������� ��������� ����� n - 1 ���, ��� n � ����� ��������� � ����������� ������������������, ����� ������ ����� ������������� � ��������� ���� �� 1 ���.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate13");
                break;
            case 5:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>4 ���.</color>\n \n����� ���������� ������� ����� ���������� ����� ������������������ ������� �� ��������� �����, ����� ������� ����������������.\n \n<color=lime>5 ���.</color>\n \n���������� �������, ��� �� ���� ������ �� ������������������, ����������� ���� �����, ������ ����� ��������� n ��������, ��� n � ����� ��������� � ����������� ������������������, ����� ������������� ��� ������������������.\n \n(��� ������� ��������� ������ ��������� ������ ������ ��������)";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate14");
                ButtonOfPractice.SetActive(false);
                break;
            case 6:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "����������";
                CommonText.GetComponent<Text>().text = "��� ����� ��������, ��������������� ������������������ �������� ���� �������, ��� �� 7 ��������, �� ������� ����� ����� ������.\n \n����� ����� ��������, ��� �� ����������� ������ ������ �������� �� ����� ������������������, ��� ��� ��� �� ���� ��������� ����������� � ��� ����������� ��������������� �����. ����� ����� ���������, �������� ����� ��������, ������� ������� ����� ��� ������. ������ ����� ����� ����� � �������������� ������.\n \n������������ � ����� � ����� ������ ���������� ������� ��������, ����� ������� � � ���������������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate15");
                ButtonOfPractice.SetActive(true);
                break;
        }
    }

    public void LeftArrowClick()
    {
        NumberPage--;
    }

    public void RightArrowClick()
    {
        NumberPage++;
    }
}
