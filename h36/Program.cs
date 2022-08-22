// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
int[] arr = fillarr(4,-100,100);
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",arr));
int summarr=0;
//  цикл поиска суммы элементов стоящих на нечетных позициях массива
for ( int i=0; i< arr.Length; i=i+2 )
{
        summarr=arr[i]+summarr;
    }
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях. :");
Console.WriteLine(summarr);