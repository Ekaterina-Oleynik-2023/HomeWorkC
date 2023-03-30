// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такой позиции нет.
Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[4, 5];

for (int i = 0; i < matrix.GetLength(0); i++) {
  for (int j = 0; j < matrix.GetLength(1); j++) {
    matrix[i, j] = random.Next(10, 90);
    Console.Write("{0} ", matrix[i, j]);
  }
  Console.WriteLine();
}
if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) {
  Console.WriteLine("Элемент не существует ");
}
else {                                
  Console.WriteLine("Значение элемента массива: {0}", matrix[row-1, column-1]); 
}