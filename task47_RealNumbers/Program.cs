/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

void FillArray(double[,] array) // метод заполнения массива, double - так как надо заполнить вещественными числами
{
    Random random = new Random();
    int rows = array.GetLength(0); //метод GetLength используем, чтобы получить количество строк заданного массива в текущем методе
    int columns = array.GetLength(1); //метод GetLength используем, чтобы получить количество столбцов заданного массива в текущем методе
    
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            array[i, j] = Convert.ToDouble(random.Next(-100, 101)) / 10; // заполняем массив случайными вещественными числами в диапазоне от -100,0 до 100,0
        }
    }
}

void PrintArray(double[,] array) // метод для вывода массива
{
    int rows = array.GetLength(0); // метод GetLength используем, чтобы получить количество строк заданного массива в текущем методе 
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

void RealNumbers() // метод для создания массива
{
    Random random = new Random();
    int m = random.Next(2, 11); // количество строк получаем случайным образом
    int n = random.Next(2, 11); // количество столбцов получаем случайным образом
    Console.WriteLine($"Массив размером {m} * {n}"); // выводим в консоль сведения о размерности массива
    double[,] numbers = new double[m, n]; // инициализируем массив
    
    Console.WriteLine();
    FillArray(numbers);
    PrintArray(numbers); 
}

RealNumbers();