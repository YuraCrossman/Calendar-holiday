using System;
using Plugin.LocalNotification;

namespace Calendar;

public partial class MainPage : ContentPage
{

    string congratlation = "Поздравляю c";
    string holiday;
    //string date = "01 01";

    public MainPage()
    {
        InitializeComponent();

        DateTime date = DateTime.Now;
        //date.ToString("dd MM");

        switch (date.ToString("dd MM"))
        {
            case "31 12":
                holiday = $"О боже скоро Нг🫢\nЯ ушёл готовится";
                text.Text = holiday;
                break;
            case "01 01":
                holiday = $"{congratlation} Новым Годом!🎄🥳";
                text.Text = holiday;
                GetNotif(holiday);
                break;
            case "03 01":
                holiday = "Это тестовое уведомление";
                text.Text = holiday;
                GetNotif(holiday);
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
        LocalNotificationCenter.Current.NotificationActionTapped += Current_NotificationActionTapped;
    }

    public void Current_NotificationActionTapped(Plugin.LocalNotification.EventArgs.NotificationActionEventArgs e)
    {
        if (e.IsTapped)
        {
            LocalNotificationCenter.Current.Cancel(1);
        }
    }

    public void GetNotif(string t)
    {
        var req = new NotificationRequest
        {
            NotificationId = 1,
            Title = "Праздник пришёл!",
            Subtitle = t,
            Description = "Не забудь поздравить своих близких!",
            BadgeNumber = 1,
            CategoryType = NotificationCategoryType.Event,
        };
        LocalNotificationCenter.Current.Show(req);
    }
}

