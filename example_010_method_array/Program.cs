int[] array = { 12, 24, 83, 14, 95, 26, 78, 81 };
int n = array.Length;
int find = 78;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}