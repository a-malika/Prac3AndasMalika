using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Тестирование системы
            User user0 = new User("Анастасия", "nastyona@mail.com", "User");
            User user1 = new User("Владимир", "DedInSide@gmail.com", "Stranger");
            User user2 = new User("Есен", "Seangel@gmail.com", "Admin");

            UserManager userManager = new UserManager();
            //Проверка методов
            userManager.AddUser(user0);
            userManager.AddUser(user1);
            userManager.AddUser(user2);
            userManager.UpdateUser(user0);
            userManager.RemoveUser(user1);
        }
    }
}