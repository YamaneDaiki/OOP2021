﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region テスト用ドライバ
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }
        #endregion
        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Where(n => n > 0).Max();
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        private static void Exercise1_3(int[] numbers) {
            var str = numbers.Select(n => n.ToString());
            foreach (var item in str) {
                Console.WriteLine(item);

            }
        }

        private static void Exercise1_4(int[] numbers) {
            var query = numbers.OrderBy(x=> x).Take(3);
            foreach (var item in query) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(x => x > 10));
        }
    }
}
