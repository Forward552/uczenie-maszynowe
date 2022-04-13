using uczenie_maszynowe;
Random r = new Random();
Metody m = new Metody();
Dane.wczytaj();

int linijka = 0;
Console.WriteLine("Podaj linijkę którą chcesz tesować");
if (int.TryParse(Console.ReadLine(), out int l))
{
    linijka = l;
}
else linijka = 0;
Neuron a = new Neuron(linijka);
Console.WriteLine("Podaj ilość neuronów w warstwie ukrytej");
if (int.TryParse(Console.ReadLine(), out int u))
{
    a.liczbaNeuronow = u;
}
else a.liczbaNeuronow = 5;

Console.WriteLine("Test działania neurona: "+a.y);


double[] warstwaUkryta = new double[a.liczbaNeuronow];
//ukryta warstwa neuronowa
for (int j = 0; j < a.liczbaNeuronow; j++)
{
    double[] x = new double[a.liczbaNeuronow];
    for (int i = 0; i < a.liczbaNeuronow; i++)
    {
        x[i] = a.y;
    }

    double[] w = new double[a.liczbaNeuronow];
    for (int i = 0; i < a.liczbaNeuronow; i++)
    {
        w[i] = r.NextDouble();
    }

    double sum = 0;
    for (int i = 0; i < a.liczbaNeuronow; i++)
    {
        sum += w[i] * x[i];
    }
    warstwaUkryta[j] = m.DipolarnaCioglaSin(sum);
}

Console.WriteLine("Wyniki neuronów w warstwie ukrytej");
for (int i = 0; i < a.liczbaNeuronow; i++)
{
Console.WriteLine(warstwaUkryta[i]);

}
Console.Write("Wynik Neurona sumującego: ");
Console.Write(a.NeuronSumujacy(warstwaUkryta).ToString());
//Dane.WyswietlTablice();

