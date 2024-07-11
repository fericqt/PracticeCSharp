using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeC_ {

    class Program {

        static void Main(string[] args) {

            int[] myInput = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.Write("Please enter input:");
                int input = int.Parse(Console.ReadLine());
                myInput[i] = input;
            }

            Console.WriteLine("Maximum Sub Array:"+MaximumSubArraySum(myInput));
            SystemPause();
        }

        static int MaximumSubArraySum(int[] value) {
            int maxSoFar = value[0];
            int maxEndHere = value[0];

            for (int i = 0; i < value.Length; i++) {
                maxEndHere = Math.Max(value[i], maxEndHere + value[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndHere);
            } 
            return maxSoFar;

        }

        static decimal HeximalToDecimal(string value) {
            decimal dValue = 0m;
            decimal bValue = 1m;

            for(int i = value.Length - 1; i >= 0; i--) {
                int d = value[i] - '0';
                dValue += d * bValue;
                bValue *= 6;
            }
            return dValue;
        }
        static string DecimalToHeximal(int value) {
            string hex = "";
            while (value > 0) {
                int r = value % 6;
                hex += r;
                value /= 6;
            }
            return hex;
        }

        static string GetFizzBuzzResult(int i) {
            if (i % 5 == 0 && i % 3 != 0) {
                return "Buzz";
            }
            else if (i % 3 == 0 && i % 5 != 0) {
                return "Fizz";
            }
            else if (i % 3 == 0 && i % 5 == 0) {
                return "FizzBuzz";
            }
            return i.ToString();
        }



        static int GetNumber(List<int> list) {
            var list2 = list;
            var tempList = new List<int>();
            foreach (var item in list) {

                if (tempList.FirstOrDefault() == item) {

                    tempList.Add(item);

                }
            }
            return tempList.Count;

        }

        static bool IsPalindromeNo(int num) {
            if (num < 0 || (num % 10 == 0 && num != 0)) {
                return false; // Numbers less than 0 and numbers ending with 0 (except 0 itself) are not palindromes
            }

            int reversed = 0;
            while (num > reversed) {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }

            // For even-length numbers, num and reversed will be equal
            // For odd-length numbers, reversed will be one digit ahead of num
            return num == reversed || num == reversed / 10;
        }



        static StringBuilder GenerateFibonacci(int n) {
            var res = new StringBuilder();
            int a = 0;
            int b = 1;
            int c = 0;
            res.Append(a + ", ");
            res.Append(b + ", ");
            for (int i = 2; i < n; i++) {
                c = a + b;
                res.Append(c + ", ");
                a = b;
                b = c;
            }
            return res;
        }


        static bool AreAnagrams(string input1, string input2) {
            input1.ToLower(); input2.ToLower();
            int input1Count = 0;
            int input2Count = 0;
            for (int i = 0; i < input1.Length; i++) {
                if (input2.Contains(input1[i])) {
                    input1Count++;
                }
            }
            for (int j = 0; j < input2.Length; j++) {
                if (input1.Contains(input2[j])) {
                    input2Count++;
                }
            }
            return input1Count == input2Count;
        }
        static bool IsPrime(int n) {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i < Math.Sqrt(n); i += 2) {

                if (n % i == 0) {
                    return false;
                }

            }
            return true;
        }

        static void SystemPause() {
            // Pause the program before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
