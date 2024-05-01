using System;
using System.Text.RegularExpressions;

class Program
{
    static string ConvertTimeToAMPM(string timeStr)
    {
        // Регулярний вираз для відповідності HH:mm:SS формату часу
        Regex timePattern = new Regex(@"([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])");

        // Знаходимо години, хвилини та секунди в часі
        Match match = timePattern.Match(timeStr);
        if (match.Success)
        {
            int hours = int.Parse(match.Groups[1].Value);
            int minutes = int.Parse(match.Groups[2].Value);
            int seconds = int.Parse(match.Groups[3].Value);

            // Перевіряємо, чи є години більше або рівні 12, для визначення AM або PM
            string period = (hours >= 12) ? "PM" : "AM";
            if (hours > 12)
            {
                hours -= 12;
            }
            else if (hours == 0)
            {
                hours = 12;
            }

            // Формуємо строку AM/PM формату
            string timeStrAMPM = $"{hours:D2}:{minutes:D2}:{seconds:D2} {period}";
            return timeStrAMPM;
        }
        else
        {
            return "Неправильний формат часу!";
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть час у форматі HH:mm:SS: ");
        string timeStr = Console.ReadLine();
        string convertedTime = ConvertTimeToAMPM(timeStr);
        Console.WriteLine("AM/PM формат часу: " + convertedTime);
    }
}
