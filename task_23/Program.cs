// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Напишите простое положительное число");
int n = Convert.ToInt32(Console.ReadLine());
function(n);
void function(int n)
{
    for (int i = 1; i <= n; i++)
    {
        int icube = i * i * i;
        Console.Write(icube + " ");
    }
    Console.WriteLine("");
}