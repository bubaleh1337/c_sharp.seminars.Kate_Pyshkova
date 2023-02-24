//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();
int size = 12;
int[] array = GetArray(size);
int plus = GetPlus(array);
int minus = GetMinus(array);
Console.WriteLine($"Положительные числа: {plus}, отрицательные числа: {minus}");

int[] GetArray(int size)
{
  plus = 0;
  minus = 0;
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-9, 9);
  }
  return array;
}

int GetPlus(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-9, 9);
    if (array[i] > 0)
    {
       sum += array[i];
    }
  }
  return sum;
}

int GetMinus(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-9, 9);
    if (array[i] < 0)
    {
       sum += array[i];
    }
  }
  return sum;
}
