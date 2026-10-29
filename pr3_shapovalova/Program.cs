using HashPasswords;
using pr3_shapovalova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_shapovalova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание новой учетной записи для пользователя\n");

            Console.Write("Введите имя пользователя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию пользователя: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите логин пользователя: ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль пользователя: ");
            string password = Console.ReadLine();

            string hashedPassword = Hash.GetHash(password);
            Console.WriteLine($"Хешированный пароль пользователя: {hashedPassword}");
            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Login = login,
                PasswordHash = hashedPassword,
                RoleID = 1
            };

            try
            {
                Helper.AddUser(newUser);
                Console.WriteLine("Учетная запись добавлена");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
