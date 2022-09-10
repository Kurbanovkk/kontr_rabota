/* Задача: написать прогу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3символа
Певоначальный массив можно ввести с клавиатуры, либо задать на старте выаолнения.
При решении не реконмендуется пользоваться коллекциями. Лучше обойтись исключительно массивами.*/

string[] array = { "hello", "2", "word", ";-)" };
int cost = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) cost++;
}

string[] newArray = new string[cost];
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[k] = array[i];
        k++;
    }
}

for (int i = 0; i < newArray.Length; i++)
{
    if (i < newArray.Length - 1) System.Console.Write(newArray[i] + ", ");
    else System.Console.Write(newArray[i]);
}
