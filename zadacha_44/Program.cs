// Задача 44: Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, 
// если b1, k1, b2 и k2 заданы
Console.Write("Введите k1, b1, k2, b2, разделённые пробелами: ");
string str = Console.ReadLine();
string[] split = str.Split(new Char[] { ' ' });
int[] coordinates = new int[split.Length];
for (int i = 0; i < split.Length; i++)
{
    coordinates[i] = Int32.Parse(split[i]);
}
Console.WriteLine("Точка пересечения прямых, заданных уравнениями:");
Console.WriteLine($"y = {coordinates[0]} * x + {coordinates[1]},");
Console.WriteLine($"y = {coordinates[2]} * x + {coordinates[3]},");
Console.Write($"( {(coordinates[3] - coordinates[1]) / (coordinates[0] - coordinates[2])} ; {(coordinates[0] * ((coordinates[3] - coordinates[1]) / (coordinates[0] - coordinates[2]))) + coordinates[1]} )");

