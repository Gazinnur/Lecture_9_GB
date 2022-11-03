// сортировка от минимума к максимуму

int[] Text = { 1, 2, 5, 6, 8, 1, 2, 6 };

void PrintText(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Hello, World!");

void SelectionSort(int[] Arr)
{
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < Arr.Length; j++)
        {
            if (Arr[j] < Arr[minPosition]) minPosition = j;
        }
        int temPorary = Arr[i];
        Arr[i] = Arr[minPosition];
        Arr[minPosition] = temPorary;
    }
}

void SelectionSortmax(int[] Arr)
{
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < Arr.Length; j++)
        {
            if (Arr[j] > Arr[maxPosition]) maxPosition = j;
        }
        int temPorary = Arr[i];
        Arr[i] = Arr[maxPosition];
        Arr[maxPosition] = temPorary;
    }
}
PrintText(Text);
SelectionSort(Text);
PrintText(Text);

SelectionSortmax(Text);
PrintText(Text);