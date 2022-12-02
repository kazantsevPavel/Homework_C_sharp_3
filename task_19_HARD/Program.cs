// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.
// Через строку нельзя решать само собой.

Console.WriteLine("Привет, друг! Я просто обожаю палиндромы, а ты? Напиши какое-нибудь красивое число!");
int inputNum = Convert.ToInt32(Console.ReadLine());
int count = 0;
int numCurrent = inputNum; // цифра слева
int countCurrent = count; // обратный счетчик для левой половины палиндрома
int numReflection = inputNum; // цифра справа
int countCoincidence = 0; //счетчик совпадений цифер палиндрома

// функция вычисления длины числа
int getNumLength(int num)
{
    int length = 0;
    while (num > 0)
    {
        num = num / 10;
        length = length + 1;
    }
    return length;
}
count = getNumLength(inputNum);
countCurrent = count;
int endNum = (count - 1) / 2;
if (count % 2 == 0)
{
    endNum = count / 2;
}
for (int i = 0; i < endNum; i++)
{
    numCurrent = inputNum / Convert.ToInt32(Math.Pow(10, countCurrent - 1));
    numCurrent = numCurrent % 10;
    countCurrent--;
    numReflection = inputNum / Convert.ToInt32(Math.Pow(10, i));
    numReflection = numReflection % 10;
    if (numCurrent == numReflection) countCoincidence++;
}
if (countCoincidence == count / 2) System.Console.WriteLine("Отличное число! Самый настоящий палиндром!");
else System.Console.WriteLine("Ужасное число! Это НЕ палиндром");