Console.WriteLine("--- Raio e Trovão ---\n");

Console.WriteLine($"trovão a {3} segundos ==> raio atingiu {DistanciaDoRaioKm(3):N5} quilômetros");
Console.WriteLine($"trovão a {6} segundos ==> raio atingiu {DistanciaDoRaioKm(6):N5} quilômetros");

double DistanciaDoRaioKm(double segundos)
{
    const double VelocidadeDoSomKmS = 340.29 / 1000;
    return segundos * VelocidadeDoSomKmS;
}
