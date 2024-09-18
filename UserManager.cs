using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    /// <summary>
    /// Класс UserManager
    /// </summary>
    public class UserManager
    {
        private List<User> Users { get; set; }
        public UserManager()
        {
            Users = new List<User>();
        }

        //Добавление пользователя
        public void AddUser(User user)
        {
            Users.Add(user);
            Console.WriteLine("Пользователь добавлен.");
        }
        //Удаление пользователя
        public void RemoveUser(User user)
        {
            Users.Remove(user);
            Console.WriteLine("Пользователь удален.");
        }
        //Обновление пользователя
        public void UpdateUser(User user)
        {
            Console.WriteLine("Что желаете обновить? (Имя - 0, Email - 1, Роль - 2)");
            byte choice = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите новое значение поля:");
            if (choice == 0) user.Name = Console.ReadLine();
            else if (choice == 1) user.Email = Console.ReadLine();
            else if (choice == 2) user.Role = Console.ReadLine();
            Console.WriteLine("Пользователь обновлен.");
        }
    }
}
