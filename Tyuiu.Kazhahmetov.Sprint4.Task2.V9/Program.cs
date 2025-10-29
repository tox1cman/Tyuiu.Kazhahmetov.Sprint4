using Tyuiu.Kazhahmetov.Sprint4.Task2.V9.Lib;

DataService ds = new DataService();

Random rnd = new Random();

Console.Title = "Спринт #4 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сколько элементов:");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

for (int i = 0; i < len; i++)
{
    array[i] = rnd.Next(1, 7);
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.WriteLine(array[i] + "\t");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(array);
Console.WriteLine(res);
Console.ReadKey();