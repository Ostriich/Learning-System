using UnityEngine;
using UnityEngine.UI;

public class MergeSort : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>Сортировка слиянием</color>(англ. merge sort) — алгоритм сортировки, который упорядочивает массивы в определённом порядке. \n \nСортируемый массив разбивается на две части примерно одинакового размера. Каждая из получившихся частей сортируется отдельно, например — тем же самым алгоритмом. Два упорядоченных массива половинного размера соединяются в один. \n \nДопустим, у нас есть две отсортированные по возрастанию половины массива, нас интересует, как из них получить целый массив, отсортированный по возрастанию. Рассмотрим алгоритм на примере.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate60");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nИмеем две половины массива, рассмотрим первые элементы каждой из частей. \n \n<color=lime>2 шаг.</color>\n \nПервым в массив поставим меньший элемент из двух рассматриваемых (т.к. сортируем по возрастанию). А также удаляем его из половины массива, из которой мы его взяли, чтобы не добавить его дважды.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate61");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nДалее рассмотрим также первые элементы каждой из частей, и повторим шаг 2.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate62");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nЭту операцию следует повторить n раз, где n – количество элементов суммарно в двух половинах искомого массива.  \n \nВ итоге получим отсортированный по возрастанию массив, сложенный из двух заранее отсортированных половин. Половины можно отсортировать рекурсивно этим же способом.\n \nРазобравшись с сутью и процессом выполнения алгоритма сортировки слиянием, можно перейти к его конструированию.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate63");
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
