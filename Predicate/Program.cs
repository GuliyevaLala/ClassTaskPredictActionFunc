using System;
using System.Collections.Generic;

namespace Predicate {
    class Program {

        static void Main(string[] args)
        {
            //List<int> nums = new List<int>() {2, 3, 1, 5, 6, 7, 8, 9, 12};
            //var result = DividedbyThreeandSeven(Check,nums);
            //Console.WriteLine(result);

            //Action<double,double> GetExponential = GetExponential;

            //getExponential.Invoke(20, 2);

            Func<int,int> func = FindFactorial;
            
            var result = func.Invoke(4);
            Console.WriteLine(result);

        }

        public static int FindFactorial(int num)
        {
            int fact=1;


            for (var i = 1; i <= num; i++)
            {
                fact = fact * i;

            }

            return fact;

            //fact = num;
            //for (i = num - 1; i >= 1; i--)
            //{
            //    fact = fact * i;
            //}
            //return fact;
        }

        public static void GetExponential(double m, double n)
        {
            double result = Math.Pow(m, n);
            Console.WriteLine(result);
        }



        public static void FindExponential(Action<double,double> func, double m, double n)
        {
            func(m, n);
            
        }



        //public static bool Check(int num)

        //{
        //    return num % 3 == 0 && num % 7 == 0;

        //}
        //public static int DividedbyThreeandSeven(Predicate<int> predicate, List<int> arr)
        //{
        //    int result = 1;
        //    foreach (var item in arr)
        //    {
        //        if(predicate(item))
        //        {
        //            result += item;
        //        }
        //    }
        //    return result;


        //}

        //public static int DividedbyThreeandSeven(Func<int, double> function, double fact)
        //{
        //    fact = 1;
        //    foreach (var item in fact)
        //    {
        //        if (function(item))
        //        {
        //            result += item;
        //        }
        //    }
        //    return result;


        //}




    }
}
