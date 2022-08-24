//Контрольная работа

//Первый шаг создаём массив данных с типом строка
Console.WriteLine("Введите элементы массива типа string");
string[] array = new string[4];
for (int i = 0; i < 4; i++)
{
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "]");

//Второй шаг проверяем длину каждого элемента созданного массива и выводим в форме нового массива.
Console.WriteLine();

int n = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i].Length < 4)
    {
        n++;
    }
}


string[] ArrayNew = new string[n];

int j = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i].Length < 4)
    {
        ArrayNew[j] = array[i];
        j++;
    }
}

Console.Write("[" + string.Join(", ", ArrayNew) + "]");