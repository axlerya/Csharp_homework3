using System;
Console.WriteLine("Введите число");
int numberInput = Convert.ToInt32(Console.ReadLine());

void arrayNumbersSequence(int num)
{
    int k = 1;
    int j = 1;
    int[] arrayNumbers = new int[num];
    for (int i = 0; i < arrayNumbers.Length; i++) arrayNumbers[i] = k++;
    double[] arrayNumbersCube = new double[num];
    for (int i = 0; i < arrayNumbers.Length; i++) arrayNumbersCube[i] = Math.Pow(j++,3);
    Console.WriteLine(String.Join(", ", arrayNumbersCube));
}

arrayNumbersSequence(numberInput);