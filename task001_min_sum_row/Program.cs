//Программа, которая будет находить строку с наименьшей суммой элементов

System.Console.WriteLine("Введите количество строк");
int rowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columnsCount = Convert.ToInt32(Console.ReadLine());

// метод подсчета суммы элементов строки
int Calculate_row_element_sum(int[,] input_array,int row_index)
{   
    int row_element_sum = 0;
    for (int index = 0;  index < input_array.GetLength(1); index ++)
        {
            row_element_sum += input_array[row_index,index];
        }

    return row_element_sum;
}

// Задаем двумерный массив случайных целых чисел
int[,] twoDimArray = new int[rowsCount, columnsCount];
Random rnd = new Random();
for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = rnd.Next(1, 10);
        System.Console.Write(twoDimArray[i, j] + "\t");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

int min_sum_row_element = Calculate_row_element_sum(twoDimArray,0);
int min_sum_row_num = 0;

for (int i = 1; i < rowsCount; i++)
{
    if (Calculate_row_element_sum(twoDimArray,i) < min_sum_row_element)
    {
        min_sum_row_element = Calculate_row_element_sum(twoDimArray,i);
        min_sum_row_num = i;
    }
}


System.Console.WriteLine($"{min_sum_row_num + 1}-я строка - строка с минимальной суммой элементов");