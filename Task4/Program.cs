// решение через WHILE - когда не известно количество итераций или/и для посимвольного чтения файла
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


// int[] array = { 1, 10, 3, 24, 5 };
// int max = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine(max);


// вариант через FOREACH обращается последовательно к элементам массива НЕ МОЖЕТ ИЗМЕНЯТЬ элементы массива

int[] array = { 100, 10, 3, 24, 5 };
int max = array[0];

foreach (int i in array)
{
    if (i > max)
    {
        max = i;
    }
}
Console.WriteLine(max);