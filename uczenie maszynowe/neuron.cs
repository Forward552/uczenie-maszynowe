namespace uczenie_maszynowe
{
    public class Warstwa
    {
        int warstwa;
        protected int funkcja;//metody
        int liczbaNeuronow;
    }

    public class Neuron:Warstwa
    {
        Metody m = new Metody();
        Random r = new Random();
        int pozycja;
        int wejscia = 4;
        public double[] x;
        public double[] w;
        double y;
        public Neuron()
        {
            for (int i = 0; i < wejscia; i++)
            {
                x[i] = Dane.x[0, i];
            }
            
            w= new double[wejscia];
            for (int i = 0; i < wejscia; i++)
            {
                w[i] = r.NextDouble();
            }
        }

        double net()
        {
            double sum=0;
            for (int i = 0; i < pozycja; i++)
            {
                sum+=w[i] * x[i]; 
            }
            return sum;
        }

        public double wynik()
        {
            switch (funkcja)
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





    }
}
