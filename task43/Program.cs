// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}





double k1 = InputNumber("Введите значение k1: ");
double b1 = InputNumber("Введите значение b1: ");
double k2 = InputNumber("Введите значение k2: ");
double b2 = InputNumber("Введите значение b2: ");