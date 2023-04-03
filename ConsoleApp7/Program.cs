int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(a>0)
{
    int ostatok = a % 10;
    sum = sum + ostatok;
    a = a / 10;
}
Console.WriteLine(sum);
