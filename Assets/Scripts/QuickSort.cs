using UnityEngine;
using UnityEngine.UI;

public class QuickSort : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>Быстрая сортировка</color> (англ. quicksort), часто называемая qsort — алгоритм сортировки, разработанный английским информатиком Тони Хоаром во время своей работы в МГУ в 1960 году. \n \nОдин из самых быстрых известных универсальных алгоритмов сортировки массивов: в среднем  O(nlog n) обменов при упорядочении n элементов. \n \nИдея алгоритма основывается на распределении элементов массива по двум группам относительно некоторого опорного элемента и рекурсивного повторения этого распределения для этих групп. \n \nПусть массив нужно отсортировать по возрастанию. Рассмотрим выполнение алгоритма пошагово.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate40");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nВыбираем опорный элемент массива, пусть таким будет первый элемент. \n \n<color=lime>2 шаг.</color>\n \nПроходим все элементы массива кроме опорного и ставим элементы меньше опорного слева от него, все элементы больше оставляем справа.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate41");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nПолучили две группы элементов, одна из которых содержит элементы меньше опорного, другая – больше. Теперь выполняем для каждой из них шаги 1, 2 и 3.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate42");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nГруппы, в которых меньше 2х элементов не разбиваются.  Рекурсивное разбиение продолжается до тех пор, пока есть такая возможность. В итоге, получим отсортированный по возрастанию массив. \n \nРазобравшись с сутью и процессом выполнения алгоритма быстрой сортировки, можно перейти к его конструированию.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate43");
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
