using Tyuiu.Kazhahmetov.Sprint4.Task1.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Сколько элементов:");
len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0;i < len; i++)
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