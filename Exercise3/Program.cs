using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {

            var list = new List<string> { 
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", 
            };

            var names = list.FindAll(s => s.Length <= 5);

            foreach(var n in names) {
                Console.WriteLine(n);
            }
            
        }
    }
}

