using UnityEngine;
using UnityEngine.UI;

public class TestCompression : MonoBehaviour
{
    public GameObject Text_Question, TextButton1, TextButton2, TextButton3, Image, PanelEnd, TextPanelEnd, Buttons;
    public int step, b1, b2, b3, correct;

    void Start()
    {
        correct = 0;
        b1 = 0;
        b2 = 0;
        b3 = 0;
    }

    void Update()
    {
        switch (step)
        {
            case 0:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate1");
                Text_Question.GetComponent<Text>().text = "������ ������ ���...";
                TextButton1.GetComponent<Text>().text = "��������������� �������������� ������, ������������ � ����� ���������� ����������� ��� ������.";
                TextButton2.GetComponent<Text>().text = "������� ��������� ������ � ��������� ����������.";
                TextButton3.GetComponent<Text>().text = "������� ������ � ���������� ������.";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 1:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                Text_Question.GetComponent<Text>().text = "��� �������� �������� ������������?";
                TextButton1.GetComponent<Text>().text = "������ ����� �������� �������";
                TextButton2.GetComponent<Text>().text = "�� ���� ����� �� �������� ������� �������";
                TextButton3.GetComponent<Text>().text = "�� ���� ����� �� �������� ������ �������";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 2:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                Text_Question.GetComponent<Text>().text = "��� ����������� ���� ������� ������� � ��������� �������� ���������� ��������� ...";
                TextButton1.GetComponent<Text>().text = "�������� ������";
                TextButton2.GetComponent<Text>().text = "��������������� �� ����������� ������������������";
                TextButton3.GetComponent<Text>().text = "��� ��������, ���������� ��� �������";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 3:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                Text_Question.GetComponent<Text>().text = "����� ��� ��������� ���� ���������� ��� �������� �� ��������?";
                TextButton1.GetComponent<Text>().text = "������ �� �������";
                TextButton2.GetComponent<Text>().text = "� ����������� ������";
                TextButton3.GetComponent<Text>().text = "� ����������� ������";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 4:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                Text_Question.GetComponent<Text>().text = "�������� �������� �������� ������ ������ ...";
                TextButton1.GetComponent<Text>().text = "����� ������ �������";
                TextButton2.GetComponent<Text>().text = "������������������� ����� � ������";
                TextButton3.GetComponent<Text>().text = "������ �������";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 5:
                Buttons.SetActive(false);
                Text_Question.SetActive(false);
                PanelEnd.SetActive(true);
                TextPanelEnd.GetComponent<Text>().text = "��� ���������:" + correct.ToString() + "/5";
                if (PlayerPrefs.GetInt("TestNote") < correct)
                {
                    PlayerPrefs.SetInt("Input", PlayerPrefs.GetInt("Input") + correct - PlayerPrefs.GetInt("TestNote"));
                    PlayerPrefs.SetInt("TestNote", correct);
                }
                break;
        }
    }

    public void Button1()
    {
        correct += b1;
        step++;
    }

    public void Button2()
    {
        correct += b2;
        step++;
    }

    public void Button3()
    {
        correct += b3;
        step++;
    }
}
