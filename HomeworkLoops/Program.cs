using System;

namespace HomeworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourthTask();
            //FifthTask();
            //SixthTask();
            //SeventhTask();
            //EighthTask();
            //NinthTask();
            //TenthTask();
            //EleventhTask();
            //TwelvethTask();

        }

        /// <summary>
        /// Пользователь вводит 2 числа(A и B). Возвести число A в степень B.
        /// </summary>
        static void FirstTask()
        {
            int numberToPower;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the number to power (A):");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out numberToPower);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int power;
            do
            {
                Console.WriteLine("Enter the power (B):");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out power);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int resultOfPower = numberToPower;
            for (int i = 1; i < power; i++)
            {
                resultOfPower *= numberToPower;
            }

            Console.WriteLine($"The result of power is: {resultOfPower}");

        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        /// </summary>
        static void SecondTask()
        {
            int divider;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the Divider:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out divider);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            for (int i = 1; i <= 1000; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        /// </summary>
        static void ThirdTask()
        {
            int theNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter THE NUMBER:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out theNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int countOfRightSquareNumbers = 0;

            for (int i = 1; i < theNumber; i++)
            {
                if (i * i < theNumber)
                {
                    countOfRightSquareNumbers++;
                }
            }

            Console.WriteLine($"Count of numbers whose square is less than the NUMBER is: {countOfRightSquareNumbers}");
        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        /// </summary>
        static void FourthTask()
        {
            int theNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter THE NUMBER:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out theNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);


            for (int i = theNumber - 1; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine("You typed a prime number, isn't it?:)");
                    return;
                }
                if (theNumber % i == 0)
                {
                    Console.WriteLine($"Maximum divider of THE NUMBER is: {i}");
                    return;
                }
            }

            Console.WriteLine("Sorry, you have lose this game. Try again:)");
        }

        /// <summary>
        /// Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
        /// которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        /// </summary>
        static void FifthTask()
        {
            int firstBoundaryRange;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the first boundary value of range:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out firstBoundaryRange);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int secondBoudaryRange;
            do
            {
                Console.WriteLine("Enter the second boundary value of range:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out secondBoudaryRange);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            if (firstBoundaryRange == secondBoudaryRange)
            {
                if (firstBoundaryRange % 7 == 0)
                {
                    Console.WriteLine("This range consist of a single value. " +
                        "And its value divided by 7 without remainder");
                    return;
                }
                else
                {
                    Console.WriteLine("This range consist of a single value. " +
                        "And its value DOESN'T divided by 7 without remainder");
                    return;

                }
            }

            if (firstBoundaryRange > secondBoudaryRange)
            {
                int _ = firstBoundaryRange;
                firstBoundaryRange = secondBoudaryRange;
                secondBoudaryRange = _;
            }

            int sumOfRangeNumbersDividedBySeven = 0;
            for (int i = firstBoundaryRange; i <= secondBoudaryRange; i++)
            {
                if (i % 7 == 0)
                {
                    sumOfRangeNumbersDividedBySeven += i;
                }
            }

            Console.WriteLine($"The sum of the numbers in this range, which are divisible by 7 " +
                $" without remainder is: {sumOfRangeNumbersDividedBySeven}");
        }


        /// <summary>
        /// Пользователь вводит 1 число(N). Выведите N-ое число ряда фибоначчи.В ряду фибоначчи
        /// каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        /// </summary>
        static void SixthTask()
        {
            int indexFibonacciSeries;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter that number of Fibonacci series that you want to find out");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out indexFibonacciSeries);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
                else if (indexFibonacciSeries < 1)
                {
                    Console.WriteLine("That number can not be less than 1");
                    validNumber = false;
                }
            }
            while (!validNumber);

            if (indexFibonacciSeries == 1 || indexFibonacciSeries == 2)
            {
                Console.WriteLine($"Value of {indexFibonacciSeries} term of the Fibonacci series is: 1");
                return;
            }

            int previousValueFibonacciSeries = 1;
            int currentValueFibonacciSeries = 1;

            for (int i = 2; i < indexFibonacciSeries; i++)
            {
                //NAMING -__________-
                int previousPreviousValueFibonacciSeries = previousValueFibonacciSeries;
                previousValueFibonacciSeries = currentValueFibonacciSeries;

                currentValueFibonacciSeries = previousValueFibonacciSeries + previousPreviousValueFibonacciSeries;

            }
            Console.WriteLine($"Value of {indexFibonacciSeries} term of the Fibonacci series is: {currentValueFibonacciSeries}");

        }

        /// <summary>
        /// Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
        /// </summary>
        static void SeventhTask()
        {
            int firstNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the first number:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out firstNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int secondNumber;
            do
            {
                Console.WriteLine("Enter the second number:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out secondNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("You typed the same numbers. Next time try another numbers:)");
                return;
            }


            int greaterNumber;
            int smallerNumber;

            if (firstNumber > secondNumber)
            {
                greaterNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                greaterNumber = secondNumber;
                smallerNumber = firstNumber;
            }


            int greatestCommonDivisor = 0;
            do
            {

                if (greaterNumber % smallerNumber == 0)
                {
                    greatestCommonDivisor = smallerNumber;
                }
                else
                {
                    greaterNumber %= smallerNumber;
                    if (greaterNumber < smallerNumber)
                    {
                        int _ = greaterNumber;
                        greaterNumber = smallerNumber;
                        smallerNumber = _;
                    }
                }

            }
            while (greatestCommonDivisor == 0);

            Console.WriteLine($"Greatest common divisor for this numbers is: {greatestCommonDivisor}");
        }

        /// <summary>
        /// Пользователь вводит целое положительное число,
        /// которое является кубом целого числа N. Найдите число N методом половинного деления.
        /// </summary>
        static void EighthTask()
        {
            int usersCubeNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the positive number that's have be cube of some number:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out usersCubeNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
                else if (usersCubeNumber < 1)
                {
                    Console.WriteLine("You have to type POSITIVE number and not zero of course. Try again");
                    validNumber = false;
                }
            }
            while (!validNumber);

            int leftSide = 0;
            int rightSide = usersCubeNumber;
            int middle;
            long cubeOfMiddle;

            int criticalCountOfLoops = 1000;
            do
            {
                middle = (leftSide + rightSide) / 2;
                cubeOfMiddle = (long)middle * middle * middle;

                //For debug
                Console.WriteLine($"left side: {leftSide} middle: {middle} right side: {rightSide}  cube of middle: {cubeOfMiddle}");

                if (cubeOfMiddle == usersCubeNumber)
                {
                    Console.WriteLine($"You have WIN! And you find the number you were looking for: {middle}");
                    return;
                }

                //for next loop
                if(cubeOfMiddle > usersCubeNumber)
                {
                    rightSide = middle;
                }
                else
                {
                    leftSide = middle;
                }
                criticalCountOfLoops--;
            }
            while (criticalCountOfLoops > 0);

            Console.WriteLine($"So sorry, you have lost, but number you looking for is around: {middle}");

        }


        /// <summary>
        /// Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
        /// </summary>
        static void NinthTask()
        {
            int userTypedNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter THE NUMBER:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out userTypedNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int countOfOddDigits = 0;
            int numberToFindOddDigits = userTypedNumber;
            do
            {
                if (numberToFindOddDigits % 2 == 1)
                    countOfOddDigits++;
            }
            while ((numberToFindOddDigits /= 10) != 0);

            Console.WriteLine($"Count of odd digits in {userTypedNumber} is: {countOfOddDigits}");
        }

        /// <summary>
        /// Пользователь вводит 1 число.Найти число, которое является зеркальным отображением 
        /// последовательности цифр заданного числа, например, задано число 123, вывести 321.
        /// </summary>
        static void TenthTask()
        {
            int userTypedNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter THE NUMBER:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out userTypedNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int mirrorNumber = 0;
            int croppedUserNumber = userTypedNumber;
            do
            {
                mirrorNumber *= 10;
                mirrorNumber += croppedUserNumber % 10;
            }
            while ((croppedUserNumber /= 10) != 0);

            Console.WriteLine($"For typed number: {userTypedNumber}  mirror number is: {mirrorNumber}");
        }


        /// <summary>
        /// Пользователь вводит целое положительное  число (N). 
        /// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        /// </summary>
        static void EleventhTask()
        {
            int userTypedNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter boarder number to find numbers:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out userTypedNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);


            for (int i = 1; i <= userTypedNumber; i++)
            {

                int sumEvenDigits = 0;
                int sumOddDigits = 0;

                int croppedIndexNumber = i;
                do
                {
                    int lastDigit = croppedIndexNumber % 10;
                    if (lastDigit % 2 == 0)
                    {
                        sumEvenDigits += lastDigit;
                    }
                    else
                    {
                        sumOddDigits += lastDigit;
                    }
                }
                while ((croppedIndexNumber /= 10) != 0);

                if (sumEvenDigits > sumOddDigits)
                    Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        /// Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.      
        /// </summary>
        static void TwelvethTask()
        {
            int firstUserNumber;
            bool validNumber;

            do
            {
                Console.WriteLine("Enter the first number:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out firstUserNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int secondUserNumber;
            do
            {
                Console.WriteLine("Enter the second number:");
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out secondUserNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);

            int firstCroppedNumber = firstUserNumber;
            do
            {
                int lastDigitFirstCroppedNumber = firstCroppedNumber % 10;
                int secondCroppedNumber = secondUserNumber;
                do
                {
                    int lastDigitSecondCroppedNumber = secondCroppedNumber % 10;
                    if (lastDigitFirstCroppedNumber == lastDigitSecondCroppedNumber)
                    {
                        Console.WriteLine("This pair of numbers have at least one same digit.");
                        return;
                    }
                }
                while ((secondCroppedNumber /= 10) != 0);
            }
            while ((firstCroppedNumber /= 10) != 0);

            Console.WriteLine("This pair of numbers have not same digits.");

        }


    }
}
