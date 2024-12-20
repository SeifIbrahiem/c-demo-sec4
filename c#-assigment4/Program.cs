#region q1
//using System;

//public class Program
//{
//    public static void PassByValue(int x)
//    {
//        x = x * 2;
//        Console.WriteLine("Inside PassByValue: x = " + x);
//    }

//    public static void PassByReference(ref int x)
//    {
//        x = x * 2;
//        Console.WriteLine("Inside PassByReference: x = " + x);
//    }

//    public static void Main(string[] args)
//    {
//        int num = 5;

//        Console.WriteLine("Before PassByValue: num = " + num);
//        PassByValue(num);
//        Console.WriteLine("After PassByValue: num = " + num);

//        Console.WriteLine("\nBefore PassByReference: num = " + num);
//        PassByReference(ref num);
//        Console.WriteLine("After PassByReference: num = " + num);
//    }
//} 
#endregion

#region q2
//using System;
//public class MyClass
//{
//    public int Value { get; set; }
//}

//public class Program
//{
//    public static void PassByValue(MyClass obj)
//    {
//        Console.WriteLine("Inside PassByValue: obj.Value = " + obj.Value);
//        obj.Value = 100;
//        Console.WriteLine("Inside PassByValue: obj.Value = " + obj.Value);
//        obj = new MyClass { Value = 200 };
//        Console.WriteLine("Inside PassByValue: obj.Value = " + obj.Value);
//    }

//    public static void PassByReference(ref MyClass obj)
//    {
//        Console.WriteLine("Inside PassByReference: obj.Value = " + obj.Value);
//        obj.Value = 100;
//        Console.WriteLine("Inside PassByReference: obj.Value = " + obj.Value);
//        obj = new MyClass { Value = 200 };
//        Console.WriteLine("Inside PassByReference: obj.Value = " + obj.Value);
//    }

//    public static void Main(string[] args)
//    {
//        MyClass myObject = new MyClass { Value = 50 };

//        Console.WriteLine("Before PassByValue: myObject.Value = " + myObject.Value);
//        PassByValue(myObject);
//        Console.WriteLine("After PassByValue: myObject.Value = " + myObject.Value);

//        Console.WriteLine("\nBefore PassByReference: myObject.Value = " + myObject.Value);
//        PassByReference(ref myObject);
//        Console.WriteLine("After PassByReference: myObject.Value = " + myObject.Value);
//    }
//} 
#endregion

#region q3
//using System;

//public class Calculator
//{
//    public static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
//    {
//        int sum = num1 + num2 + num3 + num4;
//        int difference = num1 - num2 - num3 - num4;
//        return (sum, difference);
//    }

//    public static void Main(string[] args)
//    {
//        Console.Write("Enter number 1: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("Enter number 2: ");
//        int num2 = int.Parse(Console.ReadLine());

//        Console.Write("Enter number 3: ");
//        int num3 = int.Parse(Console.ReadLine());

//        Console.Write("Enter number 4: ");
//        int num4 = int.Parse(Console.ReadLine());

//        (int sum, int difference) result = Calculate(num1, num2, num3, num4);

//        Console.WriteLine($"Sum: {result.sum}");
//        Console.WriteLine($"Difference: {result.difference}");
//    }
//} 
#endregion

#region q4
//using System;

//public class DigitSum
//{
//    public static int CalculateDigitSum(int number)
//    {
//        int sum = 0;

//        while (number > 0)
//        {

//            int digit = number % 10;
//            sum += digit;
//            number /= 10;
//        }
//        return sum;
//    }
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        int sumOfDigits = CalculateDigitSum(number);

//        Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
//    }
//} 
#endregion

#region q5
//using System;
//public class PrimeNumberChecker
//{
//    public static bool IsPrime(int number)
//    {
//        if (number <= 1)
//        {
//            return false;
//        }
//        if (number <= 3)
//        {
//            return true;
//        }
//        if (number % 2 == 0 || number % 3 == 0)
//        {
//            return false;
//        }
//        for (int i = 5; i * i <= number; i += 6)
//        {
//            if (number % i == 0 || number % (i + 2) == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter an integer: ");
//        int number = int.Parse(Console.ReadLine());

//        if (IsPrime(number))
//        {
//            Console.WriteLine($"{number} is a prime number.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} is not a prime number.");
//        }
//    }
//} 
#endregion

#region q6
//using System;

//public class ArrayMinMax
//{
//    public static void MinMaxArray(int[] arr, ref int min, ref int max)
//    {
//        if (arr.Length == 0)
//        {
//            throw new ArgumentException("Array is empty.");
//        }

//        min = arr[0];
//        max = arr[0];

//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//            {
//                min = arr[i];
//            }
//            if (arr[i] > max)
//            {
//                max = arr[i];
//            }
//        }
//    }

//    public static void Main(string[] args)
//    {
//        int[] numbers = { 5, 2, 9, 1, 5, 6 };
//        int min = 0;
//        int max = 0;
//        MinMaxArray(numbers, ref min, ref max);
//        Console.WriteLine($"Minimum value: {min}");
//        Console.WriteLine($"Maximum value: {max}");
//    }
//} 
#endregion

#region q9
//using System;

//public class IdentityMatrix
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of the identity matrix (n): ");
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (i == j)
//                {
//                    Console.Write("1 ");
//                }
//                else
//                {
//                    Console.Write("0 ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//} 
#endregion

#region q10
//using System;

//public class ArraySum
//{
//    public static int CalculateSum(int[] arr)
//    {
//        int sum = 0;
//        foreach (int num in arr)
//        {
//            sum += num;
//        }

//        return sum;
//    }
//    public static void Main(string[] args)
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        int sum = CalculateSum(numbers);

//        Console.WriteLine($"The sum of all elements in the array is: {sum}");
//    }
//} 
#endregion

#region q12
//using System;
//public class FrequencyCounter
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 8, 3, 2, 2, 2, 5, 1 };
//        var frequencies = arr.GroupBy(x => x)
//                            .Select(g => new { Element = g.Key, Frequency = g.Count() });
//        Console.WriteLine("Element | Frequency");
//        Console.WriteLine("--------|----------");
//        foreach (var freq in frequencies)
//        {
//            Console.WriteLine($"{freq.Element} | {freq.Frequency}");
//        }
//    }
//} 
#endregion

#region q13
//using System;

//public class MaxMinFinder
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 5, 2, 9, 1, 5, 6 };
//        int max = arr.Max();
//        int min = arr.Min();
//        Console.WriteLine("Maximum element: " + max);
//        Console.WriteLine("Minimum element: " + min);
//    }
//} 
#endregion

#region q14
//using System;
//public class SecondLargestFinder
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 12, 35, 1, 10, 34, 1 };
//        int secondLargest = arr.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
//        Console.WriteLine("Second largest element: " + secondLargest);
//    }
//} 
#endregion

#region q18
//using System;

//public class CopyMultidimensionalArray
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the number of rows: ");
//        int rows = int.Parse(Console.ReadLine());
//        Console.Write("Enter the number of columns: ");
//        int cols = int.Parse(Console.ReadLine());
//        int[,] arr1 = new int[rows, cols];
//        int[,] arr2 = new int[rows, cols];
//        Console.WriteLine("Enter values for the first array:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"[{i},{j}]: ");
//                arr1[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                arr2[i, j] = arr1[i, j];
//            }
//        }
//        Console.WriteLine("\nSecond array:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{arr2[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }
//} 
#endregion


