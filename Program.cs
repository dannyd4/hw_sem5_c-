int[] CreateNewArray(int Length, int min, int max)
{
    int[] array = new int[Length];

    for(int i=0; i < Length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ArrayShow (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PoiskChetnih(int[] array)
{
    int Length = array.Length;
    int schet = 0;
    for(int i=0; i < Length; i++)
    {
        if ((array[i] % 2) == 0) schet++;
    }
    return schet;
}

int PoiskNeChetnih(int[] array)
{
    int Length = array.Length;
    int schet = 0;
    for(int i=0; i < Length; i++)
    {
        if (( i % 2 ) != 0) schet += array[i];
    }
    return schet;
}

double ArrayMax(double[] array)
{
    double max = array[0];
    for (int i=1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double ArrayMin(double[] array)
{
    double min = array[0];
    for (int i=1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

double[] create_new_array_double()
{
     double[] array = new double[5];

    for(int i=0; i < 5; i++)
    {
        array[i] = (new Random().Next(0,11))+ new Random().NextDouble();
    }
    return array;
}

void ArrayShowDouble (double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



// test #34 sem5 c#. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] array = CreateNewArray(4, 100, 1000);
Console.WriteLine("Был сформирован массив: ");

ArrayShow (array);

int schet = PoiskChetnih(array);
Console.WriteLine("В сформированном массиве количество чётных чисел равно: " + schet);
Console.WriteLine();
*/



// test #36 sem5 c#.  Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] array = CreateNewArray(6, 0, 10);
Console.WriteLine("Был сформирован массив: ");

ArrayShow (array);

int schet = PoiskNeChetnih(array);
Console.WriteLine("В сформированном массиве сумма чисел стоящих под нечётными индексами равна: " + schet);
Console.WriteLine();
*/



// test #38 sem5 c#. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.WriteLine("Был сформирован массив вещественных чисел: ");
double[] array = create_new_array_double();//генерируем массив

ArrayShowDouble (array);//выводим массив

Console.WriteLine("Разность между макс. и мин. значением массива равна = " + (ArrayMax(array)-ArrayMin(array)));
*/