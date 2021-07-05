using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    // List 7-19
    // 略語と対応する日本語を管理するクラス
    class Abbreviations { 
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        // コンストラクタ
        public Abbreviations() {
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('='))
                         .ToDictionary(x => x[0], x => x[1]);
        }

        // 要素を追加
        public void Add(string abbr, string japanese) {
            _dict[abbr] = japanese;
        }

        // インデクサ - 省略語をキーに取る
        public string this[string abbr] {
            get {
                return _dict.ContainsKey(abbr) ? _dict[abbr] : null;
            }
        }

        // 日本語から対応する省略語を取り出す
        public string ToAbbreviation(string japanese) {
            return _dict.FirstOrDefault(x => x.Value == japanese).Key;
        }

        // 日本語の位置を引数に与え、それが含まれる要素(Key,Value)をすべて取り出す
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring) {
            foreach (var item in _dict) {
                if (item.Value.Contains(substring))
                    yield return item;
            }
        }
        //7.1
        public int Count {
            get { return _dict.Count; }
        }
        //7.2
        public bool Remove(String abbr) {
            return _dict.Remove(abbr);
        }
        //7.3
        public void AddrThree() {
            foreach (var item in _dict.Where(x=> x.Key.Length == 3)) {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
        }


    }
}