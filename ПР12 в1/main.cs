using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Приклад введеного рядка
        string input = "user1,email1@example.com,admin,false|user2,email2@example.com,moderator,true|user3,email3@example.com,user,false|user4,email4@example.com,moderator,false|user5,email5@example.com,admin,true";

        // Розбиваємо введений рядок на окремі записи користувачів
        string[] userStrings = input.Split('|');

        // Створюємо список користувачів
        List<User> users = new List<User>();

        // Парсимо дані та додаємо користувачів до списку
        foreach (string userString in userStrings)
        {
            string[] userDetails = userString.Split(',');
            string username = userDetails[0];
            string email = userDetails[1];
            string role = userDetails[2];
            bool blocked = bool.Parse(userDetails[3]);
            users.Add(new User(username, email, role, blocked));
        }

        // Фільтруємо та групуємо користувачів по ролях, виводимо відсортовано
        var groupedUsers = users.Where(user => user.Blocked == false)
                                .GroupBy(user => user.Role)
                                .OrderBy(group => group.Key); // Сортуємо по ключу (ролі)

        // Виводимо результат
        foreach (var group in groupedUsers)
        {
            Console.WriteLine($"Role: {group.Key}");
            foreach (var user in group.OrderBy(u => u.Username)) // Сортуємо користувачів в групі по імені
            {
                Console.WriteLine($"Username: {user.Username}, Email: {user.Email}");
            }
        }
    }
}

// Клас користувача
class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public bool Blocked { get; set; }

    public User(string username, string email, string role, bool blocked)
    {
        Username = username;
        Email = email;
        Role = role;
        Blocked = blocked;
    }
}
