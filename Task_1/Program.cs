int[] numbers = new int[10];

void fillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void writeArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int quantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

fillArray(numbers, 100, 1000);
writeArray(numbers);
Console.WriteLine();

int quantity = quantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");