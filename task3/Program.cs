/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет

3; массив[6, 7, 19, 345, 3]->да*/

Console.Clear();
int num = GetNum();

int[] array = GetArray();
Console.WriteLine();
Search(array, num);

int GetNum()
{
  Console.Write("Введите число: ");
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

int[] GetArray()
{
  int size = new Random().Next(5, 15);
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
  return array;
}

void Search(int[] array, int num)
{
  bool exist = false;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == num) {
      exist = true;
      break;
    }
    else {
      exist = false;
    } 
  }

  if (exist == true){
    Console.WriteLine($"{num} -> [{String.Join(", ", array)}] -> да");
  }
  else{
    Console.WriteLine($"{num} -> [{String.Join(", ", array)}] -> нет");
  }
}