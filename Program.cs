//Контрольная работа

//Первый шаг создаём массив данных с типом строка
Console.WriteLine("Введите элементы массива типа string");
string[] array = new string[4];
for (int i = 0; i < 4; i++)
{
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "]");

