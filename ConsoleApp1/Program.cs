using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //arrayin butun elementlerini string sekilde qaytaran method
            int[] arr5 = { 1, -4, 9, -8 };
            Array(arr5);
            Console.WriteLine();

            //arrayin butun elementlerinin cemini geri qaytaran meetod

            int[] arr = { 1, -4, 9, -8 };
            Console.WriteLine(Array1(arr));


            //Menfinn deyer olub olmadigin yoxlayan method
            int[] arr1 = { 1, -4, 9, -8 };
            ArrayComparison(arr1);

            Console.WriteLine();



            //arraya n sayda element elaave eden ve arrayin butun elementlerinoin hadsilini qaytartan method

            int[] arr3 = { 1, -4, 9, -8 };
            Console.WriteLine(ArrayAdd(arr3));

         




        }

        //arrayin butun elementlerini string sekilde qaytaran method

        public static void Array(int[] arr5)
        {


            string str = String.Join(" , ", arr5);
            Console.Write($"\" {str} \"");


        }


        //arrayin butun elementlerinin cemini geri qaytaran meetod

        public static int Array1(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum;


        }


        //Menfinn deyer olub olmadigin yoxlayan method


        public static void ArrayComparison(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    Console.Write(arr1[i]);
                }
            }


        }



        //arraya n sayda element elaave eden ve arrayin butun elementlerinoin hadsilini qaytartan method

        public static int ArrayAdd(int[] arr3)
        {
            int[] arr4 = arr3.Concat(new int[] { 6, 7 }).ToArray();
            Console.WriteLine(String.Join($"\" ", ", arr4 \""));
            int hasil = 1;
            for (int i = 0; i < arr3.Length; i++)
            {
                hasil *= arr3[i];

            }
            return hasil;

        }






       


    }
    }
    
