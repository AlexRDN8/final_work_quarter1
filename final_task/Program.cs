// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекоммендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"] -> ["2",":-)"]

string[] array = new string []{"hello", "2", "world", ":-)"};
int lengthNewArray = GetLengthNewArray(array);
string[] newArray = GetArrayWith4LessSigns(array, lengthNewArray);
PrintArray(newArray);

int GetLengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i].Length <= 3)
        {
            count +=1;
        }
    }
    return count;
}

GetArrayWith4LessSigns(array, lengthNewArray);

string[] GetArrayWith4LessSigns(string[] oldArray, int lengthNewArray)
{
    string[] newArray = new string [lengthNewArray];
    int index = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            newArray[index] = oldArray[i];
            index +=1;
        }    
    }
    return newArray;
}

void PrintArray(string[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine(message);
}


