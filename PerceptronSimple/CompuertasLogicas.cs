using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronSimple
{
    public class CompuertasLogicas
    {
        private ValoresEntrada valoresEntrada;

        public CompuertasLogicas(ValoresEntrada valoresEntrada)
        {
            this.valoresEntrada = valoresEntrada;
        }

        public ValoresSalida CalcularValores()
        {
           
            double w1 = valoresEntrada.W1;
            double w2 = valoresEntrada.W2;
            int epocasReales = 0;

            double[] x1 = valoresEntrada.X1;
            double[] x2 = valoresEntrada.X2;
            double[] dx = valoresEntrada.Dx;
            double[] y = new double[dx.Length];

            double menorIgualUmbral = (dx.Distinct().ToArray()).Min();
            double mayorUmbral = (dx.Distinct().ToArray()).Max();

            int epocas = valoresEntrada.Epocas;

            double umbral = valoresEntrada.Umbral;
            double fact = valoresEntrada.Factor;



            int j = 0;
            while (j < epocas)
            {
                int con = 0;
                int i = 0;

                while (i < y.Length)
                {
                    y[i] = w1 * x1[i] + w2 * x2[i];
                    

                    if (y[i] <= umbral)
                    {
                        y[i] = menorIgualUmbral;
                    }
                    else
                    {
                        y[i] = mayorUmbral;
                    }
                    if (y[i] != dx[i])
                    {
                        if (y[i] > dx[i])
                        {
                            w1 = w1 - x1[i] * fact;
                            w2 = w2 - x2[i] * fact;
                        }
                        else
                        {
                            w1 = w1 + x1[i] * fact;
                            w2 = w2 + x2[i] * fact;
                        }

                    }
                    else
                    {
                        con = con + 1;
                        if (con == dx.Length)
                        {
                            j = epocas;
                        }
                    }
                    i = i + 1;
                }
                j = j + 1;
                epocasReales += 1;
            }


            return new ValoresSalida()
            {
                W1 = w1,
                W2 = w2,
                Epocas = epocasReales,
               
            };

        }


    }
}
