﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if (product == null) {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できた時の処理
                Console.WriteLine("productが取得できた");
            }


        }

        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Prduct = new Product();
            sale = null;
            return sale.Prduct;    //null条件演算子
        }
    }



    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Prduct { get; set; }
    }
}

