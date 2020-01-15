using System;
using Newtonsoft.Json;

namespace CalculatorAndAccountManagementTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            Admin admin = new Admin();

            if (userData.CheckAdminExist(admin) == false)
            {
                userData.AddAdmin(admin);
            }

            User user = new User();

            while (true)
            {
                Console.WriteLine("Вы новый пользователь? 1-да,2-нет,3-я админ,4-выйти из программы");
                string userChoice = Console.ReadLine();

                if (userChoice == "3")
                {
                    Console.WriteLine("Введите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    string password = Console.ReadLine();
                    user = new User
                    {
                        Name = name,
                        Password = password
                    };

                    if (user.Name == admin.Name && user.Password == admin.Password)
                    {

                        while (true)
                        {
                            Console.WriteLine("Выберите действие: 1-получить данные о пользователе,2-удалить пользователя,3-выйти из аккаунта");
                            string adminChoice = Console.ReadLine();

                            if (adminChoice == "1")
                            {
                                Console.WriteLine("Введите имя пользователя");
                                User foundUser = userData.GetUser(Console.ReadLine());
                                Console.WriteLine(JsonConvert.SerializeObject(foundUser));
                            }
                            else if (adminChoice == "2")
                            {
                                Console.WriteLine("Введите имя пользователя");
                                User foundUser = userData.GetUser(Console.ReadLine());
                                userData.DeleteUser(foundUser);
                            }
                            else if (adminChoice == "3")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Не существует такой команды");
                            }

                        }

                    }

                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Введите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    string password = Console.ReadLine();
                    user = new User
                    {
                        Name = name,
                        Password = password
                    };
                    bool isAccountDataCorrect = userData.CheckUserAccount(user);

                    if (isAccountDataCorrect == true && user.Name != admin.Name && user.Password != admin.Password)
                    {
                        UserAct(user, userData);
                    }

                }
                else if (userChoice == "1")
                {
                    Console.WriteLine("Регистрация");
                    bool isUserNameCorrect = false;

                    while (isUserNameCorrect == false)
                    {
                        Console.WriteLine("Введите имя");
                        user.Name = Console.ReadLine();
                        isUserNameCorrect = userData.CheckUserName(user.Name);
                    }

                    bool isUserPasswordCorrect = false;

                    while (isUserPasswordCorrect == false)
                    {
                        Console.WriteLine("Введите пароль");
                        user.Password = Console.ReadLine();
                        isUserPasswordCorrect = userData.CheckUserPassword(user.Password);
                    }

                    userData.AddUser(user);
                    UserAct(user, userData);
                }
                else if (userChoice == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Не существует такой команды");
                }

            }

        }

        static void UserAct(User user, UserData userData)
        {

            while (true)
            {
                Console.WriteLine("Выберите действие 1-удалить аккаунт,2-редактировать аккаунт,3-выйти из аккаунта,4-работа с калькулятором");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    userData.DeleteUser(user);
                    break;
                }

                else if (userChoice == "2")
                {
                    Console.WriteLine("Введите новое имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите новый пароль");
                    string password = Console.ReadLine();
                    User newUser = new User
                    {
                        Name = name,
                        Password = password
                    };
                    userData.EditUser(user, newUser);
                }

                else if (userChoice == "3")
                {
                    break;
                }

                else if (userChoice == "4")
                {
                    Console.WriteLine("Введите тип первого аргумента:1-string(строка),2-object,3-boolean,4-long(целое число),5-double(вещественное число),6-decimal(финансовое число),7-char(символ)");
                    string firstArgType = Console.ReadLine();
                    Console.WriteLine("Введите первый аргумент");
                    string firstArg = Console.ReadLine();
                    Console.WriteLine("Введите тип второго аргумента:1-string(строка),2-object,3-boolean,4-long(целое число),5-double(вещественное число),6-decimal(финансовое число),7-char(символ)");
                    string secondArgType = Console.ReadLine();
                    Console.WriteLine("Введите второй аргумент");
                    string secondArg = Console.ReadLine();

                    if (firstArgType == "1" && secondArgType == "1")
                    {
                        var calculator = new Calculator<string, string>();
                        string operation = InputOperation();

                        switch (operation)
                        {
                            case "1":
                                Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondArg)}");
                                break;
                            case "2":
                                Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondArg)}");
                                break;
                            case "3":
                                Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondArg)}");
                                break;
                            case "4":
                                Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondArg)}");
                                break;
                            default:
                                Console.WriteLine("Не существует такой операции");
                                break;
                        }

                    }
                    else if (firstArgType == "1" && secondArgType == "2")
                    {
                        var calculator = new Calculator<string, object>();
                        string operation = InputOperation();

                        switch (operation)
                        {
                            case "1":
                                Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondArg)}");
                                break;
                            case "2":
                                Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondArg)}");
                                break;
                            case "3":
                                Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondArg)}");
                                break;
                            case "4":
                                Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondArg)}");
                                break;
                            default:
                                Console.WriteLine("Не существует такой операции");
                                break;
                        }

                    }
                    else if (firstArgType == "1" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "1" && secondArgType == "4")
                    {
                        var calculator = new Calculator<string, long>();
                        string operation = InputOperation();

                        if (long.TryParse(secondArg, out long secondLongArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "1" && secondArgType == "5")
                    {
                        var calculator = new Calculator<string, double>();
                        string operation = InputOperation();

                        if (double.TryParse(secondArg, out double secondDoubleArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "1" && secondArgType == "6")
                    {
                        var calculator = new Calculator<string, decimal>();
                        string operation = InputOperation();

                        if (decimal.TryParse(secondArg, out decimal secondDecimalArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "1" && secondArgType == "7")
                    {
                        var calculator = new Calculator<string, char>();
                        string operation = InputOperation();

                        if (char.TryParse(secondArg, out char secondCharArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "1")
                    {
                        var calculator = new Calculator<object, string>();
                        string operation = InputOperation();

                        switch (operation)
                        {
                            case "1":
                                Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondArg)}");
                                break;
                            case "2":
                                Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondArg)}");
                                break;
                            case "3":
                                Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondArg)}");
                                break;
                            case "4":
                                Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondArg)}");
                                break;
                            default:
                                Console.WriteLine("Не существует такой операции");
                                break;
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "2")
                    {
                        var calculator = new Calculator<object, object>();
                        string operation = InputOperation();

                        switch (operation)
                        {
                            case "1":
                                Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondArg)}");
                                break;
                            case "2":
                                Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondArg)}");
                                break;
                            case "3":
                                Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondArg)}");
                                break;
                            case "4":
                                Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondArg)}");
                                break;
                            default:
                                Console.WriteLine("Не существует такой операции");
                                break;
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "2" && secondArgType == "4")
                    {
                        var calculator = new Calculator<object, long>();
                        string operation = InputOperation();

                        if (long.TryParse(secondArg, out long secondLongArg))
                        {
                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "5")
                    {
                        var calculator = new Calculator<object, double>();
                        string operation = InputOperation();

                        if (double.TryParse(secondArg, out double secondDoubleArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "6")
                    {
                        var calculator = new Calculator<object, decimal>();
                        string operation = InputOperation();

                        if (decimal.TryParse(secondArg, out decimal secondDecimalArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "2" && secondArgType == "7")
                    {
                        var calculator = new Calculator<object, char>();
                        string operation = InputOperation();

                        if (char.TryParse(secondArg, out char secondCharArg))
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "3" && secondArgType == "1")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "3" && secondArgType == "2")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "3" && secondArgType == "3")
                    {
                        var calculator = new Calculator<bool, bool>();
                        string operation = InputOperation();

                        if (bool.TryParse(firstArg, out bool firstBoolArg) == true && bool.TryParse(secondArg, out bool secondBoolArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstBoolArg, secondBoolArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstBoolArg, secondBoolArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstBoolArg, secondBoolArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstBoolArg, secondBoolArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "3" && secondArgType == "4")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "3" && secondArgType == "5")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "3" && secondArgType == "6")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "3" && secondArgType == "7")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "4" && secondArgType == "1")
                    {
                        var calculator = new Calculator<long, string>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "4" && secondArgType == "2")
                    {
                        var calculator = new Calculator<long, object>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "4" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "4" && secondArgType == "4")
                    {
                        var calculator = new Calculator<long, long>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true && long.TryParse(secondArg, out long secondLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "4" && secondArgType == "5")
                    {
                        var calculator = new Calculator<long, double>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true && double.TryParse(secondArg, out double secondDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "4" && secondArgType == "6")
                    {
                        var calculator = new Calculator<long, decimal>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true && decimal.TryParse(secondArg, out decimal secondDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "4" && secondArgType == "7")
                    {
                        var calculator = new Calculator<long, char>();
                        string operation = InputOperation();

                        if (long.TryParse(firstArg, out long firstLongArg) == true && char.TryParse(secondArg, out char secondCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstLongArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstLongArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstLongArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstLongArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "1")
                    {
                        var calculator = new Calculator<double, string>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "2")
                    {
                        var calculator = new Calculator<double, object>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "5" && secondArgType == "4")
                    {
                        var calculator = new Calculator<double, long>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true && long.TryParse(secondArg, out long secondLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "5")
                    {
                        var calculator = new Calculator<double, double>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true && double.TryParse(secondArg, out double secondDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "6")
                    {
                        var calculator = new Calculator<double, decimal>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true && decimal.TryParse(secondArg, out decimal secondDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "5" && secondArgType == "7")
                    {
                        var calculator = new Calculator<double, char>();
                        string operation = InputOperation();

                        if (double.TryParse(firstArg, out double firstDoubleArg) == true && char.TryParse(secondArg, out char secondCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDoubleArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDoubleArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDoubleArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDoubleArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "1")
                    {
                        var calculator = new Calculator<decimal, string>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "2")
                    {
                        var calculator = new Calculator<decimal, object>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "6" && secondArgType == "4")
                    {
                        var calculator = new Calculator<decimal, long>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true && long.TryParse(secondArg, out long secondLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "5")
                    {
                        var calculator = new Calculator<decimal, double>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true && double.TryParse(secondArg, out double secondDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "6")
                    {
                        var calculator = new Calculator<decimal, decimal>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true && decimal.TryParse(secondArg, out decimal secondDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "6" && secondArgType == "7")
                    {
                        var calculator = new Calculator<decimal, char>();
                        string operation = InputOperation();

                        if (decimal.TryParse(firstArg, out decimal firstDecimalArg) == true && char.TryParse(secondArg, out char secondCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstDecimalArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstDecimalArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstDecimalArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstDecimalArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "1")
                    {
                        var calculator = new Calculator<char, string>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "2")
                    {
                        var calculator = new Calculator<char, object>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "3")
                    {
                        Console.WriteLine("Такие типы данных не взаимодействуют между собой");
                    }
                    else if (firstArgType == "7" && secondArgType == "4")
                    {
                        var calculator = new Calculator<char, long>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true && long.TryParse(secondArg, out long secondLongArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondLongArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondLongArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondLongArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondLongArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "5")
                    {
                        var calculator = new Calculator<char, double>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true && double.TryParse(secondArg, out double secondDoubleArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondDoubleArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondDoubleArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondDoubleArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondDoubleArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "6")
                    {
                        var calculator = new Calculator<char, decimal>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true && decimal.TryParse(secondArg, out decimal secondDecimalArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondDecimalArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondDecimalArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondDecimalArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondDecimalArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else if (firstArgType == "7" && secondArgType == "7")
                    {
                        var calculator = new Calculator<char, char>();
                        string operation = InputOperation();

                        if (char.TryParse(firstArg, out char firstCharArg) == true && char.TryParse(secondArg, out char secondCharArg) == true)
                        {

                            switch (operation)
                            {
                                case "1":
                                    Console.WriteLine($"Результат:{calculator.GetSum(firstCharArg, secondCharArg)}");
                                    break;
                                case "2":
                                    Console.WriteLine($"Результат:{calculator.GetDelta(firstCharArg, secondCharArg)}");
                                    break;
                                case "3":
                                    Console.WriteLine($"Результат:{calculator.GetMultiply(firstCharArg, secondCharArg)}");
                                    break;
                                case "4":
                                    Console.WriteLine($"Результат:{calculator.GetDivide(firstCharArg, secondCharArg)}");
                                    break;
                                default:
                                    Console.WriteLine("Не существует такой операции");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Данные не соответствуют их описанию");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Неправильно выбраны типы данных");
                    }
                }
                else
                {
                    Console.WriteLine("Не существует такой команды");
                }

            }

        }

        static string InputOperation()
        {
            Console.WriteLine("Выберите операцию: 1-сумма,2-разность,3-произведение,4-деление");
            string operation = Console.ReadLine();
            return operation;
        }

    }
}
