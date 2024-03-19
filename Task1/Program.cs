int[] array = new int[5]; //создание массива операторы int-целочисленное new-выделение памяти под массив
array[0] = 1;
array[1] = 2;
array[2] = 3;
array[3] = 4;
array[4] = 5;
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[3]);
Console.WriteLine(array[4]);

int[] array2 = new int[5] { 6, 7, 8, 9, 10 }; //в фигурных скобках можно указать сразу элеменеты массива

int[] array3 = { 11, 12, 13, 14, 15 } //при создании массива с заранее известными элементами можно не указывать команду new int. для создания небольших массивов.