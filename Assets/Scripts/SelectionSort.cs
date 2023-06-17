using UnityEngine;
using UnityEngine.UI;

public class SelectionSort : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>Сортировка выбором</color> (англ. selection sort) — простой алгоритм сортировки со сложностью O(n^{2}), где n — количество элементов для сортировки.  \n \nПусть у нас есть последовательность цифр, которую нужно отсортировать в порядке возрастания. \n \nИдея сортировки выбором заключается в том, что в неотсортированной части последовательности ищется локальный максимум и меняется местами с последним элементом этой части, после чего этот элемент становится отсортированным, а алгоритм повторяется вновь для неотсортированной части последовательности. \n \nРассмотрим выполнение алгоритма пошагово.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate30");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>1 шаг.</color>\n \nЧтобы отсортировать первый элемент по возрастанию, считаем первый элемент последовательности за максимум и проходим по всем элементам по порядку, заменяя максимум новым элементом, если тот больше прошлого значения максимума. \n \n<color=lime>2 шаг.</color>\n \nПолученный после прохода по последовательности максимальный элемент меняем местами с последним элементом последовательности. \n \nМы получили первый отсортированный по возрастанию элемент последовательности.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate31");
                break;
            case 3:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nДалее рассмотрим часть последовательности, которая осталась не отсортированной. Повторим для нее выполнение первого шага. Получим второй отсортированный элемент, который будет стоять точно перед предыдущим отсортированным элементом. \n \nПодобные действия будем повторять до тех пор, пока все элементы последовательности не окажутся отсортированными.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate32");
                break;
            case 4:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>4 шаг.</color>\n \nСортируя последовательность по одному элементу, необходимо выполнить n-1 проходов по неотсортированной части последовательности, где n – количество элементов во всей последовательности. \n \nОчевидно, что за последний проход будут отсортированы сразу два элемента, так как часть последовательности, состоящая из одного элемента, в любом случае отсортирована.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate33");
                ButtonOfPractice.SetActive(false);
                break;
            case 5:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "Можно уменьшить количество проходов, если искать не только максимальный, но и минимальный элемент и сортировать сразу два элемента последовательности. Этот случай является усовершенствованием сортировки выбором, а его реализация представлена в дополнительных материалах. \n \nРазобравшись с сутью и процессом выполнения алгоритма сортировки выбором, можно перейти к его конструированию.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate33");
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
