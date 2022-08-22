// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ

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


int[] arr = fillarr(10,-10,10);
Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",arr));
Console.Write("Введите число? поиск которого будет производиться в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());

bool result= NumIsArr(arr,a);
if (result==true)
{
    Console.WriteLine("Да");
    } 

    else
    {
    Console.WriteLine("Нет");
        } 
// метод поиска заданного числа в массиве
bool NumIsArr(int[] array, int findnumber)
{
    bool flag=false;
   for  ( int i=0; i< array.Length; i++ )
    {
        if (array[i]==findnumber)

       {
        flag=true;
        break;
       }
       }
       return flag;
    }
