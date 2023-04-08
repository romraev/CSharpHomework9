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

// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ackermann(m-1,1);
    else return Ackermann(m-1, Ackermann(m, n-1));
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат вычисления функции Aккермана для чисел {M} и {N} равен: {Ackermann(M,N)}");