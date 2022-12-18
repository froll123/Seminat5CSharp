/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int[] num = new int[array];
RandomNumbers(num);
Console.WriteLine("массив: ");
RegisterArray(num);
int count = 0;

for(int i = 0; i < num.Length; i++)
if (num[i] % 2 == 0)
count++;

Console.WriteLine($"всего {num.Length} значений, {count} - четные");

void RandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,2000);
    }
}

void RegisterArray(int[] num)
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.Write("");
}


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[array];
FillArrayRandomNumbers(arr);
Console.WriteLine("массив: ");
PrintArray(arr);
int sum = 0;

for (int i = 1; i < arr.Length; i += 1) 
{
    if(i%2!=0)  
    sum += arr[i];
}

Console.WriteLine($"всего {arr.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
double[] num1 = new double[size1];
RandomNumbers(num1);
Console.Write("массив: ");
RegisterArray(num1);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num1.Length; i++)
{
    if (num1[i] > max)
    {
        max = num1[i];
    }
    if (num1[i] < min)
    {
        min = num1[i];
    }
}

Console.WriteLine($"всего {num1.Length} значений. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void RandomNumbers(double[] num1)
{
    for (int i = 0; i < num1.Length; i++)
    {
        num1[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void RegisterArray(double[] num1)
{
    Console.Write("[");
    for (int i = 0; i < num1.Length; i++)
    {
        Console.Write(num1[i] + " ");
    }
    Console.Write("]");
    Console.Write(" ");
}


/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] a = new int[50];
	   int n;
	   int i;
	   int j;

	   {
	   Console.Write("Входное количество элементов: ");
	   Console.Write("\n");
	   n = Convert.ToInt32(Console.ReadLine());
	   }

	Console.WriteLine("Входные элементы: ");

	for (i = 0; i < n; i++)
	{
		a[i] = new Random().Next(0,50);
	}

	Console.WriteLine("Массив:");
	Console.WriteLine("\n");

	for (i = 0; i < n; i++)
	{
		Console.Write(a[i]);
		Console.Write("\n");
	}
	   for (i = 0, j = n - 1; i < j; i++, j--)
	   {
	  a[i] = a[i] * a[j];
	   }
	  for (i = 0; i < n / 2; i++)
	  {
	   Console.Write(a[i]);
	   Console.Write(",");
	  }


/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

Console.Write("Введите массив: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[N];
numberOfElem(arr, N);

		for (int i = 0; i < N; i++)
		{
			arr[i] = new Random().Next(10,99);
		}
        Console.Write($"");

    int numberOfElem(double[] arr, int N)
	{
		int number = 0;
		for (int i = 0; i < N; i++)
		{
			if (arr[i] >= 10 && arr[i] <= 99)
			{
				number++;
			}
		}
		return number;
	}
	{
		Console.WriteLine("Укажите количество элементов: ");
		N = new Random().Next(10,99);
		Console.WriteLine("Количества элементов, лежащих на отрезке [10,99]");
		Console.WriteLine(numberOfElem(arr, N));
		Console.WriteLine("\n");
    }
