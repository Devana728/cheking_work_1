// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
void printArray(string[] array)
{
System.Console.Write("[");

int i = 1;
System.Console.Write(array[0]);
while (i < array.Length && array[i] != null)
{
    System.Console.Write($", {array[i]}");
    i ++;
}

System.Console.WriteLine("]");
}

string[] NewArray(string[] array)
{
   string[] result = new string[array.Length];
   var i = 0;
   foreach (var value in array )
   {
    if (value.Length <= 3)
    {
        result[i] = value;
        i++;
    }
    
   }
   return result;
}

string[] array = {"hello","world","i","love","you"};
string[] array2 = NewArray(array);

printArray(array);
System.Console.Write( "->" );
System.Console.WriteLine();
printArray(array2);
System.Console.WriteLine();

