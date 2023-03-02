// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numbers = new double[5];

for (int i = 0; i < numbers.Length; i++)
{
	numbers[i] = new Random().Next(0, 11);

}
Console.WriteLine(string.Join(" ", numbers));
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
	if (numbers[i] > max)
	{
		max = numbers[i];
	}
	if (numbers[i] < min)
	{
		min = numbers[i];
	}
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");