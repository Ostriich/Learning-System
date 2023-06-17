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
                Text_Question.GetComponent<Text>().text = "Сжатие данных это...";
                TextButton1.GetComponent<Text>().text = "алгоритмическое преобразование данных, производимое с целью уменьшения занимаемого ими объема.";
                TextButton2.GetComponent<Text>().text = "процесс изменения данных с удалением избыточных.";
                TextButton3.GetComponent<Text>().text = "перенос данных в упрощенный формат.";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 1:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                Text_Question.GetComponent<Text>().text = "Что означает свойство префиксности?";
                TextButton1.GetComponent<Text>().text = "Каждое слово содержит префикс";
                TextButton2.GetComponent<Text>().text = "Ни одно слово не является началом другого";
                TextButton3.GetComponent<Text>().text = "Ни одно слово не является концом другого";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 2:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                Text_Question.GetComponent<Text>().text = "Для определения кода каждого символа в алгоритме Хаффмана необходимо построить ...";
                TextButton1.GetComponent<Text>().text = "бинарное дерево";
                TextButton2.GetComponent<Text>().text = "отсортированную по возрастанию последовательность";
                TextButton3.GetComponent<Text>().text = "два кластера, содержащие все символы";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 3:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                Text_Question.GetComponent<Text>().text = "Какие два свободных узла выбираются для создания их родителя?";
                TextButton1.GetComponent<Text>().text = "Первые по порядку";
                TextButton2.GetComponent<Text>().text = "С наибольшими весами";
                TextButton3.GetComponent<Text>().text = "С наименьшими весами";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 4:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                Text_Question.GetComponent<Text>().text = "Алгоритм Хаффмана кодирует каждый символ ...";
                TextButton1.GetComponent<Text>().text = "Через другие символы";
                TextButton2.GetComponent<Text>().text = "Последовательностью нулей и единиц";
                TextButton3.GetComponent<Text>().text = "целыми числами";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 5:
                Buttons.SetActive(false);
                Text_Question.SetActive(false);
                PanelEnd.SetActive(true);
                TextPanelEnd.GetComponent<Text>().text = "Ваш результат:" + correct.ToString() + "/5";
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
