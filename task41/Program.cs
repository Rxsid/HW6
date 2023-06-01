// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    System.Console.WriteLine(message);
    string number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}

int [] FillArrayWithNumber(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Promt("Введите число");
    }
    return arr;
}

int SumPosNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
        
    }
    return sum;
}

System.Console.WriteLine("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithNumber(length);
System.Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество положительных чисел равно {SumPosNumber(array)}");