//Программа, которая будет находить произведение двух матриц

// метод перемножения квадратных матриц
int[,] Multiplicate_matrix(int[,] input_arrayA, int[,] input_arrayB)
{
    int arraySize = input_arrayA.GetLength(0);
    int[,] resultMatrix = new int[arraySize, arraySize];
    for (int index = 0; index < input_arrayA.GetLength(0); index++)
    {
        for (int j = 0; j < input_arrayA.GetLength(1); j++)
        {
            for (int k = 0; k < input_arrayA.GetLength(1); k++)
            {
                resultMatrix[index,j] += input_arrayA[index,k]*input_arrayB[k,j];
            }
        }
    }

    return resultMatrix;
}

System.Console.WriteLine("Введите размер квадратной матрицы");
int matrixSize = Convert.ToInt32(Console.ReadLine());

// Задаем первую матрицу случайных целых чисел
int[,] matrixA = new int[matrixSize, matrixSize];
Random rnd = new Random();

System.Console.WriteLine("Первая матрица");
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        matrixA[i, j] = rnd.Next(1, 10);
        System.Console.Write(matrixA[i, j] + "\t");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица");
// Задаем вторую матрицу случайных целых чисел
int[,] matrixB = new int[matrixSize, matrixSize];
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        matrixB[i, j] = rnd.Next(1, 10);
        System.Console.Write(matrixB[i, j] + "\t");
    }
    System.Console.WriteLine();
}

int[,] matrixMultiplication = new int[matrixSize, matrixSize];

System.Console.WriteLine();
System.Console.WriteLine("Произведение матриц");
//перемножаем матрицы и выводим результат на экран
matrixMultiplication = Multiplicate_matrix(matrixA,matrixB);
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        System.Console.Write(matrixMultiplication[i, j] + "\t");
    }
    System.Console.WriteLine();
}