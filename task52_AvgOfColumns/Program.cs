/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void FillArray(double[,] array) // метод заполнения массива
{
    Random random = new Random();
    int rows = array.GetLength(0); //метод GetLength используем, чтобы получить количество строк заданного массива в текущем методе
    int columns = array.GetLength(1); //метод GetLength используем, чтобы получить количество столбцов заданного массива в текущем методе  
    
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            array[i, j] = random.Next(0,11);
        }
    }
}

void PrintArray(double[,] array) // метод для вывода двумерного массива
{
    int rows = array.GetLength(0); //метод GetLength используем, чтобы получить количество строк заданного массива в текущем методе
    int columns = array.GetLength(1); //метод GetLength используем, чтобы получить количество столбцов заданного массива в текущем методе
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            Console.Write($"{array[i, j]}\t"); // \t используется, чтобы элементы массива при их выводе были визуально выравнены
        }
        Console.WriteLine();
    }
}

void PrintArrayOneDimensional(double[] array) // метод для вывода одномерного массива (будем выводить результат решения задачи посредством одномерного массива)
{
    int size = array.Length;

    for (int i = 0; i < size; i ++)
    {
        if (i < size - 1)
        {
            Console.Write($"{array[i]}; ");
        }
        
        if (i == size - 1)
        {
            Console.Write($"{array[i]}. ");
        }
    }
}

void FindAvgColumn(double[,] array) // метод нахождения среднего арифтметического каждого столбца
{

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] result = new double[columns]; // создаём одномерный массив для записи в него результатов вычислений среднего арифтметического каждого столбца
    double count = 0;
    double sum = 0;
    double avg = 0;

    for (int j = 0; j < columns; j ++) // заполняем одномерный массив путём вычисления среднего арифметического каждого столбца
    {
        
        for (int i = 0; i < rows; i ++)
        {
            count++;
            sum = sum + array[i,j];
        }
    
        avg = sum/count;
        result[j] = Math.Round(avg, 2); // округляем результат до двух знаков после запятой
        
        // обнуляем переменные перед каждой итерацией внешнего цикла for по столбцам массива
        avg = 0; 
        count = 0;
        sum = 0;
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    PrintArrayOneDimensional(result); // распечатываем полученный одномерный массив
}

// инициализируем массив
Random random = new Random();

int rows = random.Next(2, 11); // количество строк определяется случайным образом
int columns = random.Next(2, 11); // количество столбцов определяется случайным образом
Console.Clear();
Console.WriteLine($"Массив размером {rows} * {columns}");
double[,] numbers = new double[rows, columns];

FillArray(numbers); //заполняем двумерный массив посредством метода
PrintArray(numbers); //выводим двумерный массив посредством метода
Console.WriteLine();
FindAvgColumn(numbers); // расситываем и выводим полученный результат решения задачи в одномерном массиве посредством созданого метода