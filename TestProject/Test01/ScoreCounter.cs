﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01 {
    class ScoreCounter {

        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }





        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> sales = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }


        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    //既にコレクションに(dictionary)店舗が設定されている
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }
            return dict;
        }
    }
}
