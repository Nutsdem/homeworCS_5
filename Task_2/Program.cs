// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] numbers = new int[10];

void fillArray(int[] array){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next();
  }
}

void writeArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int quantitySum(int[] array){
    int quantity = 0;
    int sum = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      sum = sum + array[i];
      quantity++;
    }
  }
  return sum;
}

fillArray(numbers);
writeArray(numbers);
Console.WriteLine();

int sum = quantitySum(numbers);
Console.WriteLine($"Сумма нечётных: {sum}");