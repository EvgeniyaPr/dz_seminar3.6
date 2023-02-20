// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите число: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int countNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        result++;
    }
    return result;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

PrintArray(array);
System.Console.WriteLine($"Введено чисел больше 0 = {countNumbers(array)}");
