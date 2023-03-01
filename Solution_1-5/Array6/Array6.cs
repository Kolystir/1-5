// Даны целые числа N (> 2), A и B. Сформировать и вывести целочисленный массив размера N, первый элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих.
Console.Write("Введите переменную N > 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную B: ");
int b = Convert.ToInt32(Console.ReadLine());
int f = 2;
int c = a;
int d = b;
int e = 0;
if (n > 2)
{

    int[] posledovatelnost = new int[n];
    for (int i = 0; i < n - 2; i++)
    {

        e += a + b;
        posledovatelnost[i] = e;
    }
    Console.WriteLine($"1 массив = {c}");
    Console.WriteLine($"2 массив = {d}");
    for (int i = 0; i < n - 2; i++)
    {
        Console.WriteLine($"{f + 1} массив  = " + posledovatelnost[i]);
    }

}
else
{
    Console.WriteLine("Переменная N не подходи для нешаего условия!");
}
