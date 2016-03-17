using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_NN
{
    class siralama
    {
        public double[,] bubble_sort(double[,] dizi)
        {
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 1; j < 10 - i; j++)
                {
                    if (dizi[j, 0] < dizi[j - 1, 0])
                    {
                        double gecici = dizi[j - 1, 0];
                        double gecicindis = dizi[j - 1, 1];
                        dizi[j - 1, 0] = dizi[j, 0];
                        dizi[j - 1, 1] = dizi[j, 1];
                        dizi[j, 0] = gecici;
                        dizi[j, 1] = gecicindis;
                    }
                }
            }
            return dizi;

        }
    }
}
