Console.Clear();
int count = 0;
Console.Write("Введите с клавиатуры М чисел: ");
int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        count++;
}
Console.WriteLine("Количество чисел больше нуля: {0}", count);

