// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

System.Console.WriteLine("Cколько измерений в вашем пространстве, путник?");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Хм, всего " + N + " не думал, что бывают такие примитивные существа...");
System.Console.WriteLine("Введите координаты точки, где вы сейчас находитесь.");
System.Console.WriteLine($"Чисел должно быть ровно {N}: ");
int[] coordinates = new int[N * 2];
for (int i = 0; i < coordinates.Length; i++)
{
    coordinates[i] = Convert.ToInt32(Console.ReadLine());
    if (i == N-1) System.Console.WriteLine("Введите координаты точки, куда вы хотите отправиться: ");
}
int sum = 0;
double d = 0;
for (int i = 0; i < coordinates.Length / 2; i++)
{
    sum = sum + ((coordinates[i] - coordinates[i + N]) * (coordinates[i] - coordinates[i + N]));
    d = MathF.Sqrt(sum);
}
System.Console.WriteLine($"Расстояние от точки, где вы находитесь до места, куда вы хотите отправится составляет {d} универсальных единиц пространства");






