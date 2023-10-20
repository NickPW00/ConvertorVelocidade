internal class Program
{
    private static void Main(string[] args)
    {
        double quilometros, hora, minuto, segundo, horaGeral;
        Console.WriteLine("Adicione a distancia em metro");
        quilometros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Adicione o tempo em hora");
        hora = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Adicione o tempo em minuto");
        minuto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Adicione o tempo em segundo");
        segundo = Convert.ToDouble(Console.ReadLine());

        hora *= 3600; 
        minuto *= 60;

        horaGeral = hora + minuto + segundo; 

        Console.WriteLine($"{quilometros / horaGeral} m/s");
        Console.WriteLine($"{((quilometros / horaGeral) * 3.6)} km/h");
        Console.WriteLine($"{((quilometros / horaGeral) *  2.23694)} mph");
        Console.ReadKey();
    }
}