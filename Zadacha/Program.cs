
Console.WriteLine("Добрый день. Прошу Вас указать, сколько значений вы введете");

int num = Convert.ToInt32(Console.ReadLine ());
//  array [6, ABC, :-), 1234, complucter, .i.]

Console.WriteLine("Теперь введите значения");


string[] array = new string[num];
int count = 0;
for (int i = 0; i < num; i++)  
    {
    array[i]= Console.ReadLine ();  
    if (array[i].Length <=3)
         {
             count++;
         }      
    } 
Console.WriteLine("Сейчас мы посмотрим, сколько вы ввели трехзначных элементов в наш массив");

Console.WriteLine(count);

Console.WriteLine("Смотрите");

string[] arr = new string[count];
for (int j = 0; j < count; )
    {
        for (int i = 0; i < num; i ++)
        {
            if(array[i].Length <=3)
            {
                arr[j]=array[i];
                Console.Write(arr[j]);
                Console.Write(" ");
                j++;
            }
             
        }
    
    }



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
