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
                Header.GetComponent<Text>().text = "Описание";
                CommonText.GetComponent<Text>().text = "<color=lime>Алгоритм Дейкстры</color>(англ. Dijkstra’s algorithm) — алгоритм на графах, изобретённый нидерландским учёным Эдсгером Дейкстрой в 1959 году. Находит кратчайшие пути от одной из вершин графа до всех остальных. Алгоритм работает только для графов без рёбер отрицательного веса и широко применяется в программировании. \n \nРассмотрим алгоритм на примере.\n \nПусть есть граф, состоящий из 4х пронумерованных вершин. У каждой есть своя метка – кратчайший путь от начальной вершины до вершины с этой меткой (оранжевое значение). Также указаны дороги – ребра между вершинами графа и длина пути по каждому из них (зеленое значение). Нужно найти минимальное расстояние от первой вершины до всех остальных.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate70");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nМинимальную метку имеет вершина 1, так как путь из первой вершины в нее же нулевой. Метки всех остальных вершин равны бесконечности, так как мы еще не знаем ни одного пути в них из первой вершины. Соседями первой вершины являются вершины 2 и 3.\n \nДлина пути в вершину 2 складывается из метки вершины 1 и длины ребра, идущего из 1 в 2. Длина равна 0+6=6, что меньше текущей метки вершины 2, бесконечности. Поэтому, новая метка этой вершины 7.\n \nАналогично значение метки вершины 3 становится 9.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate71");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>2 шаг.</color>\n \nВыбираем следующую вершину с наименьшей меткой – вторую. Ее соседями являются третья и четвертая вершины. Первую вершину мы уже не рассматриваем.\n \nПуть из второй вершины в третью равен 6+2=8, что меньше 9, обновляем значение метки вершины 3. Тоже самое делаем и для вершины 4, так как 6+7=13 меньше бесконечности.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate72");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nЗакрываем вторую вершину, и остается рассмотреть третью вершину, как вершину с минимальной меткой из оставшихся. Получаем, что путь из 3-ей вершины в 4-ю равен 8+3=11, что меньше нынешнего значения метки вершины 4. \n \nИтого значениями меток получаем кратчайшие пути из вершины 1 во все остальные вершины графа.\n \nРазобравшись с сутью и процессом выполнения алгоритма Дейкстры, можно перейти к его конструированию.";
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
