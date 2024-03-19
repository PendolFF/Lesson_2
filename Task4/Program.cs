// мое решение
// int[] array = { 1, 10, 3, 4, 5 };
//int i = 0;
//int max = array[0];

//while (i < array.Length)
//{
//  if (array[i] > max)
//  {
//      max = array[i];
//  }
//  i++;
// }
//Console.WriteLine(max);

// вариант через FOR используется при известном заранее числе итераций


int[] array = { 1, 10, 3, 24, 5 };
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);