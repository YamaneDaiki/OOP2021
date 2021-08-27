using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("Sample.xml");

            foreach (var xnovelist in xdoc.Root.Elements()) {
                var xname = xnovelist.Element("name");
                var xteammembers = xnovelist.Element("teammembers");
                Console.WriteLine("{0} {1}", xname.Value, xteammembers?.Value + "人");
            }
        }

        private static void Exercise1_2(string file) {
                var xdoc = XDocument.Load(file);
                var sample2 = xdoc.Root.Elements().OrderBy(x => (string)x.Element("firstplayed"));
                foreach (var sample in sample2) {
                    var xname = sample.Element("name").Attribute("kanji");
                    Console.WriteLine(xname.Value);
            }
        }

        private static void Exercise1_3(string file) {
            
        }
    }
}
