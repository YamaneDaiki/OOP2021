using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<student> _score;
        private IEnumerable<student> score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = score;
        }





        //メソッドの概要： 
        private static IEnumerable<student> ReadScore(string filePath) {
            List<student> students = new List<student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                student student = new student {};
                students.Add(student);
        }
    }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            IDictionary<string, int> dict = new IDictionary<string, int>();
            foreach (student student in _colle) {

            }




            
        }
    }
}
