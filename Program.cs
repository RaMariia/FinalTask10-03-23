/*Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] array1 = new string[size];

for (int i = 0; i < size; i++)
{
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	array1[i] = result;  
}

Console.WriteLine();
Console.Write("Вы ввели: [");
Console.Write(string.Join(",", array1));
Console.Write("]");

int count = 0;
int MaxLength = 3;

for (int i = 0; i < array1.Length; i++)
{
	if(array1[i].Length <= MaxLength)
        {
		    count++;
	    }   
}
Console.WriteLine();
Console.Write("Массивы с количеством символов 3 и менее: [");
string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= MaxLength)
    {
        array2[j] = array1[i];
        Console.Write(array2[j] + ",");
        j++;
    }
}
Console.Write("]");