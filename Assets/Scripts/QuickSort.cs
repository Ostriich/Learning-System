using UnityEngine;
using UnityEngine.UI;

public class QuickSort : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/4";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "��������";
                CommonText.GetComponent<Text>().text = "<color=lime>������� ����������</color> (����. quicksort), ����� ���������� qsort � �������� ����������, ������������� ���������� ������������ ���� ������ �� ����� ����� ������ � ��� � 1960 ����. \n \n���� �� ����� ������� ��������� ������������� ���������� ���������� ��������: � �������  O(nlog n) ������� ��� ������������ n ���������. \n \n���� ��������� ������������ �� ������������� ��������� ������� �� ���� ������� ������������ ���������� �������� �������� � ������������ ���������� ����� ������������� ��� ���� �����. \n \n����� ������ ����� ������������� �� �����������. ���������� ���������� ��������� ��������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate40");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>1 ���.</color>\n \n�������� ������� ������� �������, ����� ����� ����� ������ �������. \n \n<color=lime>2 ���.</color>\n \n�������� ��� �������� ������� ����� �������� � ������ �������� ������ �������� ����� �� ����, ��� �������� ������ ��������� ������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate41");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>3 ���.</color>\n \n�������� ��� ������ ���������, ���� �� ������� �������� �������� ������ ��������, ������ � ������. ������ ��������� ��� ������ �� ��� ���� 1, 2 � 3.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate42");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>4 ���.</color>\n \n������, � ������� ������ 2� ��������� �� �����������.  ����������� ��������� ������������ �� ��� ���, ���� ���� ����� �����������. � �����, ������� ��������������� �� ����������� ������. \n \n������������ � ����� � ��������� ���������� ��������� ������� ����������, ����� ������� � ��� ���������������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate43");
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
