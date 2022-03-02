// Задача 46: Написать программу масштабирования фигуры

// Для тех, кто ушёл далеко вперёд, — усложнение.
// Сделать так, чтобы:
// 1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
// 2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
// 3. В результате были выводились полученные координаты.
// При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
Console.Write("Введите координаты вершин фигуры строкой вида: (0,0) (2,0) (2,2)...(0,2)   ");
string str = Console.ReadLine();
//using System.Linq;
string strCrop1 = str.Replace("(", "");
string strCrop2 = strCrop1.Replace(")", "");
string[] split = strCrop2.Split(new Char[] { ' ' });
//Console.Write(split[0]);
Console.Write("Введите коэффициент масштабирования:  ");
decimal Coef = Decimal.Parse(Console.ReadLine());
//int [,] coord = new int [split.Length,2];
Console.Write("Координаты вершин фигуры после масштабирования:");
for (int i = 0; i <= split.Length; i++)
{   Console.WriteLine(split[i]);
    string[] spliti = split[i].Split(new Char[] { ',' });
    Console.Write($"({(Int32.Parse(spliti[0])) * Coef},{((Int32.Parse(spliti[1])) * Coef)}) ");
 
//     for (int j = 0; j < 2; j++)
//     coord[i,j] = Int32.Parse(spliti[j]);
//     //Console.Write($"({coord[i,j] * Coef}");
}

