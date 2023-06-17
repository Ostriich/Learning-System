using UnityEngine;
using UnityEngine.UI;

public class ClasteringTheory : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>��������� �������������</color> ������ ��� ��������� ��������� ��������� �� ��������� �����. � ������ �� ����� ���������� �������� ������� �� ������� �� �������. ��������� ������������� ����� ������� �������� ���������� � ���� ����� ������������ � ���������� � ���������� �����. \n \n���� �� �������� ������� ������� ������������� � �������� k-�������.  ������� ��� �������� ����������� � ���, ����� ������� ��� ��������� ��������� �� ������������� ���������� ��������� k, ������������� ��� ���� ������������������ ���������� �� ������ ������� ��������.\n \n���������� �������� �� �������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate80");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>1 ���.</color>\n \n����� ����� ���������, ������������ �������. �������� ������� k ������ 2. � �������� ���������� ��� ������ ��������� (��������) �� ����� ���� � �������.\n \n<color=lime>2 ���.</color>\n \n����� ������� ������ ������� � ���� ��������, �� �������� ������ ���������� �� ������ ��������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate81");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>3 ���.</color>\n \n����� ����� �������� �������� � ����� ����� ��������. ��� ��������� ��� ������� �� ����� ���� ��������� ���������, ����������� � ������� �������� �� ���� ����. \n \n����� ��������� ���������� � �� ������������� ��� �������� ����� ���������� ������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate82");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>4 ���.</color>\n \n���� ������� ���������� ��������� � ��������������� ��������� ���������� �� ��� ���, ���� ��������� ������� ��������� �� ���� � ���� �� ����� ���������� �� ��������.\n \n����� �����, ����� ��������� ��������������, �������� ��������� ������� ���������� �������� � ������� �������� ������ �� ������ ���������� �����������.\n \n������������ � ����� ������������� � ��������� k-�������, ����� ������� � �������� ������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate83");
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
