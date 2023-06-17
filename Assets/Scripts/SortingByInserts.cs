using UnityEngine;
using UnityEngine.UI;

public class SortingByInserts : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/5";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Описание";
                CommonText.GetComponent<Text>().text = "<color=lime>Сортировка вставками</color> (англ. Insertion sort) — алгоритм сортировки, в котором элементы входной последовательности просматриваются по одному, и каждый новый поступивший элемент размещается в подходящее место среди ранее упорядоченных элементов.  \n \nСложность алгоритма — O {n^2}.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate20");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "Пусть у нас есть последовательность цифр, которую нужно отсортировать в порядке возрастания.\n \nСортировка вставками заключается в разделении нашей последовательности на 2 части: отсортированную и неотсортированную. Каждый новый шаг мы берем элемент из неотсортированной части последовательности, выделяем подходящее место для него в отсортированной части и вставляем его туда.\n \nРассмотрим выполнение алгоритма пошагово.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate21");
                break;
            case 3:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nВыделяем первый элемент последовательности – это отсортированная часть массива.\n \n<color=lime>2 шаг.</color>\n \nБерем элемент из неотсортированной части последовательности и сравниваем его с элементом отсортированной части. Если новый элемент меньше отсортированного, ставим его слева от него, если больше – справа.\n \nТеперь в отсортированной части последовательности мы имеем два элемента.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate22");
                break;
            case 4:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nБерем еще одно число из неотсортированной части последовательности. Теперь нам необходимо найти для него место в отсортированной части. Выбираем его так, чтобы слева был элемент меньше нашего, а справа – больше.\n \nСлева или справа также может не быть элементов, если взятое нами число соответственно меньше или больше всех элементов отсортированной части последовательности. \n \nУстанавливаем элемент на свое место.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate21");
                ButtonOfPractice.SetActive(false);
                break;
            case 5:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nПовторяем действия третьего шага до тех пор, пока вся последовательность не будет отсортирована.\n \nРазобравшись с сутью и процессом выполнения алгоритма сортировки вставками, можно перейти к его конструированию.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate23");
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
