using System;

namespace Calendar;

public partial class MainPage : ContentPage
{

    string congratlation = "Поздравляю c";
    //string date = "31 12";

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
                text.Text = $"{congratlation} Новым Годом!🥳";
                break;
            case "01 03":
                text.Text = $"{congratlation} днём Дурака!";
                break;
            case "08 04":
                text.Text = $"{congratlation} женским днём!🌺";
                break;
            case "01 06":
                text.Text = $"{congratlation} с первым днём лета!";
                break;
            case "02 07":
                text.Text = $"У автора приложения сегодня День рождения!\nПоздравьте его!";
                break;
            default:
                text.Text = "Сегодня нет праздника";
                break;
        }
    }
}

