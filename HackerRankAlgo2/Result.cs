/*** Between 2 sets, Find LCD of  and GCM of elements in 2 arrrays ***/
/**
 * Input - 1st line gives length of array1 & array2 with space separated
 *         2nd line Array1 elements separated with spaces
 *         3rd line Array2 elements separated with spaces
 * Output -        
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankAlgo2
{
    class Result
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            int lcmval = a[0];
            for(int i =0; i < a.Count; i++)
            {
                lcmval = lcmCalc(lcmval, a[i]);
            }
            Console.WriteLine($"LCM {lcmval}");
            int gcdval = b[0];
            foreach(var item in b)
            {
                gcdval = gcdCalc(gcdval, item);
            }
            Console.WriteLine($"GCD {gcdval}");
            int count = 0;
            int temp = lcmval;
            while (temp <= gcdval)
            {
                if (gcdval % temp == 0)
                {
                    count += 1;
                }
                temp += lcmval;
            }
            return count;
        }
        public static int gcdCalc(int x , int y)
        {
            if (x == 0) return y;
            return gcdCalc(y % x, x);
        }
        public static int lcmCalc(int x ,int y)
        {
            return ((x * y) / gcdCalc(x, y));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            textWriter.WriteLine(total);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
/*
 * ********* KANGAROO PROBLEM ***********************
    string result = "NO";
    double diff = (x1 - x2) % (v2 - v1); // diff is the point where 2 kangaroos can possibly meet
    if (v2 > v1) // if Kangaroo 2 moves faster than kangaroo 1,then there is no possibility of meeting at same point
    {
        result = "NO";
    }
    else if(diff == 0) // When there is possibility that kangaroos can meet
    {
        if(diff == Math.Round(diff) && diff > 0) // We are ensuring that kangaroos meet at ground and they are at same direction
        {
            result = "YES";
        }
        else // When diff is not integer and decimal ,then kangaroos are at air
        {
            result = "NO";
        }
    }
    return result;
*/
/******************** TIME CONVERSION *********************/
/*
static void Main(string[] args)
{
    string s = Console.ReadLine();

    string result = timeConversion(s);
}
static string timeConversion(string s)
{
    string[] myTimeArr = s.Split(":");
    string noonRep = myTimeArr[2].Substring(2, 2);
    myTimeArr[2] = myTimeArr[2].Substring(0, 2);
    if(noonRep.ToUpper() == "PM")
    {
        if (int.Parse(myTimeArr[0]) > 12)
        {
            myTimeArr[0] = myTimeArr[0] + 12;
        }
    }
    else 
    {
        if(myTimeArr[0] == "12")
        {
            myTimeArr[0] = "00";
        }
    }
    Console.WriteLine(string.Join(":", myTimeArr));
    return string.Join(":", myTimeArr);

} */
