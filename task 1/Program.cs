int[] GetIntArray(int num) //перевод числа в массив 
{
    List<int> listOfInts = new();
    while(num > 0)
    {
        listOfInts.Add(num % 10);
        num /= 10;
    }
    listOfInts.Reverse();
    int[] arrayNumbersOne = listOfInts.ToArray();
    return arrayNumbersOne;
}

int[] GetIntArrayReverse(int num) //перевод числа в массив обратной последовательности 
{
    List<int> listOfInts = new();
    while(num > 0)
    {
        listOfInts.Add(num % 10);
        num /= 10;
    }
    int[] arrayNumbersTwo = listOfInts.ToArray();
    return arrayNumbersTwo;
}


Console.WriteLine("Введите число");
int numberInput = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = GetIntArray(numberInput); //вызов методов для определение массивов
int[] arrayNumberReverse = GetIntArrayReverse(numberInput);

if (arrayNumber.SequenceEqual(arrayNumberReverse) == true) // Сравнение двух массивов
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");