/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5 */

Console.Clear();
int size = 123;
int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}] -> {GetChangePrint(array)}");


int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(0, 150);
  }
  return array;
}

int GetChangePrint(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99) {
        count++;
    }
  }
  return count;
}