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

            //first user data
            Console.WriteLine("Пользователь 1 введите имя ");
            firstUserName = CheckUserName(Console.ReadLine());

            Console.WriteLine("Пользователь 1 введите рост ");
            firstUserHeight = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 1 введите возраст ");
            firstUserAge = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 1 введите балы по русскому, истории, математике");
            firstUserPointsInRussian = CheckUserNumber(int.Parse(Console.ReadLine()));
            firstUserHistoryPoints = CheckUserNumber(int.Parse(Console.ReadLine()));
            firstUserPointsInMathematics = CheckUserNumber(int.Parse(Console.ReadLine()));
            GetAverage(firstUserPointsInRussian, firstUserPointsInMathematics, firstUserHistoryPoints);

            Console.WriteLine(firstUserName + firstUserAge + firstUserHeight + firstUserPointsInRussian +
                        firstUserPointsInMathematics + firstUserHistoryPoints);

            /* second user data */
            Console.WriteLine("Пользователь 2 введите имя ");
            secondUserName = CheckUserName(Console.ReadLine());

            Console.WriteLine("Пользователь 2 введите рост ");
            secondUserHeight = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 2 введите возраст ");
            secondUserAge = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 2 введите балы по русскому, истории, математике");
            secondUserPointsInRussian = CheckUserNumber(int.Parse(Console.ReadLine()));
            secondUserHistoryPoints = CheckUserNumber(int.Parse(Console.ReadLine()));
            secondUserPointsInMathematics = CheckUserNumber(int.Parse(Console.ReadLine()));
            GetAverage(secondUserPointsInRussian, secondUserHistoryPoints, secondUserPointsInMathematics);

            Console.WriteLine("Имя: {0} Рост: {1} Возраст: {2} Баллы: {3} - {4} - {5}", secondUserName, secondUserHeight,
                                                                                        secondUserAge, secondUserPointsInRussian,
                                                                                        secondUserHistoryPoints, secondUserPointsInMathematics);

            //third user data
            Console.WriteLine("Пользователь 3 введите имя ");
            thirdUserName = CheckUserName(Console.ReadLine());

            Console.WriteLine("Пользователь 3 введите рост ");
            thirdUserHeight = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 3 введите возраст ");
            thirdUserAge = CheckUserNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine("Пользователь 3 введите балы по русскому, истории, математике");
            thirdUserPointsInRussian = CheckUserNumber(int.Parse(Console.ReadLine()));
            thirdUserHistoryPoints = CheckUserNumber(int.Parse(Console.ReadLine()));
            thirdUserPointsInMathematics = CheckUserNumber(int.Parse(Console.ReadLine()));
            GetAverage(thirdUserPointsInRussian, thirdUserHistoryPoints, thirdUserPointsInMathematics);

            centrString = "Имя: " + thirdUserName + "Рост: " + thirdUserHeight +
                              "Возраст: " + thirdUserAge + " Баллы: " + thirdUserPointsInRussian +
                              " - " + thirdUserHistoryPoints + " - " + thirdUserPointsInMathematics;
            /// <remarks>
            /// Вывод в центр консоли
            /// </remarks>
            Console.SetCursorPosition(Console.WindowWidth / 2 - centrString.Length, Console.WindowHeight / 2);
            Console.WriteLine(centrString);


            string CheckUserName(string name)
            { 
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Не корректный ввод");
                    name = Console.ReadLine();
                }
                return name;             
            }

            int CheckUserNumber(int number)
            {
                while (number <= 0 || number > 200)
                {
                    Console.WriteLine("Не корректное значение. Повторите");
                    number = int.Parse(Console.ReadLine());
                }
                return number;
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
