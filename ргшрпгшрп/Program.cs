using System;

class Program
{
    static void Main(string[] args)
    {
        // Оголошення масиву чисел
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Виклик методу для обчислення суми
        int sum = CalculateSum(numbers);

        // Вивід результату
        Console.WriteLine($"Сума чисел у масиві: {sum}");
    }

    // Метод для обчислення суми елементів масиву
    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
