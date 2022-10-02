 // Программа, которая будет построчно выводить массив.
 // Двухмерный массив формируется из неповторяющихся двузначных чисел (размер массива не более 50 элементов)

//метод проверки уникальности элемента
bool check_element_uniq(int[,] inputArray,int curent_elemnt,int row_position,int column_position)
 {
    bool uniq = true;
    for (int i = 0; i < row_position - 1; i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (curent_elemnt == inputArray[i,j])
                {
                    uniq = false;
                    break;    
                }
        }
    }
    if (uniq)
    {
        for (int j = 0; j < column_position; j++)
        {
            if (curent_elemnt == inputArray[row_position,j])
            {
            uniq = false;
            break;    
            }
        }
    }
    return uniq;
 }

int rowsCount, columnsCount, elementCount;
rowsCount = 0;
columnsCount = 0;
elementCount = 51;
while (elementCount > 50)
{
    System.Console.WriteLine("Размер массива не должен привышать 50 элементов");
    System.Console.WriteLine("Введите количество строк");
    rowsCount = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    columnsCount = Convert.ToInt32(Console.ReadLine());
    elementCount = rowsCount * columnsCount;
}

System.Console.WriteLine("Размерность массива задана верно");

//объявляем массив и задаем первый элемент случайным образом
int[,] twoDimArray = new int[rowsCount, columnsCount];
Random rnd = new Random();
twoDimArray[0,0] = rnd.Next(10, 100);
System.Console.WriteLine("Получившися массив");
for (int i = 0; i < rowsCount; i++)
{
    int j = 0;
    while (j < columnsCount)
    {
        int new_element = rnd.Next(10, 100);
        if (check_element_uniq(twoDimArray,new_element,i,j))
        {   
            twoDimArray[i,j] = new_element;
            System.Console.Write(twoDimArray[i, j] + "\t");
            j++;
        }
        
    }
    System.Console.WriteLine();
}
