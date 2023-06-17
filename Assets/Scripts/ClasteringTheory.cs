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
                Header.GetComponent<Text>().text = "Описание";
                CommonText.GetComponent<Text>().text = "<color=lime>Алгоритмы Кластеризации</color> служат для разбиения множества элементов на несколько групп. В каждой из групп содержатся элементы близкие по составу их свойств. Алгоритмы кластеризации имеют широкий диапазон применения и чаще всего используются в маркетинге и социальных сетях. \n \nОдин из наиболее простых методов кластеризации – алгоритм k-средних.  Принцип его действия заключается в том, чтобы разбить все множество элементов на фиксированное количество кластеров k, минимизировав при этом среднеквадратичное отклонение на точках каждого кластера.\n \nРассмотрим алгоритм на примере.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate80");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nИмеем набор элементов, обозначенных точками. Случайно выберем k равное 2. И случайно расположим два центра кластеров (квадраты) на нашем поле с данными.\n \n<color=lime>2 шаг.</color>\n \nДалее отнесем каждый элемент к тому кластеру, до которого меньше расстояние от самого элемента.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate81");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nПосле этого вычислим центроид – новое место кластера. Его вычисляют как среднее из суммы всех координат элементов, относящихся к данному кластеру на этом шаге. \n \nМеста кластеров поменяются и мы переопределим все элементы между кластерами заново.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate82");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nЭтот процесс вычисления центроида и переопределения элементов продолжаем до тех пор, пока положение центров кластеров от шага к шагу не будет оставаться не изменным.\n \nПосле этого, можно вычислить закономерности, присущие элементам каждого отдельного кластера и сделать полезные выводы на основе полученных результатов.\n \nРазобравшись с сутью кластеризации и алгоритма k-средних, можно перейти к проверке знаний.";
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
