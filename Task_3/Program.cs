// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] numbers = new double[10];

void fillArray(double[] array){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next();
  }
}

void writeArray(double[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

double getMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double getMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}


fillArray(numbers);
writeArray(numbers);
Console.WriteLine();


double sum = getMax(numbers) - getMin(numbers);
Console.WriteLine($"Разница: {sum}");
