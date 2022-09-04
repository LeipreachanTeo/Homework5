int N = new Random().Next(5,10);
int[] array = new int[N];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 ==0)
    {
        count++;
    }
}
Console.WriteLine(count);
