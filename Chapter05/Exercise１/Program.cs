using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise１ {
    class Program {
        static void Main(string[] args) {
            //5.1.1
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            if (String.Compare(s1, s2, true) == 0)
                Console.WriteLine("等しいです");
            else
                Console.WriteLine("等しくないです");
            //5.1.2
            var s3 = Console.ReadLine();

            int.TryParse(s3, out int height);
            Console.WriteLine();

            }
        } 
    }
