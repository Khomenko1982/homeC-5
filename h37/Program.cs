// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] arr={1,2,3,4,5}; // основной массив
int newLength=arr.Length/2+arr.Length%2; // находим половину основного  массива
int[] resultArr= new int[newLength];  // новый массив равный половине основного массива
// цикл в котором берутся первые элементы массива и умножаются на последние, 
//и при каждом заходе i сдвигается на 1
for (int i=0; i< newLength; i++)
{
    resultArr[i]=arr[i]* arr[arr.Length-1-i];
}
// условие, если длина массива нечетная, то элемент который находится в серединй массива, выводим как есть, без умножения
if (arr.Length % 2==1)
{
    resultArr[resultArr.Length-1]=arr[arr.Length/2];
}
Console.WriteLine("Исходный массив");
Console.WriteLine(String.Join(", ",arr));
Console.WriteLine("Новый массив");
Console.WriteLine(String.Join(", ",resultArr));