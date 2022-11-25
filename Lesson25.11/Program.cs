void W1()
{
    Console.WriteLine("Введите число");
    int k = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (k > 0)
    {
        sum = sum + k;
        k--;
    }
    Console.WriteLine(sum);
}
void W2()
{
    int k = 1;
    int sum = 0;
    int count = 0;
    while (k != 0)
    {
        Console.WriteLine("Введите число");
        k = Convert.ToInt32(Console.ReadLine());
        sum = sum + k;
        count++;
    }
    Console.WriteLine();
    Console.WriteLine(sum);
    Console.WriteLine(count);
}
void W3()
{
    int k = 1;
    while (k > 0 && k < 100)
    {
        Console.WriteLine("Введите число");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (k > 0 && k < 100)
    Console.WriteLine("Вы ввели правильное число");
}
W3();