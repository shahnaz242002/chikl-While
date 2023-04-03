Console.OutputEncoding = System.Text.Encoding.UTF8;
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Нет денег");
}
else
{

    while (a > 1000)
    {
        Console.WriteLine("1000");
        a = a - 1000;
    }
    while (a > 500 && a < 1000)
    {
        Console.WriteLine("500");
        a = a - 500;
    }
    while (a >= 100 && a < 500)
    {
        Console.WriteLine("100");
        a = a - 100;
    }

    Console.WriteLine("возможная выдача");
}