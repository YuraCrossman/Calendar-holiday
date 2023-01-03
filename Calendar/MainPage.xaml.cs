using System;

namespace Calendar;

public partial class MainPage : ContentPage
{

    string congratlation = "Поздравляю c";
    //string date = "01 01";

    public MainPage()
    {
        InitializeComponent();

        DateTime date = DateTime.Now;
        //date.ToString("dd MM");

        switch (date.ToString("dd MM"))
        {
            case "31 12":
                text.Text = $"О боже скоро Нг🫢\nЯ ушёл готовится";
                break;
            case "01 01":
                text.Text = $"{congratlation} Новым Годом!🎄🥳";
                break;
            case "03 01":
                text.Text = "Это тестовое уведомление";
                break;
            case "01 03":
                text.Text = $"{congratlation} днём Дурака!🤪";
                break;
            case "01 04":
                text.Text = $"{congratlation} днём Труда!";
                break;
            case "08 04":
                text.Text = $"{congratlation} Женским днём!🌺";
                break;
            case "01 06":
                text.Text = $"{congratlation} первым днём Лета!😎";
                break;
            case "02 07":
                text.Text = $"У автора приложения сегодня День рождения!\nПоздравьте его!🎂";
                break;
            case "01 09":
                text.Text = $"{congratlation} днём смерти💀 и первым днём Осени🍁";
                break;
            case "01 12":
                text.Text = $"{congratlation} первым днём Зимы!❄️";
                break;
            default:
                text.Text = "Сегодня нет праздника🫤";
                break;
        }
    }
}

