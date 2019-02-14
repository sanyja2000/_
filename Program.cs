using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqgyak {
    class Program {

        struct ___ { //3 _
            public string _;
            public string __;
            public Int16 ____;
            public Int16 _____;
            public ___(string _______) {
                string[] ______ = _______.Split(' ');
                _ = ______[0];
                __ = ______[1];
                ____ = Convert.ToInt16(______[2]);
                _____ = Convert.ToInt16(______[3]);
            }

        }
        static List<___> ____ = new List<___>(); //4 _
        static void Main(string[] _) {
            _____();
            ______();
            Console.ReadKey();

        }
        static void _____() { //5 _
            string __ = "Pali HU 25 200";
            ____.Add(new ___(__));
            __ = "Józsi HU 25 200";
            ____.Add(new ___(__));
            __ = "Adolf DE 34 1";
            ____.Add(new ___(__));
            __ = "Angela DE 45 120";
            ____.Add(new ___(__));
            __ = "Mussolini IT 21 36";
            ____.Add(new ___(__));
            __ = "Vladimigyir RU 23 2";
            ____.Add(new ___(__));
        }
        static void ______() { // 6 _
            foreach (var _ in ____) {
                Console.WriteLine(_._ + " " + _.__ + " " + _.____ + " " + _._____);
            }
        }

        static void _______() { // 7 _ Linq EMF
            var ___ = ____.Select(_ => _);
            foreach (var _ in ___) {
                Console.WriteLine(_._ + " " + _.__ + " " + _.____ + " " + _._____);
            }
        }
        static void ________() { // 8 Linq QEF
            var __ = from _ in ____ select _;
            foreach (var _ in __) {
                Console.WriteLine(_._ + " " + _.__ + " " + _.____ + " " + _._____);
            }

        }

    }
}
