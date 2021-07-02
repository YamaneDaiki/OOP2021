using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise1 {
    class Program {
            static void Main(string[] args) {
                var text = "Cozy lummox gives smart squid who asks for job pen";
                Exercise1_1(text);
                Console.WriteLine();
            }

        private static void Exercise1_1(string text) {
            string s = text.ToUpper();
            var dict = new Dictionary<char, int>();
            foreach (var i in s) {
                if (dict.ContainsKey(i)) {
                    dict[i]++; }
                else if ('A' <= i && i <= 'Z') {
                    dict.Add(i, 1);
                }
            }
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("'" + item.Key + "'：" + item.Value);
            }
        }
    }      
}

