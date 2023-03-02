// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[4];
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
	numbers[i] = new Random().Next(0, 11);

}
Console.WriteLine(string.Join(" ", numbers));
for (int j = 0; j < numbers.Length; j += 2)
{
	sum = sum + numbers[j];
}

Console.WriteLine($"Количество элементов стоящих на нечетных позициях {sum}");


