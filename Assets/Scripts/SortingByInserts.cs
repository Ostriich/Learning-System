using UnityEngine;
using UnityEngine.UI;

public class SortingByInserts : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/5";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "��������";
                CommonText.GetComponent<Text>().text = "<color=lime>���������� ���������</color> (����. Insertion sort) � �������� ����������, � ������� �������� ������� ������������������ ��������������� �� ������, � ������ ����� ����������� ������� ����������� � ���������� ����� ����� ����� ������������� ���������.  \n \n��������� ��������� � O {n^2}.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate20");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "����� � ��� ���� ������������������ ����, ������� ����� ������������� � ������� �����������.\n \n���������� ��������� ����������� � ���������� ����� ������������������ �� 2 �����: ��������������� � �����������������. ������ ����� ��� �� ����� ������� �� ����������������� ����� ������������������, �������� ���������� ����� ��� ���� � ��������������� ����� � ��������� ��� ����.\n \n���������� ���������� ��������� ��������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate21");
                break;
            case 3:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>1 ���.</color>\n \n�������� ������ ������� ������������������ � ��� ��������������� ����� �������.\n \n<color=lime>2 ���.</color>\n \n����� ������� �� ����������������� ����� ������������������ � ���������� ��� � ��������� ��������������� �����. ���� ����� ������� ������ ����������������, ������ ��� ����� �� ����, ���� ������ � ������.\n \n������ � ��������������� ����� ������������������ �� ����� ��� ��������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate22");
                break;
            case 4:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>3 ���.</color>\n \n����� ��� ���� ����� �� ����������������� ����� ������������������. ������ ��� ���������� ����� ��� ���� ����� � ��������������� �����. �������� ��� ���, ����� ����� ��� ������� ������ ������, � ������ � ������.\n \n����� ��� ������ ����� ����� �� ���� ���������, ���� ������ ���� ����� �������������� ������ ��� ������ ���� ��������� ��������������� ����� ������������������. \n \n������������� ������� �� ���� �����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate21");
                ButtonOfPractice.SetActive(false);
                break;
            case 5:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>4 ���.</color>\n \n��������� �������� �������� ���� �� ��� ���, ���� ��� ������������������ �� ����� �������������.\n \n������������ � ����� � ��������� ���������� ��������� ���������� ���������, ����� ������� � ��� ���������������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate23");
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
