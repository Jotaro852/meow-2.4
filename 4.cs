using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив для температур
        int[,] temperatures = new int[12, 30];

        // Заполняем массив случайными температурами от -15 до 35 (можно изменить диапазон по вашему усмотрению)
        Random random = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-15, 36);
            }
        }

        // Выводим средние температуры для каждого месяца
        int[] averageTemperatures = CalculateAverageTemperatures(temperatures);
        Array.Sort(averageTemperatures);
    
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Средняя температура в месяце {month + 1}: {averageTemperatures[month]}°C");
        }
    }
    
    // Метод для вычисления средней температуры для каждого месяца
    static int[] CalculateAverageTemperatures(int[,] temperatures)
    {
        int[] averageTemperatures = new int[12];
        for (int month = 0; month < 12; month++)
        {
            int sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures[month] = sum / 30;
        }
        return averageTemperatures;
    }
}