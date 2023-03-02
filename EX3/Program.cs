int FuncAck(int n, int m)
{
    
    if (n == 0) 
        return m + 1;
    if (n != 0 && m == 0) 
        return FuncAck(n - 1, 1);
    if (n > 0 && m > 0) 
        return FuncAck(n - 1, FuncAck(n, m - 1));

    return FuncAck(n,m);
}

int Promt(string message)
{
    Console.Write($"{message}");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int n1 = Promt("Введите начальное значение промежутка: ");
int n2 = Promt("Введите конечное значение промежутка: ");

Console.Write($"Сумма натуралбных чисел: {FuncAck(n1, n2)}");
