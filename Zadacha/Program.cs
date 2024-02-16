
Console.WriteLine("Добрый день. Прошу Вас указать, сколько значений вы введете");

int num = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Теперь введите значения");

string[] array = new string[num];
for (int i = 0; i < num; i++)  
    array[i]= Console.ReadLine (); 

Console.WriteLine("Сейчас мы посмотрим, сколько вы ввели трехзначных элементов в наш массив");
Console.WriteLine("Смотрите");

void PrintArray(int[] array)                       //<--вывод данного массива на экран
{
    int count = array.Length;                      //Получение количества элементов 

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(NewArr);