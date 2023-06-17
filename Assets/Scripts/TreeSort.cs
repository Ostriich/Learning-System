using UnityEngine;
using UnityEngine.UI;

public class TreeSort : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>Сортировка с помощью двоичного дерева</color> (англ. tree sort) — универсальный алгоритм сортировки, заключающийся в построении двоичного дерева поиска по ключам массива, с последующей сборкой результирующего массива путём обхода узлов построенного дерева в необходимом порядке следования ключей. \n \nРассмотрим принцип построения двоичного дерева.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate50");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nВыбираем первый элемент массива и обозначаем его корнем дерева. \n \n<color=lime>2 шаг.</color>\n \nВозьмем следующий элемент массива и найдем ему место в дереве. Место корневого элемента уже занято значит, определяем больше взятый элемент корневого или меньше. В зависимости от этого ставим его в левое ответвление (если меньше) или в правое (если больше).";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate51");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nУ каждого узла может быть только два наследника. Отсюда и название двоичного дерева. Продолжаем устанавливать новые элементы в свободные ячейки дерева.\n \nПомним про тот факт, что элементы меньше элемента в узле отправляются в левую ветвь, а элементы больше – в правую.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate52");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nКоличество проходов по дереву определяется количеством элементов в массиве. По итогу, получим двоичное дерево нашего массива. Впоследствии с его помощью можно сформировать отсортированный по убыванию или возрастанию массив. \n \nРазобравшись с сутью и процессом построения двоичного дерева, можно перейти к проверке знаний.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate53");
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
