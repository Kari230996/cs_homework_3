
// Первое задание

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int copy_n = number;
int result = 0;

if (Math.Abs(number) > 9999 && Math.Abs(number) < 100000)
{

    while (number != 0)
    {
        int digit = number % 10;
        result = result * 10 + digit;
        number /= 10;

    }

    if (result == copy_n)
    {
        Console.WriteLine($"Да, число {copy_n} является ПАЛИНДРОМОМ");
    }
    else
    {
        Console.WriteLine($"Нет, число {copy_n} не является ПАЛИНДРОМОМ");
    }
}
else
{
    Console.WriteLine("Вы должны ввести 5-значное число ;)");
}


/*
// Второе задание

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{

    float deltaX = x2 - x1;
    float deltaY = y2 - y1;
    float deltaZ = z2 - z1;

    double result = 0;
    result = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));

    return result;
}

Console.WriteLine("Введите координаты: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2));

*/
/*

// Третье задание

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int stepen = 3;

foreach (int i in Enumerable.Range(1, num))
{
    Console.Write(Math.Pow(i, stepen) + " ");
}
*/