using System;

class Program
{
    static void Main()
    {
        // Coordenadas fixas
        double x1 = -27.824516016035233;
        double y1 = -50.334242117828786;
        double x2 = -27.82182370815247;
        double y2 = -50.333849948130634;

        // Cálculo da distância euclidiana
        double distancia = CalcularDistancia(x1, y1, x2, y2);

        // Exibição da rota e distância
        Console.WriteLine("Localização inicial: ({0}, {1})", x1, y1);
        Console.WriteLine("Localização destino: ({0}, {1})", x2, y2);
        Console.WriteLine("Distância calculada (em unidades): {0}", distancia);
        Console.WriteLine("Rota sugerida: Siga o caminho direto para minimizar a distância.");
    }

    static double CalcularDistancia(double x1, double y1, double x2, double y2)
    {
        // Fórmula da distância euclidiana
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}