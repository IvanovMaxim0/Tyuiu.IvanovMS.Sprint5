using Tyuiu.IvanovMS.Sprint5.Task2.V10.Lib;
class Porgram
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Двумерные массивы  (статический ввод)                                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
        Console.WriteLine("* отрицательные на 0.                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] mtrx = new int[3, 3] { { 4, 3, -3 }, { -5, -6, -3 }, { -7, -9, -9 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        

        for (int i = 0; i < rows; i++)
        { 
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");  
            }
            Console.WriteLine();    
        }
        string res = ds.SaveToFileTextData(mtrx);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadKey();
    }
}