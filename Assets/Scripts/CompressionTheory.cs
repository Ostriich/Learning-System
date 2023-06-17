using UnityEngine;
using UnityEngine.UI;

public class CompressionTheory : MonoBehaviour
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
                CommonText.GetComponent<Text>().text = "<color=lime>Сжатие данных</color> (англ. data compression) — алгоритмическое (обычно обратимое) преобразование данных, производимое с целью уменьшения занимаемого ими объёма. Применяется для более рационального использования устройств хранения и передачи данных. \n \nОдним из базовых алгоритмов сжатия данных является алгоритм Хаффмана. Идея алгоритма состоит в следующем: зная вероятности появления символов в сообщении, можно описать процедуру построения кодов переменной длины, состоящих из целого количества битов. Символам с большей вероятностью ставятся в соответствие более короткие коды. Коды Хаффмана обладают свойством префиксности (то есть ни одно кодовое слово не является началом другого), что позволяет однозначно их декодировать. \n \nРассмотрим алгоритм пошагово.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate90");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "Для определения кода каждого символа построим бинарное дерево, начиная с листьев.\n \n <color=lime>1 шаг.</color>\n \nСимволы входного алфавита, являющиеся листьями дерева, образуют список свободных узлов. Каждый лист имеет вес, который может быть равен либо вероятности, либо количеству вхождений символа в сжимаемое сообщение, как в нашем случае.\n \n<color=lime>2 шаг.</color>\n \nВыбираются два свободных узла дерева с наименьшими весами, и создается их родитель с весом, равным их суммарному весу. Ветви дерева, идущие от родителя к этим двум листьям, обозначаются 0 и 1 в любом порядке.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate91");
                break;
            case 3:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "<color=lime>3 шаг.</color>\n \nРодитель добавляется в список свободных узлов, а два его потомка удаляются из этого списка. Повторяем прошлые шаги снова.\n \n<color=lime>4 шаг.</color>\n \nШаги 2 и 3 повторяются до тех пор, пока не останется один свободный узел дерева, являющийся корнем. Теперь каждый символ мы можем закодировать последовательностью 0 и 1, начиная от корневого узла и двигаясь к конкретному символу по ветвям бинарного дерева.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate92");
                ButtonOfPractice.SetActive(false);
                break;
            case 4:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Принцип работы";
                CommonText.GetComponent<Text>().text = "В рассмотренном нами примере символ A имеет код 0, так как встречается наиболее часто в сообщении и алгоритм Хаффмана кодирует его минимально возможным сочетанием 0 и 1 для уменьшения объема данных. Символ Е имеет код 111, символ В – 000 и т.д.\n \nТем самым, алгоритм Хаффмана обеспечивает не только сжимание объема информации при кодировании символов подобным образом, но и однозначное декодирование сообщения.\n \nРазобравшись с сутью сжатия данных и алгоритма Хаффмана, можно перейти к проверке знаний.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate93");
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
