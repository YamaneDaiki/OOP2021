﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    //フィートとメートルの単位変換クラス
    public static class InchConverter {
        private const double ratio = 0.0254;
        //メートルからフィートを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //フィートからメートルを求める
        public static double ToMeter(double inch) {
            return inch * ratio;
        }


    }
}

