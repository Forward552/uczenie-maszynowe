using uczenie_maszynowe;

Metody m = new Metody();
Console.WriteLine(m.xw(1, 2).ToString());
Dane.importuj("");
Random rnd = new Random();

//zaczynamy obliczenia
for (int j = 0; j < Dane.x.Length; j++)
{




    for (int i = 0; i < Dane.x.Length; i++)
    {
        double w = rnd.Next(0, 1);
        Console.WriteLine(  double x = m.xw(Dane.x[i,0], w));


    
    }



}



