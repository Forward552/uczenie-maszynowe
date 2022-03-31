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
        //public static double[,] x = { { 1, 2, 3, 4 }, { 2, 3, 4, 1 } };
        //public static double[,] waga = { { 0.1, 0.2, 0.4, 0.7 }, { 0.9, 0.5, 0.1, 0.5 } };

        #endregion
        static int wierszy = 150;
        static int wartosci = 4;
        public static double[,] wartosciX;// = new double[wierszy,wartosci];
        public static int[] rodzajeX;



    

        public static void wczytaj()
        {


            





            string[] tmp;
            var text = File.ReadAllLines(@"F:\studia\Stem 6\sztuczna inteligencja\neurony\uczenie maszynowe\uczenie maszynowe\iris.data");
            //tutaj dodam instrukcje sprawdzającą ile jest wierszy a potem przypiszę warość zmiennej 
            wartosciX = new double[wierszy, wartosci];
            rodzajeX = new int[wierszy];
            for (int i = 0; i < wierszy; i++)
            {
                if (i >= text.Length)
                {
                    break; //gdy plik się skończy przerywa dalsze wczytywanie
                }
                var Linijka = text[i];
                tmp = Linijka.Split(',');

                for (int j = 0; j <= wartosci; j++)
                {
                    if (j > tmp.Length)
                    {
                        break;
                    }

                    if (double.TryParse(tmp[j].Replace('.',','),out double output))
                    {
                        wartosciX[i, j] = output;
                    }
                    else
                    {
                        switch (tmp[j])
                        {
                            case "Iris-setosa":
                                rodzajeX[i] = 1;
                                break;
                            case "Iris-versicolor":
                                rodzajeX[i] = 2;
                                break;
                            case "Iris-virginica":
                                rodzajeX[i] = 3;
                                break;
                            default:
                                rodzajeX[i] = 0;
                                break;
                        }
                    }
                        
                        
                }
            }
        }

        public static void WyswietlTablice()
        {
            if (wartosciX != null)
            {
                for (int wiersz = 0; wiersz < wierszy; wiersz++)
                {
                    for (int wartosc = 0; wartosc < wartosci; wartosc++)
                        Console.Write($"{ Dane.wartosciX[wiersz, wartosc],6}");
                    Console.Write($"  rodzaj danych: {rodzajeX[wiersz]}");
                    Console.WriteLine();
                }
            }
        }



    public static void importuj()
        {
            string text = File.ReadAllText(@"F:\studia\Stem 6\sztuczna inteligencja\neurony\uczenie maszynowe\uczenie maszynowe\iris.data");
            
            for (int i = 0; i < wierszy; i++)
            {

                for (int j = 0; j < wartosci; j++)
                {
                    
                }

            }
            Console.WriteLine(text);
        }//stary

    }
}
 

