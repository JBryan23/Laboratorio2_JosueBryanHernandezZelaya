//2.Dada la fecha actual extraer, el día, mes, año, y decir cuántos días faltan para
//navidad y año nuevo.


public class Ejercicio2
{
    public static void Main()
    {
        DateTime Fecha_Actual = DateTime.Now;
        int Fecha_Dia = Fecha_Actual.Day;
        int Fecha_Mes = Fecha_Actual.Month;
        int Fecha_Año = Fecha_Actual.Year;
        DateTime Fecha_Navidad = new DateTime(Fecha_Año, 12, 25);
        DateTime Fecha_Añonuevo = new DateTime(Fecha_Año + 1, 1, 1);

        int Dias_ParaNavidad = (Fecha_Navidad - Fecha_Actual).Days;
        int Dias_Añonuevo = (Fecha_Añonuevo - Fecha_Actual).Days;

        Console.WriteLine($"Fecha de actual: {Fecha_Dia}/{Fecha_Mes}/{Fecha_Año}");
        Console.WriteLine($"Cuantos dias faltan para Navidad: {Dias_ParaNavidad}");
        Console.WriteLine($"Cuantos dias faltan para Año nuevo: {Dias_Añonuevo}");

    }
}

// Hecho por Josue Bryan Hernandez Zelaya



    
   


    