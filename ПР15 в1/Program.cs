using System;
using System.IO;

namespace StreamReaderWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запит до користувача про введення імен файлів
            Console.Write("Введіть ім'я вхідного файлу: ");
            string inputFilePath = Console.ReadLine();

            Console.Write("Введіть ім'я вихідного файлу: ");
            string outputFilePath = Console.ReadLine();

            Console.Write("Введіть слово для заміни: ");
            string oldWord = Console.ReadLine();

            Console.Write("Введіть слово для заміщення: ");
            string newWord = Console.ReadLine();

            // Створити об'єкти StreamReader та StreamWriter
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                int lineCount = 0;
                int replacementCount = 0;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;

                    // Замінити слово
                    string newLine = line.Replace(oldWord, newWord);

                    // Записати рядок у вихідний файл
                    writer.WriteLine(newLine);

                    // Збільшити лічильник замін
                    replacementCount += (line.Split(oldWord).Length - 1);
                }

                // Вивести статистику
                Console.WriteLine("Оброблено рядків: {0}", lineCount);
                Console.WriteLine("Зроблено замін: {0}", replacementCount);
            }
        }
    }
}
