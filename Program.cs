using System;

namespace HW2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstUserName;
            int firstUserAge;
            int firstUserHeight;
            int firstUserPointsInRussian, firstUserHistoryPoints, firstUserPointsInMathematics;

            string secondUserName;
            int secondUserAge;
            int secondUserHeight;
            int secondUserPointsInRussian, secondUserHistoryPoints, secondUserPointsInMathematics;

            string thirdUserName;
            int thirdUserAge;
            int thirdUserHeight;
            int thirdUserPointsInRussian, thirdUserHistoryPoints, thirdUserPointsInMathematics;

            string centrString;
            string warnningString = "Не корректный ввод. Повторите";

            //first user data
            Console.WriteLine("Пользователь 1 введите имя ");
            firstUserName = CheckUserName(Console.ReadLine());

            Console.WriteLine("Пользователь 1 введите рост ");
            while (!int.TryParse(Console.ReadLine(), out firstUserHeight) || firstUserHeight <= 0 || firstUserHeight > 250)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 1 введите возраст ");
            while (!int.TryParse(Console.ReadLine(), out firstUserAge) || firstUserAge <= 0 || firstUserAge > 150)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 1 введите балы по русскому, истории, математике");
            while (!int.TryParse(Console.ReadLine(), out firstUserPointsInRussian) || firstUserPointsInRussian <= 0 || firstUserPointsInRussian > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out firstUserHistoryPoints) || firstUserHistoryPoints <= 0 || firstUserHistoryPoints > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out firstUserPointsInMathematics) || firstUserPointsInMathematics <= 0 || firstUserPointsInMathematics > 100)
            {
                Console.WriteLine(warnningString);
            }
            GetAverage(firstUserPointsInRussian, firstUserPointsInMathematics, firstUserHistoryPoints);

            Console.WriteLine("Имя: " + firstUserName + " Рост: " + firstUserHeight +
                              " Возраст: " + firstUserAge + " Баллы: " + firstUserPointsInRussian +
                              " - " + firstUserHistoryPoints + " - " + firstUserPointsInMathematics);

            /* second user data */

            Console.WriteLine("Пользователь 2 введите имя ");
            secondUserName = CheckUserName(Console.ReadLine());
            Console.WriteLine("Пользователь 2 введите рост ");
            while (!int.TryParse(Console.ReadLine(), out secondUserHeight) || secondUserHeight <= 0 || secondUserHeight > 250)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 2 введите возраст ");
            while (!int.TryParse(Console.ReadLine(), out secondUserAge) || secondUserAge <= 0 || secondUserAge > 150)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 2 введите балы по русскому, истории, математике");
            while (!int.TryParse(Console.ReadLine(), out secondUserPointsInRussian) || secondUserPointsInRussian <= 0 || secondUserPointsInRussian > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out secondUserHistoryPoints) || secondUserHistoryPoints <= 0 || secondUserHistoryPoints > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out secondUserPointsInMathematics) || secondUserPointsInMathematics <= 0 || secondUserPointsInMathematics > 100)
            {
                Console.WriteLine(warnningString);
            }
            GetAverage(secondUserPointsInRussian, secondUserHistoryPoints, secondUserPointsInMathematics);

            Console.WriteLine("Имя: {0} Рост: {1} Возраст: {2} Баллы: {3} - {4} - {5}", secondUserName, secondUserHeight,
                                                                                        secondUserAge, secondUserPointsInRussian,
                                                                                        secondUserHistoryPoints, secondUserPointsInMathematics);

            //third user data
            Console.WriteLine("Пользователь 3 введите имя ");
            thirdUserName = CheckUserName(Console.ReadLine());

            Console.WriteLine("Пользователь 2 введите рост ");
            while (!int.TryParse(Console.ReadLine(), out thirdUserHeight) || thirdUserHeight <= 0 || thirdUserHeight > 250)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 2 введите возраст ");
            while (!int.TryParse(Console.ReadLine(), out thirdUserAge) || thirdUserAge <= 0 || thirdUserAge > 150)
            {
                Console.WriteLine(warnningString);
            }

            Console.WriteLine("Пользователь 2 введите балы по русскому, истории, математике");
            while (!int.TryParse(Console.ReadLine(), out thirdUserPointsInRussian) || thirdUserPointsInRussian <= 0 || thirdUserPointsInRussian > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out thirdUserHistoryPoints) || thirdUserHistoryPoints <= 0 || thirdUserHistoryPoints > 100)
            {
                Console.WriteLine(warnningString);
            }
            while (!int.TryParse(Console.ReadLine(), out thirdUserPointsInMathematics) || thirdUserPointsInMathematics <= 0 || thirdUserPointsInMathematics > 100)
            {
                Console.WriteLine(warnningString);
            }

            //интерполяцией
            centrString = $"Имя: {thirdUserName} Рост: { thirdUserHeight} Возраст:  {thirdUserAge} " +
                          $"Баллы: {thirdUserPointsInRussian} - { thirdUserHistoryPoints} - { thirdUserPointsInMathematics} ";

            /// < remarks >
            /// Вывод в центр консоли
            /// </ remarks >
            Console.SetCursorPosition(Console.WindowWidth / 2 - centrString.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(centrString);

            string CheckUserName(string name)
            { 
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine(warnningString);
                    name = Console.ReadLine();
                }
                return name;             
            }

            void GetAverage(int a, int b, int c)
            {
                double average = 0;
                average = Math.Round((double)(a + b + c) / 3, 2);
                Console.WriteLine("Средний бал " + average);
            }
        }
        

    }
}
