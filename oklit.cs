using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_NN
{
    interface Ibaginti
    {
        double[,] uzaklikbagintisi(object[,] veriseti, double x1, double y1);
    }
    public class oklit:Ibaginti
    {

        double[,] sonuclar = new double[10, 2];
        double dij;
        public double[,] uzaklikbagintisi(object[,] veriseti,double x1,double y1)
        {
            for (int i = 0; i < veriseti.Length / 3; i++)
            {
                double x2 = Convert.ToDouble(veriseti[i, 0]);
                double y2 = Convert.ToDouble(veriseti[i, 1]);
                dij = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                sonuclar[i, 0] = dij;
                sonuclar[i, 1] = i;
            }
            return sonuclar;
        }

        
    }
    public class minkovski : Ibaginti
    {
        double[,] sonuclar = new double[10, 2];
        double dij;
        public double[,] uzaklikbagintisi(object[,] veriseti, double x1, double y1)
        {
            for (int i = 0; i < veriseti.Length / 3; i++)
            {
                double x2 = Convert.ToDouble(veriseti[i, 0]);
                double y2 = Convert.ToDouble(veriseti[i, 1]);

                dij = (1 / 10) * Math.Log10(Math.Pow(x1 - x2, 10) + Math.Pow(y1 - y2, 10));
                sonuclar[i, 0] = dij;
                sonuclar[i, 1] = i;
            }
            return sonuclar;
        }
    }
     public class manhattan : Ibaginti
    {

         double[,] sonuclar = new double[10, 2];
        double dij;
        public double[,] uzaklikbagintisi(object[,] veriseti, double x1, double y1)
        {
            for (int i = 0; i < veriseti.Length / 3; i++)
            {
                double x2 = Convert.ToDouble(veriseti[i, 0]);
                double y2 = Convert.ToDouble(veriseti[i, 1]);

                dij = x1 - x2 + y1 - y2;
                if (dij < 0)
                    dij = dij * (-1);
                sonuclar[i, 0] = dij;
                sonuclar[i, 1] = i;
            }
            return sonuclar;
        }
    }
    
}
