int N = new Random().Next(5,10);
int[] array = new int[N];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0 ,99999);
    if (array[i] % 2 ==0 && i % 2 != 0)
    {
        sum += array[i];
    }   
}
Console.WriteLine(sum);