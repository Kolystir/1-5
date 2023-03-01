// Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N,
// содержащий N первых положительных нечетных чисел: 1, 3, 5, … .
Console.Write("Введите количество чисел в массиве: ");
int massiv = Convert.ToInt32(Console.ReadLine());
int[] main = new int[massiv];
int a = 1;
for (int i = 0; i < massiv; i++)
{
    main[i] = a;
    a = a + 2;
}
Console.WriteLine("Вот ваши числа в массиве: ");
for (int i = 0; i < massiv; i++)
{
    Console.Write(main[i]);
    Console.Write(" ");
}