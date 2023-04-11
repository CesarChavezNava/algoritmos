using System;
using System.Collections;

namespace TestsApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        #region 01 HACKER RANK - PLUS MINUS

        // Test: plusMinus(new List<int>() { 1, 2, 3, -1, -2, -3, 0, 0 });

        static void plusMinus(List<int> arr)
        {
            int positives = 0, negatives = 0, zeros = 0;

            foreach (int val in arr)
            {
                if (val > 0)
                    positives += 1;
                else if (val == 0)
                    zeros += 1;
                else
                    negatives += 1;
            }

            decimal result = decimal.Divide(positives, arr.Count());
            Console.WriteLine(result.ToString("0.000000"));

            result = decimal.Divide(negatives, arr.Count());
            Console.WriteLine(result.ToString("0.000000"));

            result = decimal.Divide(zeros, arr.Count());
            Console.WriteLine(result.ToString("0.000000"));
        }

        #endregion 01 HACKER RANK - PLUS MINUS

        #region 02 HACKER RANK - MINI-MAX SUM

        // Test: miniMaxSum(new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 });
        public static void miniMaxSum(List<int> arr)
        {
            decimal sum = 0, min = arr[0], max = arr[0];

            for(int i = 0; i < arr.Count(); i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine(String.Format("{0} {1}", sum - max, sum - min));
            
        }

        #endregion 02 HACKER RANK - MINI-MAX SUM

        #region 03 HACKER RANK - TIME CONVERSION

        // test: string newTime = timeConversion("12:45:54PM");
        public static string timeConversion(string s)
        {
            bool isMorning = s.Contains("AM");
            string[] timeParts = s.Replace("AM", "").Replace("PM", "").Split(':');

            string newHour = "";
            if (timeParts[0].Equals("12") && isMorning)
                newHour = "00";
            else if (timeParts[0].Equals("12") && !isMorning)
                newHour = "12";
            else if (!isMorning && timeParts[0].StartsWith("0"))
            {
                int value = Convert.ToInt32(timeParts[0].Replace("0", "")) + 12;
                newHour = value.ToString();
            }
            else if (!isMorning)
            {
                int value = Convert.ToInt32(timeParts[0]) + 12;
                newHour = value.ToString();
            }
            else
                newHour = timeParts[0];

            return String.Format("{0}:{1}:{2}", newHour, timeParts[1], timeParts[2]);
        }

        #endregion 03 HACKER RANK - TIME CONVERSION

        #region 04 HACKER RANK - SPARSE ARRAYS

        // Tests: List<int> times = matchingStrings(new List<string>() { "ab", "ab", "abc" }, new List<string>() { "ab", "abc", "bc" });
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> times = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                times.Add(0);
                for (int j = 0; j < strings.Count; j++)
                {
                    if (queries[i].Equals(strings[j]))
                        times[i] += 1;
                }
            }

            return times;
        }

        #endregion 04 HACKER RANK - SPARSE ARRAYS

        #region 05 HACKER RANK - LONELY INTEGER

        // tests: int time1 = lonelyinteger(new List<int>() { 1, 2, 3, 4, 3, 2, 1 });
        public static int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> times = new Dictionary<int, int>();
            foreach(int i in a)
            {
                if (times.ContainsKey(i))
                    times[i] += 1;
                else
                    times[i] = 1;
            }

            return times.First(x => x.Value == 1).Key;
        }

        #endregion 05 HACKER RANK - LONELY INTEGER
    }


}