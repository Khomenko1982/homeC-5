// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] arr = fillarr(10,-10,10);
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",arr));
SwapArr(arr);
Console.WriteLine("Преобразованный массив :");
Console.WriteLine(String.Join(", ",arr));

// Метод возвращает массив на size элементов 
int[] fillarr(int size, int lefts, int rights)
{
int[] array =new int[size];

Random random= new Random();
for ( int i=0; i< size; i++ )
{
    array[i]=random.Next(lefts,rights+1);
}
return array;
}
void SwapArr(int[] array)
{
    for ( int i=0; i< array.Length; i++ )
    {
        array[i]=array[i]*-1;
        // array[i]=-array[i];
    }
}

