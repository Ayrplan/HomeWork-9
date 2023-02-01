Console.Clear();
// ЧЕРЕЗ РЕКУРСИЮ
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите целое число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число M:");
// int N = Convert.ToInt32(Console.ReadLine());

// void GapNumberSum (int M, int N, int sum)
// {
//     if (M > N) 
//     {
//         Console.WriteLine($"Сумма натур.элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (M++);
//     GapNumberSum(M, N, sum);
// }

// GapNumberSum(M, N, 0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите начальное число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return AckermannFunction(m - 1, 1);
//     if (m > 0 && n > 0)
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     return AckermannFunction(m, n);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");


