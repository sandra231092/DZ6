//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

int count = 0;

for (int j = 0; j < arr.Length; j++)
{
    if(arr[j] > 0)
    {
        count = count + 1;
    }
}

Console.WriteLine(" ");
Console.WriteLine($"Колличество чисел больше 0 = {count}");
