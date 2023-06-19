Console.Clear();
Console.Write("Введите любое число:");
int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
   // Console.Write($" {Math.Pow(i,3)}");
//}
int[] arr = new int[n];
for (int i = 1; i <= n; i++)
{
    arr[i-1] = i*i*i;
}
for (int i = 0; i < n; i++)
{
    Console.Write($" {arr[i]}");
}Console.WriteLine();