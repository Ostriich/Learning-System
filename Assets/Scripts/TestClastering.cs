using UnityEngine;
using UnityEngine.UI;

public class TestClastering : MonoBehaviour
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
                Text_Question.GetComponent<Text>().text = "Где используются алгоритмы кластеризации?";
                TextButton1.GetComponent<Text>().text = "В маркетинге и социальных сетях";
                TextButton2.GetComponent<Text>().text = "В прогнозировании курсов валют";
                TextButton3.GetComponent<Text>().text = "Для решения дифференциальных уравнений";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 1:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                Text_Question.GetComponent<Text>().text = "Как называется один из самых простых методов кластеризации?";
                TextButton1.GetComponent<Text>().text = "k-малых";
                TextButton2.GetComponent<Text>().text = "k-средних";
                TextButton3.GetComponent<Text>().text = "k-больших";
                b1 = 0;
                b2 = 1;
                b3 = 0;
                break;
            case 2:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                Text_Question.GetComponent<Text>().text = "К какому кластеру следует отнести элемент в алгоритме k-средних";
                TextButton1.GetComponent<Text>().text = "К ближайшему";
                TextButton2.GetComponent<Text>().text = "К любому";
                TextButton3.GetComponent<Text>().text = "К тому, у которого больше элементов";
                b1 = 1;
                b2 = 0;
                b3 = 0;
                break;
            case 3:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                Text_Question.GetComponent<Text>().text = "Как вычисляется центроид?";
                TextButton1.GetComponent<Text>().text = "Сумма всех элементов кластера";
                TextButton2.GetComponent<Text>().text = "Корень из квадрата суммы координат двух самых дальних элементов кластера";
                TextButton3.GetComponent<Text>().text = "Среднее из суммы всех координат элементов, относящихся к кластеру";
                b1 = 0;
                b2 = 0;
                b3 = 1;
                break;
            case 4:
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                Text_Question.GetComponent<Text>().text = "До каких пор выполняется процесс перевычисления центроида?";
                TextButton1.GetComponent<Text>().text = "Выполняется столько раз, сколько рассматриваемых в задаче элементов";
                TextButton2.GetComponent<Text>().text = "Пока положение центров кластеров не будет оставаться неизменным";
                TextButton3.GetComponent<Text>().text = "Выполняется k раз";
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
