/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и 
наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
int size = 8;
int[] array = GetArray(size);
Print(array);
Console.WriteLine();
GetChangePrint(array);


int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-9, 9);
  }
  return array;
}

void GetChangePrint(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] *= -1;
  }
  Console.Write($"[{String.Join(", ", array)}]");
}

void Print(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}