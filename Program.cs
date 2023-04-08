// Подготовил Раевский Р.Ю.

// Task 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

/* void Numbers(int N)
{
    Console.Write(N+" ");
    if(N>1)  Numbers(N-1);
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Numbers(num);
*/

// Task 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* int Sum(int M, int N)
{
    int sum = 0;
    if(M>N) sum = M + Sum(M-1, N);
    else if (N>M) sum = M + Sum(M+1, N);
    return sum;
}

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма целых чисел между M и N равна: " + (Sum(M, N)-M)); // Наверное не очень правильно, зато кратко и работает))
*/
