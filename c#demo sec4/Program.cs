namespace c_demo_sec4
{
    internal class Program
    {
        #region function
        //static void printshape()
        //{
        //    //body 
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("<>");
        //    }
        //}
        //static void printshape(int count)
        //{
        //    //body 
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("***");
        //    }
        //}
        //static void printshape(int count, string pattern)
        //{
        //    //body 
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}
        // static int SumNumbers (int NumberO1 , int NumberO2 )
        //{
        //    return NumberO1 + NumberO2;
        //} 
        #endregion

        #region passing by value 
        //static void swap(int x, int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion

        #region passing by ref
        //static void swap(ref int x, ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}  
        #endregion

        #region reference type parameter passing by value
        //static int Sumarray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        // }
        #endregion

        #region reference type parameter passing by value

        //static int Sumarray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        #endregion

        #region PARAMETER PASSING BY REFERENCE
        //static int Sumarray( ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region one dimenssion array
            //int[] Numbers;
            //Numbers = new int[3];
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            ////Numbers[3]= 4;  out of range
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine($"Enter numbers [{i}]: ");
            ////    Numbers[i] = int.Parse(Console.ReadLine());
            ////}
            ////Console.WriteLine("---------------------");
            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine($"Enter numbers [{i}]: ");
            ////}
            //Console.WriteLine(Numbers.Length);//size
            //Console.WriteLine(Numbers.Rank);//dimenssion 
            #endregion

            #region two d array
            //int[,] marks = new int[3, 3];
            //marks[0, 0] = 1;
            //marks[0, 1] = 2;
            //marks[0, 2] = 5;
            //marks[1, 0] = 10;
            //marks[1, 1] = 55;
            //marks[1, 2] = 87;
            //marks[2, 0] = 55;
            //marks[2, 1] = 25;
            //marks[2, 2] = 29;
            //Console.WriteLine(marks[0,0]);
            //Console.WriteLine(marks[0, 1]);
            //Console.WriteLine(marks[0, 2]);
            //Console.WriteLine(marks[1, 0]);
            //Console.WriteLine(marks[1, 1]);
            //Console.WriteLine(marks[1, 2]);
            //Console.WriteLine(marks[2, 0]);
            //Console.WriteLine(marks[2, 1]);
            //Console.WriteLine(marks[2, 2]);
            #endregion

            #region inseted loop in array
            //int[,] marks = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //     for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"enter marks [{i}],[{j}] : ");
            //        marks[i, j] = int.Parse( Console.ReadLine() );
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{marks[i, j]}");
            //    }
            //}
            //Console.WriteLine();
            #endregion

            #region function
            //print shape();
            //print shape(5);
            //printshape(5 , "++++");
            // Console.WriteLine(SumNumbers(2,3));
            #endregion

            #region passing by value
            ////passing by value 
            //int A = 10, B = 20;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"A : {B}");
            //Console.WriteLine("After swap");
            //swap (A, B);// passing by value 
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"A : {B}"); 
            #endregion

            #region passing by reference 
            //int A = 10, B = 20;
            //Console.WriteLine($"A : {A}");//10
            //Console.WriteLine($"B : {B}");//20
            //Console.WriteLine("After swap");
            //swap (ref A, ref B);// passing by value 
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            #endregion

            #region reference type parameter passing by value
            //int[] Numbers = { 1, 2, 3 };
            //int Result = Sumarray(Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region PARAMETER PASSING BY REFERENCE
            //int[] Numbers = { 1, 2, 3 };
            //int Result = Sumarray(ref Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);
            #endregion

        }
    }
}
