// Ejercicio1 1. Pedir las coordenadas del punto 1 (x, y) y radio en el centro (h, k) y calcular la distancia


class Ejercicio1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio:Dadas las coordenada de un punto C(h,k) y un punto P(x,y) calcular la distancia y radio ");
        Console.WriteLine("Por favor ingrese las coordenadas dicho en el enunciado:");
        Console.WriteLine();

        Console.WriteLine("Ingrese la coordenada h: ");
        double Coordenada_h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada k: ");
        double Coordenada_k = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada x: ");
        double Coordenada_x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada y: ");
        double Coordenada_y = Convert.ToDouble(Console.ReadLine());

        double radio_distancia = Math.Sqrt(Math.Pow(Coordenada_h-Coordenada_x,2) + Math.Pow(Coordenada_k-Coordenada_y,2));

        Console.WriteLine($"Las coordenadas dadas son :  C({Coordenada_h} , {Coordenada_k}) y P({Coordenada_x} , {Coordenada_y})");
        Console.WriteLine();
        Console.WriteLine($"La distancia entre los puntos de las coordenadas es:  {radio_distancia}");
    }
}

// Hecho por Josue Bryan Hernandez Zelaya