﻿using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("最も価格の高い本は" + books.Max(x => x.Price)+"円");
            Console.WriteLine("最も価格の安い本は" + books.Min(x => x.Price) + "円");
            //500円以上の本は何冊
            Console.WriteLine("500円以上の本は" + books.Count(x =>x.Price>=500)+"冊");
            Console.WriteLine("「物語」が含まれている冊数は" + books.Count(x => x.Title.Contains("物語"))+ "冊です");

            var bookDate = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach (var book in bookDate) {
                Console.WriteLine(book.Title);
            }
            //高額書籍ベスト3
            var query = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var item in query) {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            Console.WriteLine();

            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
