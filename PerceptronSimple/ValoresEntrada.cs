using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronSimple
{
    public class ValoresEntrada
    {
        public double W1 { get; set; }
        public double W2 { get; set; }

        public double[] X1 { get; set; }
        public double[] X2 { get; set; }

        public double[] Dx { get; set; }

        public int Epocas { get; set; }

        public double Umbral { get; set; }
        public double Factor { get; set; }

    }
}
