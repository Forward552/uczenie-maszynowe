namespace uczenie_maszynowe
{
    public class Warstwa
    {
        public int warstwa;
        public int funkcja;//metody
        public int liczbaNeuronow = 5;
    }

    public class Neuron : Warstwa
    {
        Metody m = new Metody();
        Random r = new Random();
        int pozycja;
        public int wejscia = 4;
        public double[] x;
        public double[] w;
        public double y;
        public Neuron(int wiersz)
        {
            x = new double[wejscia];
            for (int i = 0; i < wejscia; i++)
            {
                x[i] = Dane.wartosciX[wiersz, i];
            }

            w = new double[wejscia];
            for (int i = 0; i < wejscia; i++)
            {
                w[i] = r.NextDouble();
            }
            y = wynik(4);
        }

        double net()
        {
            double sum = 0;
            for (int i = 0; i < wejscia; i++)
            {
                sum += w[i] * x[i];
            }
            return sum;
        }

        public double wynik(int i)
        {
            //switch (funkcja)
            switch (i)
            {
                case 1:
                    {
                        return m.UniporalnaDys(net());
                    }
                case 2:
                    {
                        return m.DipolarnaDys(net());
                    }
                case 3:
                    {
                        return m.UnipolarnaCiogla(net());
                    }
                case 4:
                    {
                        return m.DipolarnaCioglaSin(net());
                    }
                default:
                    return 0;
            }

        }
        public double NeuronSumujacy(double[] we)
        {
            double[] x = new double[we.Length];
            for (int i = 0; i<we.Length; i++)
            {
                x[i] = we[i];
            }

        double[] w = new double[we.Length];
            for (int i = 0; i<we.Length; i++)
            {
                w[i] = r.NextDouble();
            }

            double sum = 0;
            for (int i = 0; i < we.Length; i++)
            {
              sum += w[i] * x[i];
            }
            return m.DipolarnaCioglaSin(sum);
        }
    }

         
}