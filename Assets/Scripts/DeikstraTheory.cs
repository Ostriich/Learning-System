using UnityEngine;
using UnityEngine.UI;

public class DeikstraTheory : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>�������� ��������</color>(����. Dijkstra�s algorithm) � �������� �� ������, ����������� ������������� ������ �������� ��������� � 1959 ����. ������� ���������� ���� �� ����� �� ������ ����� �� ���� ���������. �������� �������� ������ ��� ������ ��� ���� �������������� ���� � ������ ����������� � ����������������. \n \n���������� �������� �� �������.\n \n����� ���� ����, ��������� �� 4� ��������������� ������. � ������ ���� ���� ����� � ���������� ���� �� ��������� ������� �� ������� � ���� ������ (��������� ��������). ����� ������� ������ � ����� ����� ��������� ����� � ����� ���� �� ������� �� ��� (������� ��������). ����� ����� ����������� ���������� �� ������ ������� �� ���� ���������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate70");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>1 ���.</color>\n \n����������� ����� ����� ������� 1, ��� ��� ���� �� ������ ������� � ��� �� �������. ����� ���� ��������� ������ ����� �������������, ��� ��� �� ��� �� ����� �� ������ ���� � ��� �� ������ �������. �������� ������ ������� �������� ������� 2 � 3.\n \n����� ���� � ������� 2 ������������ �� ����� ������� 1 � ����� �����, ������� �� 1 � 2. ����� ����� 0+6=6, ��� ������ ������� ����� ������� 2, �������������. �������, ����� ����� ���� ������� 7.\n \n���������� �������� ����� ������� 3 ���������� 9.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate71");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>2 ���.</color>\n \n�������� ��������� ������� � ���������� ������ � ������. �� �������� �������� ������ � ��������� �������. ������ ������� �� ��� �� �������������.\n \n���� �� ������ ������� � ������ ����� 6+2=8, ��� ������ 9, ��������� �������� ����� ������� 3. ���� ����� ������ � ��� ������� 4, ��� ��� 6+7=13 ������ �������������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate72");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "������� ������";
                CommonText.GetComponent<Text>().text = "<color=lime>3 ���.</color>\n \n��������� ������ �������, � �������� ����������� ������ �������, ��� ������� � ����������� ������ �� ����������. ��������, ��� ���� �� 3-�� ������� � 4-� ����� 8+3=11, ��� ������ ��������� �������� ����� ������� 4. \n \n����� ���������� ����� �������� ���������� ���� �� ������� 1 �� ��� ��������� ������� �����.\n \n������������ � ����� � ��������� ���������� ��������� ��������, ����� ������� � ��� ���������������.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate73");
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
