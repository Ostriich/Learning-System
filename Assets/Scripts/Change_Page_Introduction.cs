using UnityEngine;
using UnityEngine.UI;

public class Change_Page_Introduction : MonoBehaviour
{
    public GameObject TextNumberPage, RightArrow, LeftArrow, CommonText, Header, Image, ButtonOfPractice;
    public int NumberPage;

    private void Start()
    {
        NumberPage = 1;
    }

    private void Update()
    {
        TextNumberPage.GetComponent<Text>().text = NumberPage.ToString() + "/9";

        switch (NumberPage)
        {
            case 1:
                LeftArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Понятие алгоритма";
                CommonText.GetComponent<Text>().text = "«Программы = алгоритмы + структуры данных»      Никлаус Вирт \n \nЛюбая программа нужна для того, чтобы решать какую - либо задачу.Задача может быть простой или содержать подзадачи, ведущие к решению основной. \n \nНапример, задача калькулятора – найти решение примера.В данном случае к подзадачам мы можем отнести вычисление суммы, разности, произведения, и т.д. \n \nПо сути, процесс решения любой задачи и называется алгоритмом. \n \n < color = lime > Алгоритм </ color > – это совокупность действий, приводящих к достижению результата за конечное число шагов";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate1");
                break;
            case 2:
                LeftArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Свойства алгоритмов";
                CommonText.GetComponent<Text>().text = "<color=lime>Дискретность</color> (от лат. discretus — разделенный, прерывистый) – это разбиение алгоритма на ряд отдельных законченных действий (шагов).\n \n<color=lime>Детерминированность</color> (от лат.determinate — определенность, точность) - любое действие алгоритма должно быть строго и недвусмысленно определено в каждом случае. Например, алгоритм проезда к другу, если к остановке подходят автобусы разных маршрутов, то в алгоритме должен быть указан конкретный номер маршрута 5. Кроме того, необходимо указать точное количество остановок, которое надо проехать, скажем, три.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate2");
                break;
            case 3:
                Header.GetComponent<Text>().text = "Свойства алгоритмов";
                CommonText.GetComponent<Text>().text = "< color = lime > Конечность </ color > – каждое действие в отдельности и алгоритм в целом должны иметь возможность завершения. \n \n < color = lime > Массовость </ color > – один и тот же алгоритм можно использовать с разными исходными данными. \n \n < color = lime > Результативность </ color > – алгоритм должен приводить к достоверному решению.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate3");
                break;
            case 4:
                Header.GetComponent<Text>().text = "Эффективность алгоритма";
                CommonText.GetComponent<Text>().text = "«Измерять продуктивность программиста подсчетом строк кода — это так же, как оценивать постройку самолета по его весу.»      Билл Гейтс \n \nВажно понимать, что алгоритмов решения задачи может быть много, и необходимо выбрать из них самый «удачный».  \n \nВо - первых, нужно, чтобы алгоритм не содержал операций, не имеющих отношения к решению задачи или никак не продвигающих его. \n \nК примеру, если стоит задача подсчета яблок в корзине, считать груши не стоит.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate4");
                break;
            case 5:
                Header.GetComponent<Text>().text = "Эффективность алгоритма";
                CommonText.GetComponent<Text>().text = "Во-вторых, наиболее важно обратить внимание на эффективность  алгоритма.  \n \n<color=lime>Эффективность алгоритма</color> – это его свойство, связанное с вычислительными ресурсами(временем выполнения, памятью), используемыми алгоритмом.  \n \nМожно задать такую обратную зависимость: Чем больше ресурсов использует алгоритм, тем меньше его эффективность.  \n \nДля описания эффективности алгоритмов придумали нотацию Big - O. \n \n<color=lime>(Подробное описание нотации есть в дополнительных файлах)</color>";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate5");
                ButtonOfPractice.SetActive(false);
                break;
            case 6:
                Header.GetComponent<Text>().text = "Назначение алгоритмов";
                CommonText.GetComponent<Text>().text = "Знание большого количества алгоритмов и понимание, когда и как их необходимо использовать позволяет программисту: \n \n- эффективно решать поставленные задачи; \n \n- писать понятный и лаконичный код, тем самым экономить время на написании и отладке кода; \n \n- эффективно и с максимальными возможностями использовать язык, на котором он пишет.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate6");
                ButtonOfPractice.SetActive(true);
                break;
            case 7:
                Header.GetComponent<Text>().text = "Виды алгоритмов";
                CommonText.GetComponent<Text>().text = "По характеру выполнения различают три основных вида алгоритмов: линейный алгоритм, разветвляющийся алгоритм, циклический алгоритм. \n \n<color=lime>Линейный алгоритм</color> – это алгоритм, в котором действия выполняются однократно и строго последовательно. \n \nПростой пример линейного алгоритма – путь из университета домой: \n•    выйти из университета на остановку; \n•	  подождать нужный автобус; \n•	  сесть на нужный автобус; \n•	  оплатить проезд; \n•	  выйти на требуемой остановке; \n•	  дойти до дома.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate7");
                ButtonOfPractice.SetActive(true);
                break;
            case 8:
                RightArrow.SetActive(true);
                Header.GetComponent<Text>().text = "Виды алгоритмов";
                CommonText.GetComponent<Text>().text = "<color=lime>Разветвляющийся алгоритм</color> – это алгоритм, в котором в зависимости от условия выполняется либо одна, либо другая последовательность действий. \n \nПростой пример разветвляющегося алгоритма: если на улице идет дождь, то необходимо взять зонт, иначе не брать зонт с собой.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate8");
                ButtonOfPractice.SetActive(true);
                break;
            case 9:
                RightArrow.SetActive(false);
                Header.GetComponent<Text>().text = "Виды алгоритмов";
                CommonText.GetComponent<Text>().text = "<color=lime>Разветвляющийся алгоритм</color> – это алгоритм, в котором в зависимости от условия выполняется либо одна, либо другая последовательность действий. \n \nПростой пример разветвляющегося алгоритма: если на улице идет дождь, то необходимо взять зонт, иначе не брать зонт с собой.";
                Image.GetComponent<Image>().sprite = Resources.Load<Sprite>("Decorate9");
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
