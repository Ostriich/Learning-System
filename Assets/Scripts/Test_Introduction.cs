using UnityEngine;
using UnityEngine.UI;

public class Test_Introduction : MonoBehaviour
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
        switch(step)
        {
            case 0:
                Image.GetComponent<Image>().sprite= Resources.Load<Sprite>("Decorate1");
                Text_Question.GetComponent<Text>().text = "Что такое алгоритм?";
                TextButton1.GetComponent<Text>().text = "совокупность действий приводящих к достижению результата за конечное число шагов";
                TextButton2.GetComponent<Text>().text = "код программы, выполняющий определенную задачу с помощью циклов и условных операторов";
                TextButton3.GetComponent<Text>().text = "функция, в которой в зависимости от условия выполняется одна из последовательностей действий";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 1:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                Text_Question.GetComponent<Text>().text = "Что не является свойством алгоритма?";
                TextButton1.GetComponent<Text>().text = "Конечность";
                TextButton2.GetComponent<Text>().text = "Связность";
                TextButton3.GetComponent<Text>().text = "Детерминированность";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 2:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                Text_Question.GetComponent<Text>().text = "В чем заключается свойство массовости?";
                TextButton1.GetComponent<Text>().text = "Один и тот же алгоритм можно использовать с разными исходными данными";
                TextButton2.GetComponent<Text>().text = "Можно использовать сразу несколько алгоритмов для решения одной задачи";
                TextButton3.GetComponent<Text>().text = "Большое количество алгоритмов нагружают программу и делают ее неэффективной";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 3:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                Text_Question.GetComponent<Text>().text = "От чего зависит эффективность алгоритма?";
                TextButton1.GetComponent<Text>().text = "От положительного или отрицательного результата выполнения алгоритма";
                TextButton2.GetComponent<Text>().text = "От количества операций, используемых алгоритмом";
                TextButton3.GetComponent<Text>().text = "От времени и памяти, используемыми алгоритмом";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 4:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                Text_Question.GetComponent<Text>().text = "Какой алгоритм представлен на рисунке?";
                TextButton1.GetComponent<Text>().text = "Линейный";
                TextButton2.GetComponent<Text>().text = "Разветвляющийся";
                TextButton3.GetComponent<Text>().text = "Циклический";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 5:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate7");
                Text_Question.GetComponent<Text>().text = "Какой алгоритм представлен на рисунке?";
                TextButton1.GetComponent<Text>().text = "Линейный";
                TextButton2.GetComponent<Text>().text = "Разветвляющийся";
                TextButton3.GetComponent<Text>().text = "Циклический";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 6:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate9");
                Text_Question.GetComponent<Text>().text = "Какой алгоритм представлен на рисунке?";
                TextButton1.GetComponent<Text>().text = "Линейный";
                TextButton2.GetComponent<Text>().text = "Разветвляющийся";
                TextButton3.GetComponent<Text>().text = "Циклический";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 7:
                Buttons.SetActive(false);
                Text_Question.SetActive(false);
                PanelEnd.SetActive(true);
                TextPanelEnd.GetComponent<Text>().text = "Ваш результат:" + correct.ToString() + "/7";
                if (PlayerPrefs.GetInt("TestNote")<correct)
                {
                    PlayerPrefs.SetInt("Input", PlayerPrefs.GetInt("Input")+correct - PlayerPrefs.GetInt("TestNote"));
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
