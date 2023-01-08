// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
// int Find(int d)
// {
//     if (d == 0) 
//         return 0; 
//     else
//         return (d % 2 + 10 * Find(d / 2));
// }
// void Print (int d){
//     Console.Write($"В двоичной системе: {Find(d)}");
// }

// Console.Write("Введите число: ");
// int d = Convert.ToInt32(Console.ReadLine());

// Print(d);


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке

// int SumNumb (int m, int n){
//     int sum = 0;
//     if (n == m)
//         return 0;
//     else {
//         m++;
//         sum = m + SumNumb(m,n);
//         return sum;
//     }
// }
// void ShowSum(int m, int n){
//     Console.Write(SumNumb(m-1,n));
// }
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowSum(m,n);