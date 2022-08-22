// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
// 

int[] arr = fillarr(6,1,1000);
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",arr));
int n=10;
int m=100;
int count=0;
//  цикл поиска значений массива лежащих в отрезке [10,99]
for ( int i=0; i< arr.Length; i++ )
{
    if (arr[i]>=n && arr[i]<m)
    {
        count++;
    }
   
}
Console.WriteLine("количество элементов массива, значения которых лежат в отрезке [10,99]:");
Console.Write(count);

