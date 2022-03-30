using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczenie_maszynowe
{
    public static class Dane
    {

        #region tmp data set
        public static double[,] x = { { 1, 2, 3, 4 }, { 2, 3, 4, 1 } };
        //public static double[,] waga = { { 0.1, 0.2, 0.4, 0.7 }, { 0.9, 0.5, 0.1, 0.5 } };

        #endregion
        static int wierszy = 150;
        static int wartosci = 4;
      









        public static void importuj()
        {


            string text = File.ReadAllText(@"F:\studia\Stem 6\sztuczna inteligencja\neurony\uczenie maszynowe\uczenie maszynowe\iris.data");
            
            for (int i = 0; i < wierszy; i++)
            {

                for (int j = 0; j < wartosci; j++)
                {
                    foreach (string item in text)
                    {

                    }
                }

            }
            Console.WriteLine(text);
            Console.WriteLine("xd");
        }



    }
}
