// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[10];
int EvenNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
	numbers[i] = new Random().Next(100, 1000);
	if (numbers[i] % 2 == 0)
	{
		EvenNumbers++;
	}

}
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Количество четных элементов {EvenNumbers}");

