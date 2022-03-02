// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
//
//          СПОСОБ 1
//
// Console.WriteLine("Введите числа, разделённые пробелом");
// string str = Console.ReadLine();
// string[] split = str.Split(new Char[] { ' ', ',', '.', ':' });
// int count = 0;
// foreach (string s in split)
// {
//     if (Convert.ToInt32(s) > 0)
//        {count = count + 1;}
// }
// Console.WriteLine(count);
//
//
//          СПОСОБ 2
//
Console.WriteLine("Введите числа, разделённые пробелом");
string str = Console.ReadLine();
string[] split = str.Split(new Char[] { ' '});
int count = 0;
foreach (string s in split)
{
    int number;
    bool success = int.TryParse(s, out number);
if (success && (Convert.ToInt32(s) > 0)) 
count = count + 1;
}
Console.WriteLine($"ведено чисел больше 0 : {count}");