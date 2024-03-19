// мое решение
int[] array = { 1, 10, 3, 4, 5 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);