void ShowNumbers(int num1, int num2)
{

    if (num1 > num2)
    {
        return;
    }
    
    if((num1 != num2) && (num1 % 2 == 0) )
    {
         Console.Write($"{num1} ");
    }

    ShowNumbers(num1+1, num2);
}

int Promt(string message)
{
    Console.Write($"{message}");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int n1 = Promt("Введите начальное значение промежутка: ");
int n2 = Promt("Введите конечное значение промежутка: ");

ShowNumbers(n1,n2);
