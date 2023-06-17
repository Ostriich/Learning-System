using UnityEngine;
using UnityEngine.UI;

public class Change_Page_Introduction : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/9";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "������� ���������";
                CommonText.GetComponent<Text>().text = "���������� = ��������� + ��������� �������      ������� ���� \n \n����� ��������� ����� ��� ����, ����� ������ ����� - ���� ������.������ ����� ���� ������� ��� ��������� ���������, ������� � ������� ��������. \n \n��������, ������ ������������ � ����� ������� �������.� ������ ������ � ���������� �� ����� ������� ���������� �����, ��������, ������������, � �.�. \n \n�� ����, ������� ������� ����� ������ � ���������� ����������. \n \n < color = lime > �������� </ color > � ��� ������������ ��������, ���������� � ���������� ���������� �� �������� ����� �����";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate1");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "�������� ����������";
                CommonText.GetComponent<Text>().text = "<color=lime>������������</color> (�� ���. discretus � �����������, �����������) � ��� ��������� ��������� �� ��� ��������� ����������� �������� (�����).\n \n<color=lime>�������������������</color> (�� ���.determinate � ��������������, ��������) - ����� �������� ��������� ������ ���� ������ � �������������� ���������� � ������ ������. ��������, �������� ������� � �����, ���� � ��������� �������� �������� ������ ���������, �� � ��������� ������ ���� ������ ���������� ����� �������� 5. ����� ����, ���������� ������� ������ ���������� ���������, ������� ���� ��������, ������, ���.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate2");
                break;
            case 3:
                Header.GetComponent<Text>().text = "�������� ����������";
                CommonText.GetComponent<Text>().text = "< color = lime > ���������� </ color > � ������ �������� � ����������� � �������� � ����� ������ ����� ����������� ����������. \n \n < color = lime > ���������� </ color > � ���� � ��� �� �������� ����� ������������ � ������� ��������� �������. \n \n < color = lime > ���������������� </ color > � �������� ������ ��������� � ������������ �������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                break;
            case 4:
                Header.GetComponent<Text>().text = "������������� ���������";
                CommonText.GetComponent<Text>().text = "��������� �������������� ������������ ��������� ����� ���� � ��� ��� ��, ��� ��������� ��������� �������� �� ��� ����.�      ���� ����� \n \n����� ��������, ��� ���������� ������� ������ ����� ���� �����, � ���������� ������� �� ��� ����� ��������.  \n \n�� - ������, �����, ����� �������� �� �������� ��������, �� ������� ��������� � ������� ������ ��� ����� �� ������������ ���. \n \n� �������, ���� ����� ������ �������� ����� � �������, ������� ����� �� �����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                break;
            case 5:
                Header.GetComponent<Text>().text = "������������� ���������";
                CommonText.GetComponent<Text>().text = "��-������, �������� ����� �������� �������� �� �������������  ���������.  \n \n<color=lime>������������� ���������</color> � ��� ��� ��������, ��������� � ��������������� ���������(�������� ����������, �������), ������������� ����������.  \n \n����� ������ ����� �������� �����������: ��� ������ �������� ���������� ��������, ��� ������ ��� �������������.  \n \n��� �������� ������������� ���������� ��������� ������� Big - O. \n \n<color=lime>(��������� �������� ������� ���� � �������������� ������)</color>";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                ButtonOfPractice.SetActive(false);
                break;
            case 6:
                Header.GetComponent<Text>().text = "���������� ����������";
                CommonText.GetComponent<Text>().text = "������ �������� ���������� ���������� � ���������, ����� � ��� �� ���������� ������������ ��������� ������������: \n \n- ���������� ������ ������������ ������; \n \n- ������ �������� � ���������� ���, ��� ����� ��������� ����� �� ��������� � ������� ����; \n \n- ���������� � � ������������� ������������� ������������ ����, �� ������� �� �����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate6");
                ButtonOfPractice.SetActive(true);
                break;
            case 7:
                Header.GetComponent<Text>().text = "���� ����������";
                CommonText.GetComponent<Text>().text = "�� ��������� ���������� ��������� ��� �������� ���� ����������: �������� ��������, ��������������� ��������, ����������� ��������. \n \n<color=lime>�������� ��������</color> � ��� ��������, � ������� �������� ����������� ���������� � ������ ���������������. \n \n������� ������ ��������� ��������� � ���� �� ������������ �����: \n�    ����� �� ������������ �� ���������; \n�	  ��������� ������ �������; \n�	  ����� �� ������ �������; \n�	  �������� ������; \n�	  ����� �� ��������� ���������; \n�	  ����� �� ����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate7");
                ButtonOfPractice.SetActive(true);
                break;
            case 8:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "���� ����������";
                CommonText.GetComponent<Text>().text = "<color=lime>��������������� ��������</color> � ��� ��������, � ������� � ����������� �� ������� ����������� ���� ����, ���� ������ ������������������ ��������. \n \n������� ������ ���������������� ���������: ���� �� ����� ���� �����, �� ���������� ����� ����, ����� �� ����� ���� � �����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                ButtonOfPractice.SetActive(true);
                break;
            case 9:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "���� ����������";
                CommonText.GetComponent<Text>().text = "<color=lime>��������������� ��������</color> � ��� ��������, � ������� � ����������� �� ������� ����������� ���� ����, ���� ������ ������������������ ��������. \n \n������� ������ ���������������� ���������: ���� �� ����� ���� �����, �� ���������� ����� ����, ����� �� ����� ���� � �����.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate9");
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
