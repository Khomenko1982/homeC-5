// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] arrd = new double[5] {-0.1, 0.2, 0.8,15.3,-10};
double max = arrd[0];

Console.WriteLine("Исходный массив :");
Console.WriteLine(String.Join(", ",arrd));

double maxValue = arrd.Max<double>();
double minValue = arrd.Min<double>();

Console.WriteLine("Максимальное значение :");
Console.WriteLine(maxValue);
Console.WriteLine("Минимальное значение :");
Console.WriteLine(minValue);

double difference =maxValue-minValue;

Console.WriteLine("Разница :");
Console.WriteLine(difference);



// Как то так, сначала пытался создать метод для double в части создания произвольного массива, 
// но потерпел крах, массив формировался, но не получилось добиться дробных чисел в массиве(тут надо попрактиковаться), пришлось 
// задать массив явным образом. 
// Потом пытался вычислить максимальное и минимальное значение в цикле. но случайно нарвался на вcтроенные функции Min и Max 
// и лень во мне победила))