Console.Clear();
Console.Write("Введите пятизначное число :");
int a = int.Parse(Console.ReadLine());
int num1 = a/10000;
int num2 = a/1000%10;
int num3 = a/10%10;
int num4 = a%10;
if(a>99999 || a<10000)
{
    Console.WriteLine("Ошибка");
    return;
}
else if (num1==num4 && num2==num3)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}