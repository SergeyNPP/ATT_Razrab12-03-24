
Console.WriteLine("Добрый день. Прошу Вас указать, сколько значений вы введете");

int num = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Теперь введите значения");

string[] array = new string[num];
for (int i = 0; i < num; i++)  
    array[i]= Console.ReadLine ();
            

Console.WriteLine("Сейчас мы посмотрим, сколько вы ввели трехзначных элементов в наш массив");
Console.WriteLine("Смотрите");
int j = 0;
for (int i = 0; i < num; i++)
    if(array[i].Length <=3)
    {
        array[j]= array[i];
        j++;
    }

// for (int j = 0; j < num; j++)

//     string Metod4(int count, string array[i]) //char C символ  (си)
//         {
//         int i = 0; 
//         string result = string.Empty;

//         while (i<count)
//         {
//             result = result + TextF2;
//             i++;
//         }
//         return result;
//         }

// // string s = array[];
// // char[] a = s.array();

// // string str = "Собака";

// // foreach(char c in str)
// // {
// //    Console.WriteLine(c);
// // }

// // Console.ReadLine();
