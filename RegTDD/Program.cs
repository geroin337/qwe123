using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegTDD
{
    class Program
    {
        public static string Login, Password;
        static void Main(string[] args)
        {
            RegEnter reg = new RegEnter();
            Console.Clear();
            string login, password;
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
            reg.Enter(login, password);
            if (Login == login && password == Password)
                Console.WriteLine("Успешная авторизация");
            else
                Console.WriteLine("Таких данных нет");
            Console.ReadKey();
        }
    }
}
