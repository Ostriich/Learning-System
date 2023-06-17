using UnityEngine;
using UnityEngine.UI;

public class TestTreeSort : MonoBehaviour
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
                Text_Question.GetComponent<Text>().text = "В чем заключается алгоритм сортировки деревом?";
                TextButton1.GetComponent<Text>().text = "В построении двоичного дерева поиска по ключам массива";
                TextButton2.GetComponent<Text>().text = "В сортировке массива по частям";
                TextButton3.GetComponent<Text>().text = "В выборе максимального элемента в неотсортированной части массива";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 1:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                Text_Question.GetComponent<Text>().text = "Как называется главный элемент с которого начинается дерево?";
                TextButton1.GetComponent<Text>().text = "Ключевой";
                TextButton2.GetComponent<Text>().text = "Корневой";
                TextButton3.GetComponent<Text>().text = "Первый";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 2:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                Text_Question.GetComponent<Text>().text = "В какое ответвление распределяется потомок, меньший своего родителя?";
                TextButton1.GetComponent<Text>().text = "В левое";
                TextButton2.GetComponent<Text>().text = "В правое";
                TextButton3.GetComponent<Text>().text = "В любое";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 3:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                Text_Question.GetComponent<Text>().text = "Сколько наследников может быть у каждого узла?";
                TextButton1.GetComponent<Text>().text = "Любое конечное число";
                TextButton2.GetComponent<Text>().text = "Только один";
                TextButton3.GetComponent<Text>().text = "Два";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 4:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                Text_Question.GetComponent<Text>().text = "Сколько проходов по дереву происходит за время выполнения алгоритма?";
                TextButton1.GetComponent<Text>().text = "Количество элементов массива -1";
                TextButton2.GetComponent<Text>().text = "Столько, сколько элементов в массиве";
                TextButton3.GetComponent<Text>().text = "Десять";
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
