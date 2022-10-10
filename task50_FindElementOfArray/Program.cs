/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

void FillArray(int[,] array) // метод заполнения массива
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

void PrintArray(int[,] array) // метод для вывода массива
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

int InputMessage(string message) // метод для ввода данных пользователем
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FindElement(int[,] array) // метод дял решения самой задачи
{
    int row = (InputMessage("Введите номер строки элемента: ") - 1); //запрашиваем у пользователя порядковый номер строки нужного элемента, отнимаем единицу от введёного числа, так как в обычной жизни считаем строки с единицы, а не с нуля
    int column = (InputMessage("Введите номер столбца элемента: ") - 1); //запрашиваем у пользователя порядковый номер столбца нужного элемента, отнимаем единицу от введёного числа, так как в обычной жизни считаем столбцы с единицы, а не с нуля

    // если пользователь ввёл номер строки или (и) столбца за пределами массива
    if (row < 0 | row > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    {
        Console.WriteLine("Искомый элемент не найден.");
    }
    
    // если пользователь ввёл корректные числа (количество строк и столбцов), начинаем поиск искомого элемента
    else
    { 
        Console.WriteLine($"Искомый элемент найден: {array[row, column]}");
    }
}

// инициализируем массив
Random random = new Random();
int rows = random.Next(2, 8);
int columns = random.Next(2, 8);
Console.Clear();
Console.WriteLine($"Массив размером {rows} * {columns}");
int[,] numbers = new int[rows, columns];

FillArray(numbers);
PrintArray(numbers); 
FindElement(numbers);