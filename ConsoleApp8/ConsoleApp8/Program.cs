 using System;

public class Program
{
	public static void Main()
	{
		//1. Ədədlərdən ibarət arrayın ən kiçik və ən böyük elementinin yerini dəyişən method yazın

		int[] numbers = { 2, 6, 55, 12, 25, 3, 11 };
        Console.Write("new array: ");
		foreach (int num in numbers)
		{
            Console.Write(num + " ");
		}
		swap(numbers);
        Console.WriteLine("  ");
        Console.Write("old array: ");
		foreach (int num in numbers)
		{
            Console.Write(num+ " "	);
		}
        Console.ReadLine(	);
	}
	static void swap(int[] numbers)
	{
		int min=0 ;
		int maks = 0;
		numbers[min] = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[min] > numbers[i])
				min = i;
			if (numbers[maks] < numbers[i])
				maks = i;
		}

		
			int index = numbers[min];
			numbers[min] = numbers[maks];
			numbers[maks] = index;
		}
	}