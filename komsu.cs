using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_NN
{
    class komsu
    {
        double[,] komsucuklar;
        int iyisayisi = 0;
        int kötüsayisi = 0;
        public void komsularget(int komsusay,double[,] sonuclar,object[,] veriseti,int x1,int y1)
        {
            komsucuklar = new double[komsusay, 2];
            for (int i = 0; i < komsusay; i++)
            {
                komsucuklar[i, 0] = sonuclar[i, 0];
                komsucuklar[i, 1] = sonuclar[i, 1];

            }
            for (int i = 0; i < komsusay; i++)
            {
                int indis = Convert.ToInt32(komsucuklar[i, 1]);
                string kou = veriseti[indis, 2].ToString();
                if (kou == "İYİ")
                {
                    iyisayisi++;
                }
                else
                {
                    kötüsayisi++;
                }
                MessageBox.Show(veriseti[indis, 2].ToString());
                //MessageBox.Show(Convert.ToString(komsucuklar[i, 0]));


            }

            if (iyisayisi > kötüsayisi)
            {
                MessageBox.Show(x1 + " girişi" + y1 + " girişi için Noktanın Durumu" + "'İYİ'");
            }
            else MessageBox.Show(x1 + " girişi" + y1 + " girişi için Noktanın Durumu" + "'KÖTÜ'");

        }
    }
}
