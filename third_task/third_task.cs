int N = new Random().Next(5,10);
int[] array = new int[N];
int difference = 0;

for(int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(0 ,100);
Console.WriteLine(array[i]);
}
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }    
    else if( array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine(max - min);