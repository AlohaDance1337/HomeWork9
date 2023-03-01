int Sum(int num1, int num2)
{
    if (num1 > num2)
    {
        return num2; 
    }
    return num2 + Sum(num1, num2 - 1);
}

int Promt(string message)
{
    Console.Write($"{message}");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int n1 = Promt("Введите начальное значение промежутка: ");
int n2 = Promt("Введите конечное значение промежутка: ");

Console.Write($"Сумма натуралбных чисел: {Sum(n1, n2)}");
