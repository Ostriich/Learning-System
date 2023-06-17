using UnityEngine;
using UnityEngine.UI;

public class BubbleSort : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/6";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Описание";
                CommonText.GetComponent<Text>().text = "Помимо разделения алгоритмов на основные виды, их также можно разделять на группы по предназначению. Одна из основных групп – алгоритмы сортировки. Они служат для того, чтобы сортировать некоторый набор элементов. Например, сортировка набора чисел по возрастанию или убыванию. \n \nРассмотрим некоторые из алгоритмов группы и начнем с <color=lime>Сортировки Пузырьком.</color>\n \nСортировка простыми обменами, сортировка пузырьком (англ. bubble sort) — простой алгоритм сортировки. Для понимания и реализации этот алгоритм — простейший, но эффективен он лишь для небольших массивов. Сложность алгоритма: O (n^2). \n \nАлгоритм считается учебным и практически не применяется вне учебной литературы.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate10");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "Пусть у нас есть последовательность цифр, которую нужно отсортировать в порядке возрастания:\n \nСортировка медотом пузырька состоит из повторяющихся проходов по сортируемому массиву. За каждый проход элементы последовательно сравниваются попарно и, если порядок в паре неверный, выполняется перестановка элементов.\n \nРассмотрим пошагово, что происходит при выполнении алгоритма:\n \n<color=lime>1 шаг.</color> \n \nЗаключаем первые два числа в воображаемый пузырь и сравниваем их (Отсюда название метода).";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate11");
                break;
            case 3:
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "Так как нужно отсортировать последовательность в порядке возрастания, если число слева больше чем справа, меняем их местами, если меньше, значит эти два числа так и идут в порядке возрастания и ничего менять не нужно.\n \nЧисло 9 больше чем 7, поэтому меняем местами. \n \nВ случае, если последовательность потребуется отсортировать по убыванию, будем действовать наоборот. А именно, менять числа, если левое меньше правого.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate12");
                break;
            case 4:
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>2 шаг.</color>\n \nПередвинем пузырь на один элемент дальше и выполним сравнение как в первом шаге.\n \n<color=lime>3 шаг.в</color>\n \nПодобное необходимо выполнить всего n - 1 раз, где n – число элементов в сортируемой последовательности, чтобы каждое число поучаствовало в сравнении хотя бы 1 раз.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate13");
                break;
            case 5:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nПосле выполнения прошлых шагов наибольшее число последовательности встанет на последнее место, таким образом отсортировавшись.\n \n<color=lime>5 шаг.</color>\n \nСтановится понятно, что за один проход по последовательности, сортируется одно число, значит нужно выполнить n проходов, где n – число элементов в сортируемой последовательности, чтобы отсортировать всю последовательность.\n \n(Для лучшего понимания можете проделать каждый проход подробно)";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate14");
                ButtonOfPractice.SetActive(false);
                break;
            case 6:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Заключение";
                CommonText.GetComponent<Text>().text = "Как можно заметить, отсортированную последовательность получили даже быстрее, чем за 7 проходов, но заранее этого знать нельзя.\n \nТакже можно заметить, что не обязательно каждый проход доходить до конца последовательности, так как там по мере повторных прохождений и так оказываются отсортированные числа. Ввиду этого замечания, алгоритм можно изменить, немного ускорив время его работы. Пример этого можно найти в дополнительных файлах.\n \nРазобравшись с сутью и ходом работы сортировки методом пузырька, можно перейти к её конструированию.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate15");
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
